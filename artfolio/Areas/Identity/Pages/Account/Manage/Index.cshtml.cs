using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using artfolio.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace artfolio.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<Artist> _userManager;
        private readonly SignInManager<Artist> _signInManager;

        public IndexModel(
            UserManager<Artist> userManager,
            SignInManager<Artist> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [BindProperty]
        [Display(Name ="User name")]
        [PageRemote(
                ErrorMessage = "This user name already exists.",
                AdditionalFields = "__RequestVerificationToken",
                HttpMethod = "post",
                PageHandler = "CheckUserName"
            )]
        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Display(Name = "User name")]
            public string Username { get; set; }
        }

        private async Task LoadAsync(Artist user)
        {
            var userName = await _userManager.GetUserNameAsync(user);

            Username = userName;
            Input = new InputModel
            {
                Username = userName
            };
        }

        public async Task<JsonResult> OnPostCheckUserName()
        {
            Artist username = _userManager.Users.FirstOrDefault(x => x.UserName == Username.ToLower()
            || x.NormalizedUserName.ToLower() == Username.ToLower());

            return new JsonResult((username != null && username != await _userManager.GetUserAsync(User)) ? false : true);
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            if (Input.Username != user.UserName)
            {
                var setUserNameResult = await _userManager.SetUserNameAsync(user, Input.Username);
                if(!setUserNameResult.Succeeded)
                {
                    StatusMessage = "Error: This name is already taken";
                    return RedirectToPage();
                }
            }
            //var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            //if (Input.PhoneNumber != phoneNumber)
            //{
            //    var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
            //    if (!setPhoneResult.Succeeded)
            //    {
            //        var userId = await _userManager.GetUserIdAsync(user);
            //        throw new InvalidOperationException($"Unexpected error occurred setting phone number for user with ID '{userId}'.");
            //    }
            //}

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
