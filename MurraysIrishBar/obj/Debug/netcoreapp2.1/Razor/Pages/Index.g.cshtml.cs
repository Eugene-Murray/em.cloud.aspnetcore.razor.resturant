#pragma checksum "D:\code\my_code\2019\packt\em.cloud.aspnetcore.razor.resturant\MurraysIrishBar\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec7026ecbedbe632582a2b6a4737b8c7f0dfafaa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MurraysIrishBar.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(MurraysIrishBar.Pages.Pages_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec7026ecbedbe632582a2b6a4737b8c7f0dfafaa", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b29f18eac9c7d0fdfdd6e8597e144d7b97d8beac", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Menu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\code\my_code\2019\packt\em.cloud.aspnetcore.razor.resturant\MurraysIrishBar\Pages\Index.cshtml"
  
    var menus = await Repository.GetAllAsync();

#line default
#line hidden
            DefineSection("Title", async() => {
                BeginContext(79, 112, true);
                WriteLiteral("\r\n    <div class=\"alert alert-success title\" role=\"alert\">\r\n        <h2>Menu Selection</h2>\r\n    </div>\r\n\r\n   \r\n");
                EndContext();
            }
            );
            BeginContext(194, 27, true);
            WriteLiteral("\r\n<div class=\"row Menus\">\r\n");
            EndContext();
#line 14 "D:\code\my_code\2019\packt\em.cloud.aspnetcore.razor.resturant\MurraysIrishBar\Pages\Index.cshtml"
     foreach (var menu in menus)
    {

#line default
#line hidden
            BeginContext(262, 79, true);
            WriteLiteral("        <div class=\"Menu col-md-4\">\r\n            <img class=\"img img-thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 341, "\"", 372, 1);
#line 17 "D:\code\my_code\2019\packt\em.cloud.aspnetcore.razor.resturant\MurraysIrishBar\Pages\Index.cshtml"
WriteAttributeValue("", 347, menu.GetInlineImageSrc(), 347, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(373, 21, true);
            WriteLiteral(" />\r\n            <h3>");
            EndContext();
            BeginContext(394, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc41c527bb124e9fb8e12a8a165ab697", async() => {
                BeginContext(439, 9, false);
#line 18 "D:\code\my_code\2019\packt\em.cloud.aspnetcore.razor.resturant\MurraysIrishBar\Pages\Index.cshtml"
                                                       Write(menu.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 18 "D:\code\my_code\2019\packt\em.cloud.aspnetcore.razor.resturant\MurraysIrishBar\Pages\Index.cshtml"
                                      WriteLiteral(menu.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(452, 22, true);
            WriteLiteral("</h3>\r\n            <p>");
            EndContext();
            BeginContext(475, 16, false);
#line 19 "D:\code\my_code\2019\packt\em.cloud.aspnetcore.razor.resturant\MurraysIrishBar\Pages\Index.cshtml"
          Write(menu.Description);

#line default
#line hidden
            EndContext();
            BeginContext(491, 22, true);
            WriteLiteral("</p>\r\n        </div>\r\n");
            EndContext();
#line 21 "D:\code\my_code\2019\packt\em.cloud.aspnetcore.razor.resturant\MurraysIrishBar\Pages\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(520, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Index> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Index> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Index>)PageContext?.ViewData;
        public Pages_Index Model => ViewData.Model;
    }
}
#pragma warning restore 1591
