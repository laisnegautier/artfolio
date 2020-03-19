#pragma checksum "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcc83dda12128517a2e17318c2f985cb4ef3b7d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Artist_Index), @"mvc.1.0.view", @"/Views/Artist/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\_ViewImports.cshtml"
using artfolio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\_ViewImports.cshtml"
using artfolio.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\_ViewImports.cshtml"
using artfolio.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcc83dda12128517a2e17318c2f985cb4ef3b7d8", @"/Views/Artist/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ffa75b2f7f79d6603f90d1780c0134b1795ff87", @"/Views/_ViewImports.cshtml")]
    public class Views_Artist_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ArtistIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("400"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin: auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("profile picture"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
  
    ViewData["Title"] = Model.Artist.Firstname + " " + Model.Artist.Lastname + "'s artfolio";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row justify-content-center\">\r\n    <div class=\"col-md-4 d-flex flex-column justify-content-center align-items-center\">\r\n        <h1>");
#nullable restore
#line 11 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
       Write(Model.Artist.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
                               Write(Model.Artist.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <h2 class=\"small text-muted\">artfolio.com/");
#nullable restore
#line 12 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
                                             Write(Model.Artist.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <a href=\"#\" class=\"openModal text-center\" data-id=\"");
#nullable restore
#line 13 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
                                                      Write(Model.Artist.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 13 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
                                                                        Write(Model.Artist.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
    </div>
    <div class=""col-md-3 d-flex justify-content-center"">
        <div class=""profile-pic-nav"" style=""border-radius: 500px; box-shadow: 0 2px 4px lightgray; opacity: 1; overflow: hidden; width: 200px; height: 200px; display: flex; justify-content: center; align-items: center"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fcc83dda12128517a2e17318c2f985cb4ef3b7d86707", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 962, "~/images/avatars/", 962, 17, true);
#nullable restore
#line 17 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
AddHtmlAttributeValue("", 979, Model.Artist.PhotoFilePath, 979, 27, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
    <div class=""col-md-4 d-flex justify-content-center align-items-center"">
        <button class=""btn btn-artfolio"">send a message</button>
        <button class=""btn btn-artfolio"">follow</button>
    </div>
</div>

<div class=""row justify-content-center"">
    <div class=""col-md-2 d-none d-lg-block"">
        <h2 class=""font-weight-lighter"">collections</h2>
");
#nullable restore
#line 29 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
         if (SignInManager.IsSignedIn(User) && UserManager.GetUserName(User) == Model.Artist.UserName)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a href=\"#\">add a collection</a>\r\n");
#nullable restore
#line 32 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""tab"">
        <button class=""tablinks"" onclick=""openCity(event, 'London')"" id=""defaultOpen"">London</button>
        <button class=""tablinks"" onclick=""openCity(event, 'Paris')"">Paris</button>
        <button class=""tablinks"" onclick=""openCity(event, 'Tokyo')"">Tokyo</button>
    </div>
    </div>


    <div class=""col-md-7"">
        <div class=""d-flex justify-content-between"">
            <h2 class=""font-weight-lighter"">artworks</h2>

            <div id=""London"" class=""tabcontent"">
                <h3>London</h3>
                <p>London is the capital city of England.</p>
            </div>

            <div id=""Paris"" class=""tabcontent"">
                <h3>Paris</h3>
                <p>Paris is the capital of France.</p>
            </div>

            <div id=""Tokyo"" class=""tabcontent"">
                <h3>Tokyo</h3>
                <p>Tokyo is the capital of Japan.</p>
            </div>
        </div>

    </div>
    <div class=""col-md-2"">
        <h2 class=");
            WriteLiteral("\"font-weight-lighter\">filters</h2>\r\n    </div>\r\n\r\n    <div class=\"d-none\">\r\n        <h1>Artist</h1>\r\n\r\n        <ul>\r\n            <li>");
#nullable restore
#line 70 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
           Write(Html.DisplayFor(a => a.Artist.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>");
#nullable restore
#line 71 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
           Write(Html.DisplayFor(a => a.Artist.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>");
#nullable restore
#line 72 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
           Write(Html.DisplayFor(a => a.Artist.Firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>");
#nullable restore
#line 73 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
           Write(Html.DisplayFor(a => a.Artist.Lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>");
#nullable restore
#line 74 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
           Write(Html.DisplayFor(a => a.Artist.Nationality));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fcc83dda12128517a2e17318c2f985cb4ef3b7d812011", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3125, "~/images/avatars/thumbnails/", 3125, 28, true);
#nullable restore
#line 75 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
AddHtmlAttributeValue("", 3153, Model.Artist.PhotoFilePath, 3153, 27, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n\r\n");
#nullable restore
#line 77 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
             if (Model.Artist.FollowedBy.Count > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>followedBy :</p>\r\n");
#nullable restore
#line 80 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
                foreach (var followedBy in Model.Artist.FollowedBy)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>");
#nullable restore
#line 82 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
                  Write(followedBy.FromArtist.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 82 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
                                                  Write(followedBy.FromArtist.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 82 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
                                                                                   Write(followedBy.FromArtist.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 83 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 86 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
             if (Model.Artist.Following.Count > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>following :</p>\r\n");
#nullable restore
#line 89 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
                foreach (var following in Model.Artist.Following)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>");
#nullable restore
#line 91 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
                  Write(following.FromArtist.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 91 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
                                                 Write(following.FromArtist.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 91 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
                                                                                 Write(following.FromArtist.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 92 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            z\r\n\r\n");
            WriteLiteral("        </ul>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<Artist> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<Artist> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ArtistIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
