﻿using artfolio.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace artfolio.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<Artist> _signInManager;
        private readonly UserManager<Artist> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly IWebHostEnvironment _hostingEnv;

        public RegisterModel(
            UserManager<Artist> userManager,
            SignInManager<Artist> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            IWebHostEnvironment hostingEnv)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _hostingEnv = hostingEnv;
        }

        [BindProperty]
        public InputViewModel Input { get; set; }

        [BindProperty]
        [Required]
        [Display(Name = "User name")]
        [StringLength(40, MinimumLength = 1)]
        [RegularExpression(@"^[A-Za-z0-9_.+-]*$", ErrorMessage = "Characters are not allowed.")]
        [PageRemote(
                ErrorMessage = "This user name already exists.",
                AdditionalFields = "__RequestVerificationToken",
                HttpMethod = "post",
                PageHandler = "CheckUserName"
            )]
        public string UserName { get; set; }

        [BindProperty]
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        [PageRemote(
                ErrorMessage = "Email address already exists.",
                AdditionalFields = "__RequestVerificationToken",
                HttpMethod = "post",
                PageHandler = "CheckEmail"
            )]
        public string Email { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputViewModel
        {
            public InputModel AspNetUser { get; set; }
            public Artist Artist { get; set; }

            public IFormFile Avatar { get; set; }
        }

        public class InputModel
        {
            public string UserName { get; set; }
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        public JsonResult OnPostCheckUserName()
        {
            Artist username = _userManager.Users.FirstOrDefault(x => x.UserName == UserName.ToLower()
            || x.NormalizedUserName.ToLower() == UserName.ToLower());

            return new JsonResult(username == null ? true : false);
        }

        public JsonResult OnPostCheckEmail()
        {
            Artist artistEmail = _userManager.Users.FirstOrDefault(x => x.Email == Email.ToLower() 
            || x.NormalizedEmail.ToLower() == Email.ToLower());
            
            return new JsonResult(artistEmail == null ? true : false);
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            if (ModelState.IsValid)
            {
                // FILE UPLOAD
                string uniquePhotoFileName = null;
                if (Input.Avatar != null)
                {
                    string uploadsAvatarFolder = Path.Combine(_hostingEnv.WebRootPath, "images/avatars");
                    uniquePhotoFileName = Guid.NewGuid().ToString() + "_" + Input.Avatar.FileName;
                    string photoFilePath = Path.Combine(uploadsAvatarFolder, uniquePhotoFileName);
                    Input.Avatar.CopyTo(new FileStream(photoFilePath, FileMode.Create));

                    string uploadsThumbnailAvatarFolder = Path.Combine(_hostingEnv.WebRootPath, "images/avatars/thumbnails");
                    string thumbnailFilePath = Path.Combine(uploadsThumbnailAvatarFolder, uniquePhotoFileName);

                    Image image = Image.FromStream(Input.Avatar.OpenReadStream(), true, true);

                    double ratio = 200 * 1.0 / image.Width;
                    int newHeight = (int)Math.Floor(image.Height * ratio);

                    var newImage = new Bitmap(200, newHeight);

                    using var thumbnail = Graphics.FromImage(newImage);
                    thumbnail.CompositingQuality = CompositingQuality.HighSpeed;
                    thumbnail.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    thumbnail.CompositingMode = CompositingMode.SourceCopy;
                    thumbnail.DrawImage(image, 0, 0, 200, newHeight);

                    newImage.Save(thumbnailFilePath);
                }

                var user = new Artist
                {
                    UserName = UserName,
                    Email = Email,
                    Lastname = Input.Artist.Lastname,
                    Firstname = Input.Artist.Firstname,
                    Description = Input.Artist.Description,
                    DateOfBirth = Input.Artist.DateOfBirth,
                    Nationality = Input.Artist.Nationality,
                    Gender = Input.Artist.Gender,
                    IsPubliclyVisible = Input.Artist.IsPubliclyVisible,
                    PhotoFilePath = uniquePhotoFileName
                };

                var result = await _userManager.CreateAsync(user, Input.AspNetUser.Password);

                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Email });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}