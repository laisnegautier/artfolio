#pragma checksum "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf9aff8e181aba16f32cb165fd1269ef84441495"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf9aff8e181aba16f32cb165fd1269ef84441495", @"/Views/Artist/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ffa75b2f7f79d6603f90d1780c0134b1795ff87", @"/Views/_ViewImports.cshtml")]
    public class Views_Artist_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Artist>
    {
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
  
    ViewData["Title"] = Model.Firstname + " " + Model.Lastname + "'s artfolio";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row justify-content-center"">
    <div class=""col-md-12"" style=""border: 1px solid red; height: 100px;"">
    </div>
</div>

<div class=""row justify-content-center"">
    <div class=""col-md-2 d-none d-lg-block"">
        <h2 class=""font-weight-lighter"">collections</h2>
");
#nullable restore
#line 18 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
         if (SignInManager.IsSignedIn(User) && UserManager.GetUserName(User) == Model.UserName)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a href=\"#\">add a collection</a>\r\n");
#nullable restore
#line 21 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>


    <div class=""col-md-7"">
        <div class=""d-flex justify-content-between"">
            <h2 class=""font-weight-lighter"">artworks</h2>
            </div>

    </div>
    <div class=""col-md-2"">
        <h2 class=""font-weight-lighter"">filters</h2>
    </div>

    <div class=""d-none"">
        <h1>Artist</h1>

        <ul>
            <li>");
#nullable restore
#line 39 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
           Write(Html.DisplayFor(a => a.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>");
#nullable restore
#line 40 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
           Write(Html.DisplayFor(a => a.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>");
#nullable restore
#line 41 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
           Write(Html.DisplayFor(a => a.Firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>");
#nullable restore
#line 42 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
           Write(Html.DisplayFor(a => a.Lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>");
#nullable restore
#line 43 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
           Write(Html.DisplayFor(a => a.Nationality));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cf9aff8e181aba16f32cb165fd1269ef844414956287", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1361, "~/images/avatars/thumbnails/", 1361, 28, true);
#nullable restore
#line 44 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
AddHtmlAttributeValue("", 1389, Model.PhotoFilePath, 1389, 20, false);

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
#line 46 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
             if (Model.FollowedBy.Count > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>followedBy :</p>\r\n");
#nullable restore
#line 49 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
                foreach (var followedBy in Model.FollowedBy)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>");
#nullable restore
#line 51 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
                  Write(followedBy.FromArtist.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 51 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
                                                  Write(followedBy.FromArtist.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 51 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
                                                                                   Write(followedBy.FromArtist.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 52 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 55 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
             if (Model.Following.Count > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>following :</p>\r\n");
#nullable restore
#line 58 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
                foreach (var following in Model.Following)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>");
#nullable restore
#line 60 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
                  Write(following.FromArtist.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 60 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
                                                 Write(following.FromArtist.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 60 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
                                                                                 Write(following.FromArtist.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 61 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artist\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\nz\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Artist> Html { get; private set; }
    }
}
#pragma warning restore 1591
