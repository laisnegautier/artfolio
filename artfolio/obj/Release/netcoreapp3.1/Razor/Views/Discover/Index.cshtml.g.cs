#pragma checksum "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebe354497585ce076be224d8c4c32dc21f36ff4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Discover_Index), @"mvc.1.0.view", @"/Views/Discover/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebe354497585ce076be224d8c4c32dc21f36ff4d", @"/Views/Discover/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ffa75b2f7f79d6603f90d1780c0134b1795ff87", @"/Views/_ViewImports.cshtml")]
    public class Views_Discover_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SearchIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin: auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("profile picture"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ml-1 d-flex align-items-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/icons/star-outline.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("15"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("You follow this artist"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("You follow this artist"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Artist", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("artists-list list-group-item list-group-item-action flex-column align-items-start pl-2 pr-3 py-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("25"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Discover", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
  
    ViewData["Title"] = "Discover";
    Layout = "~/Views/Shared/_Layout.cshtml";

    string categoryImageUrl = null;
    int[] i = new int[] { 0, 0, 0, 0 };
    int index = 0;

    string selection(string selection)
    {
        return (selection == (string)ViewData["category"]) ? "selected" : "";
    }
    string redirectCategory(string category)
    {
        return (@selection(category) != "") ? "" : category;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-10 mx-auto d-flex justify-content-center\">\r\n    <div class=\"col-md-2 d-none d-lg-block\">\r\n        <h2 class=\"font-weight-lighter\">artists</h2>\r\n");
#nullable restore
#line 26 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
         if (!Model.Artists.Any())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h6>No artist found</h6>\r\n");
#nullable restore
#line 29 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"list-group\">\r\n");
#nullable restore
#line 33 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
                 foreach (var artist in Model.Artists)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebe354497585ce076be224d8c4c32dc21f36ff4d10702", async() => {
                WriteLiteral(@"
                        <div class=""d-flex w-100 align-items-center"">
                            <div class=""profile-pic-nav d-none d-lg-flex"" style=""overflow: hidden; width: 40px; height: 40px; display: flex; justify-content: center; align-items: center"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ebe354497585ce076be224d8c4c32dc21f36ff4d11255", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1474, "~/images/avatars/thumbnails/", 1474, 28, true);
#nullable restore
#line 38 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
AddHtmlAttributeValue("", 1502, Html.DisplayFor(modelItem => artist.PhotoFilePath), 1502, 51, false);

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
                            <div class=""d-flex justify-content-between flex-grow-1"">
                                <div class=""ml-2 d-flex flex-column justify-content-center"">
                                    <h6 class=""m-0"">
                                        ");
#nullable restore
#line 43 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => artist.Firstname));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 43 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
                                                                                   Write(Html.DisplayFor(modelItem => artist.Lastname));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </h6>\r\n                                    <small class=\"m-0 text-muted\">\r\n                                        ");
#nullable restore
#line 46 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => artist.UserName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </small>\r\n                                </div>\r\n");
#nullable restore
#line 49 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
                                 if (artist.FollowedBy.Count > 0)
                                {
                                    if (SignInManager.IsSignedIn(User))
                                    {
                                        foreach (var followedBy in artist.FollowedBy)
                                        {
                                            if (followedBy.FromArtistId == UserManager.GetUserId(User))
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ebe354497585ce076be224d8c4c32dc21f36ff4d15318", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 58 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
                                            }
                                        }
                                    }
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userName", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
                                                                          WriteLiteral(artist.UserName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userName"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 65 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 67 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <div class=\"col-md-7\">\r\n        <div class=\"d-flex justify-content-between\">\r\n            <h2 class=\"font-weight-lighter\">artworks</h2>\r\n\r\n");
            WriteLiteral("            <div>\r\n");
#nullable restore
#line 76 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
                 foreach (Category category in Enum.GetValues(typeof(Category)))
                {
                    categoryImageUrl = "images/icons/categories/" + category.ToString() + ".svg";

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebe354497585ce076be224d8c4c32dc21f36ff4d20509", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ebe354497585ce076be224d8c4c32dc21f36ff4d20789", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4111, "~/", 4111, 2, true);
#nullable restore
#line 80 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
AddHtmlAttributeValue("", 4113, categoryImageUrl, 4113, 17, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 80 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
AddHtmlAttributeValue("", 4148, category.ToString(), 4148, 20, false);

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
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-q", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
                                                                     WriteLiteral(ViewData["q"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["q"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-q", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["q"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
                                                                                                    WriteLiteral(ViewData["tag"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tag"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-tag", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tag"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
                                                                                                                                          WriteLiteral(redirectCategory(category.ToString()));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-category", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3924, "btn", 3924, 3, true);
            AddHtmlAttributeValue(" ", 3927, "btn-artfolio", 3928, 13, true);
            AddHtmlAttributeValue(" ", 3940, "font-weight-light", 3941, 18, true);
            AddHtmlAttributeValue(" ", 3958, "btn-category", 3959, 13, true);
#nullable restore
#line 79 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
AddHtmlAttributeValue(" ", 3971, selection(category.ToString()), 3972, 31, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 79 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
AddHtmlAttributeValue("", 4024, category.ToString(), 4024, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 79 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
AddHtmlAttributeValue("", 4053, category.ToString(), 4053, 20, false);

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
            WriteLiteral("\r\n");
#nullable restore
#line 82 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
            WriteLiteral("        </div>\r\n\r\n");
#nullable restore
#line 87 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
         if (!Model.Artworks.Any())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h6>No artwork found</h6>\r\n");
#nullable restore
#line 90 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row-card p-0 m-0\">\r\n");
#nullable restore
#line 94 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
                 for (int col = 0; col < 4; col++)
                {
                    index = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"column-card\">\r\n");
#nullable restore
#line 98 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
                         foreach (var artwork in Model.Artworks)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
                             if (index % 4 == col)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
                           Write(await Html.PartialAsync("_ArtworkCard", new ArtworkCardPartialViewModel { Artwork = artwork }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
                                                                                                                               
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
                             
                            index++;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 107 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 109 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <div class=\"col-md-2 artfolio-content\">\r\n        <h2 class=\"font-weight-lighter\">filters</h2>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebe354497585ce076be224d8c4c32dc21f36ff4d31652", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"q\"");
                BeginWriteAttribute("value", " value=\"", 5322, "\"", 5344, 1);
#nullable restore
#line 115 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
WriteAttributeValue("", 5330, ViewData["q"], 5330, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <input type=\"search\" name=\"tag\" placeholder=\"Filter by tag\" style=\"padding: 7px 12px; border: 1px solid lightgray; border-radius: 5px;\">\r\n");
#nullable restore
#line 117 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
             if (!String.IsNullOrEmpty((string)ViewData["category"]))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input type=\"hidden\" name=\"category\"");
                BeginWriteAttribute("value", " value=\"", 5638, "\"", 5667, 1);
#nullable restore
#line 119 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
WriteAttributeValue("", 5646, ViewData["category"], 5646, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 120 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Discover\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input type=\"submit\" value=\"filter\" class=\"btn btn-artfolio\" />\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_14.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <ul>
            <li><a href=""#"">CC0</a></li>
            <li><a href=""#"">CC1</a></li>
            <li><a href=""#"">CC2</a></li>
            <li><a href=""#"">CC3</a></li>
            <li><a href=""#"">CC4...</a></li>

            <li><a href=""#"">latest releases</a></li>
            <li><a href=""#"">oldest releases</a></li>
            <li><a href=""#"">alphabetical order</a></li>
            <li><a href=""#"">reverse alphabetical order</a></li>
            <li><a href=""#"">see only the artist I follow</a></li>
        </ul>
        <hr />
        <ul>
            <li>Released after ...</li>
            <li>Released before ...</li>
        </ul>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SearchIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
