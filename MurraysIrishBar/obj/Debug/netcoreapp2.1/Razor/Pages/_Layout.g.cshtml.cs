#pragma checksum "D:\code\my_code\2019\packt\em.cloud.aspnetcore.razor.resturant\MurraysIrishBar\Pages\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f2c347cdd1c2d3aac2ed10038429af4ae4a9fe9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MurraysIrishBar.Pages.Pages__Layout), @"mvc.1.0.view", @"/Pages/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/_Layout.cshtml", typeof(MurraysIrishBar.Pages.Pages__Layout))]
namespace MurraysIrishBar.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\code\my_code\2019\packt\em.cloud.aspnetcore.razor.resturant\MurraysIrishBar\Pages\_ViewImports.cshtml"
using MurraysIrishBar.Domain;

#line default
#line hidden
#line 2 "D:\code\my_code\2019\packt\em.cloud.aspnetcore.razor.resturant\MurraysIrishBar\Pages\_ViewImports.cshtml"
using MurraysIrishBar.Repository;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f2c347cdd1c2d3aac2ed10038429af4ae4a9fe9", @"/Pages/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b29f18eac9c7d0fdfdd6e8597e144d7b97d8beac", @"/Pages/_ViewImports.cshtml")]
    public class Pages__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("logo-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 189, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43caab473533459db246292646934ff3", async() => {
                BeginContext(31, 44, true);
                WriteLiteral("\r\n    <title>Murrays Irish Bar</title>\r\n    ");
                EndContext();
                BeginContext(75, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "662dac6bcde2417d9986d18c2504a156", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(150, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(156, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e01aa135922d4e97abfd80fdcfd8c4e9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(203, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(214, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(216, 2825, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c29ddf0c9544ee8931a8f6365979ae6", async() => {
                BeginContext(222, 115, true);
                WriteLiteral("\r\n    <header class=\"container\">\r\n        <div class=\"row\">\r\n\r\n            <div class=\"mx-auto\" >\r\n                ");
                EndContext();
                BeginContext(337, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fcb0101fa31b41768a7e134826b03a21", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(387, 1216, true);
                WriteLiteral(@"
            </div>

           
        </div>
        <div class=""row"">

            <nav class=""navbar navbar-expand-lg navbar-dark bg-dark"" style=""width: 100%"">
                
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarText"" aria-controls=""navbarText"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""collapse navbar-collapse"" id=""navbarText"">
                    <ul class=""navbar-nav mr-auto"">
                        <li class=""nav-item active"">
                            <a class=""nav-link"" href=""/"">Menu <span class=""sr-only"">(current)</span></a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/About"">About</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=");
                WriteLiteral("\"nav-link\" href=\"/Contact\">Contact</a>\r\n                        </li>\r\n                    </ul>\r\n\r\n                    <ul class=\"nav navbar-nav navbar-right\">\r\n                        <li>\r\n");
                EndContext();
#line 41 "D:\code\my_code\2019\packt\em.cloud.aspnetcore.razor.resturant\MurraysIrishBar\Pages\_Layout.cshtml"
                             if (!User.Identity.IsAuthenticated)
                            {

#line default
#line hidden
                BeginContext(1700, 89, true);
                WriteLiteral("                                <a href=\"/Admin/AddEditMenu\" class=\"nav-link\">Login</a>\r\n");
                EndContext();
#line 44 "D:\code\my_code\2019\packt\em.cloud.aspnetcore.razor.resturant\MurraysIrishBar\Pages\_Layout.cshtml"
                            }
                            else
                            {

#line default
#line hidden
                BeginContext(1885, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(1917, 421, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "155d19a752a64054993e148a1594a382", async() => {
                    BeginContext(1989, 135, true);
                    WriteLiteral("\r\n                                    <div class=\"input-group\">\r\n                                        <span class=\"nav-link active\">");
                    EndContext();
                    BeginContext(2125, 18, false);
#line 49 "D:\code\my_code\2019\packt\em.cloud.aspnetcore.razor.resturant\MurraysIrishBar\Pages\_Layout.cshtml"
                                                                 Write(User.Identity.Name);

#line default
#line hidden
                    EndContext();
                    BeginContext(2143, 188, true);
                    WriteLiteral("</span>\r\n                                        <button type=\"submit\" class=\"btn btn-success\">Logout</button>\r\n                                    </div>\r\n                                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2338, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 53 "D:\code\my_code\2019\packt\em.cloud.aspnetcore.razor.resturant\MurraysIrishBar\Pages\_Layout.cshtml"
                            }

#line default
#line hidden
                BeginContext(2371, 149, true);
                WriteLiteral("                        </li>\r\n                    </ul>\r\n\r\n                </div>\r\n            </nav>\r\n\r\n        </div>\r\n        <div class=\"row\">\r\n");
                EndContext();
#line 62 "D:\code\my_code\2019\packt\em.cloud.aspnetcore.razor.resturant\MurraysIrishBar\Pages\_Layout.cshtml"
             if (IsSectionDefined("Title"))
            {
                

#line default
#line hidden
                BeginContext(2597, 39, false);
#line 64 "D:\code\my_code\2019\packt\em.cloud.aspnetcore.razor.resturant\MurraysIrishBar\Pages\_Layout.cshtml"
           Write(RenderSection("Title", required: false));

#line default
#line hidden
                EndContext();
#line 64 "D:\code\my_code\2019\packt\em.cloud.aspnetcore.razor.resturant\MurraysIrishBar\Pages\_Layout.cshtml"
                                                        
            }
            else
            {

#line default
#line hidden
                BeginContext(2686, 34, true);
                WriteLiteral("                <h2 class=\"title\">");
                EndContext();
                BeginContext(2721, 17, false);
#line 68 "D:\code\my_code\2019\packt\em.cloud.aspnetcore.razor.resturant\MurraysIrishBar\Pages\_Layout.cshtml"
                             Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(2738, 7, true);
                WriteLiteral("</h2>\r\n");
                EndContext();
#line 69 "D:\code\my_code\2019\packt\em.cloud.aspnetcore.razor.resturant\MurraysIrishBar\Pages\_Layout.cshtml"
            }

#line default
#line hidden
                BeginContext(2760, 68, true);
                WriteLiteral("        </div>\r\n    </header>\r\n    <div class=\"container\">\r\n        ");
                EndContext();
                BeginContext(2829, 12, false);
#line 73 "D:\code\my_code\2019\packt\em.cloud.aspnetcore.razor.resturant\MurraysIrishBar\Pages\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2841, 134, true);
                WriteLiteral("\r\n\r\n    </div>\r\n    <footer>\r\n        <div class=\"text-center\">\r\n            <hr />\r\n            <span class=\"text-muted\">Murrays Bar ");
                EndContext();
                BeginContext(2976, 17, false);
#line 79 "D:\code\my_code\2019\packt\em.cloud.aspnetcore.razor.resturant\MurraysIrishBar\Pages\_Layout.cshtml"
                                            Write(DateTime.Now.Year);

#line default
#line hidden
                EndContext();
                BeginContext(2993, 41, true);
                WriteLiteral(" </span>\r\n        </div>\r\n    </footer>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3041, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IMenuRepository Repository { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
