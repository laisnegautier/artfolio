#pragma checksum "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "284787091c2d0d422ca274c83fb51afc95b14b06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Artwork_Index), @"mvc.1.0.view", @"/Views/Artwork/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"284787091c2d0d422ca274c83fb51afc95b14b06", @"/Views/Artwork/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ffa75b2f7f79d6603f90d1780c0134b1795ff87", @"/Views/_ViewImports.cshtml")]
    public class Views_Artwork_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ArtworkIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin: auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("profile picture"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("artwork-thumbnail-pic"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Artwork", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("See the details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("See the details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 50px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
  
    ViewData["Title"] = Model.Artwork.Title + ", by " + @Model.Artist.Firstname + " " + @Model.Artist.Lastname;
    Layout = "~/Views/Shared/_Layout.cshtml";
    string formatToImg(string acromym)
    {
        return acromym + ".sm.png";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div>\r\n        <h3>Artwork by</h3>\r\n        <div class=\"profile-pic-nav d-none d-lg-flex\" style=\"overflow: hidden; width: 40px; height: 40px; display: flex; justify-content: center; align-items: center\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "284787091c2d0d422ca274c83fb51afc95b14b068453", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 521, "~/images/avatars/thumbnails/", 521, 28, true);
#nullable restore
#line 14 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
AddHtmlAttributeValue("", 549, Model.Artist.PhotoFilePath, 549, 27, false);

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
            WriteLiteral("\r\n        </div>\r\n        <h6 class=\"m-0\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
       Write(Model.Artist.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 17 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
                               Write(Model.Artist.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h6>\r\n        <small class=\"m-0 text-muted\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
       Write(Model.Artist.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </small>\r\n    </div>\r\n\r\n<hr />\r\n\r\n<div>\r\n    <h3>Details</h3>\r\n    ");
#nullable restore
#line 28 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
Write(Model.Artwork.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 932, "\"", 939, 0);
            EndWriteAttribute();
            WriteLiteral(" >SIGNALER CETTE OEUVRE</a>\r\n");
#nullable restore
#line 30 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
     if (Model.Artwork.Documents != null && Model.Artwork.Documents.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "284787091c2d0d422ca274c83fb51afc95b14b0611816", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "284787091c2d0d422ca274c83fb51afc95b14b0612084", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1274, "~/images/artworks/", 1274, 18, true);
#nullable restore
#line 33 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
AddHtmlAttributeValue("", 1292, Model.Artwork.Documents[0].FilePath, 1292, 36, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 33 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
AddHtmlAttributeValue("", 1365, Model.Artwork.Title, 1365, 20, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 1385, ",", 1385, 1, true);
                AddHtmlAttributeValue(" ", 1386, "by", 1387, 3, true);
#nullable restore
#line 33 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
AddHtmlAttributeValue(" ", 1389, Model.Artist.Firstname, 1390, 23, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
AddHtmlAttributeValue(" ", 1413, Model.Artist.Lastname, 1414, 22, false);

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
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userName", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
                                                               WriteLiteral(Model.Artist.UserName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userName"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
                                                                                                        WriteLiteral(Model.Artwork.NormalizedTitle);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-title", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 35 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
     if (Model.Artwork.ArtworkTags.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Tags : </p>\r\n");
#nullable restore
#line 40 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
         foreach (var artworkTag in Model.Artwork.ArtworkTags)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
       Write(artworkTag.Tag.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
                                
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5 class=\"mb-1\">");
#nullable restore
#line 45 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
                Write(Model.Artwork.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    <h5 class=\"mb-1\">");
#nullable restore
#line 46 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
                Write(Model.Artwork.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    <h6 class=\"small mb-1\">");
#nullable restore
#line 47 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
                      Write(Model.Artwork.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral(", released ");
#nullable restore
#line 47 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
                                                        Write(Html.DisplayFor(modelItem => Model.Artwork.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "284787091c2d0d422ca274c83fb51afc95b14b0620382", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1928, "~/images/ccicons/", 1928, 17, true);
#nullable restore
#line 48 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
AddHtmlAttributeValue("", 1945, formatToImg(Model.Artwork.CCLicense.Acronym), 1945, 45, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1997, "CC", 1997, 2, true);
#nullable restore
#line 48 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
AddHtmlAttributeValue(" ", 1999, Model.Artwork.CCLicense.Title, 2000, 30, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 2030, "License", 2031, 8, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2047, "CC", 2047, 2, true);
#nullable restore
#line 48 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
AddHtmlAttributeValue(" ", 2049, Model.Artwork.CCLicense.Title, 2050, 30, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 2080, "License", 2081, 8, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 50 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
     if (Model.Artwork.Collection != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Collection : ");
#nullable restore
#line 52 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
                   Write(Model.Artwork.Collection.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 53 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<hr />\r\n\r\n<div>\r\n    <h3>Supports</h3>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "284787091c2d0d422ca274c83fb51afc95b14b0623986", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "284787091c2d0d422ca274c83fb51afc95b14b0624253", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
#nullable restore
#line 60 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.ArtworkId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
                                                   WriteLiteral(Model.Artwork.ArtworkId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "284787091c2d0d422ca274c83fb51afc95b14b0626662", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 61 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Support.Content);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"support\" class=\"btn btn-artfolio\" />\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 65 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
     if (Model.Artwork.Supports.Count > 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
         foreach (var support in Model.Artwork.Supports)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <ul>\r\n                <li>Support by ");
#nullable restore
#line 70 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
                          Write(support.Artist.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 70 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
                                                    Write(support.Artist.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li>");
#nullable restore
#line 71 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
               Write(support.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li><em>Posted on ");
#nullable restore
#line 72 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
                             Write(support.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em></li>\r\n            </ul>\r\n");
#nullable restore
#line 74 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h5 class=\"small\"><b>be the 1st to support</b></h5>\r\n");
#nullable restore
#line 79 "C:\Users\Gautier\source\repos\artfolio\artfolio\Views\Artwork\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ArtworkIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
