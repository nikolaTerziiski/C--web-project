#pragma checksum "C:\Users\Lenovo\Desktop\Gameplace\Gameplace.Web\Areas\Admin\Views\Cars\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a38b46cf45e5d2b526595a50eda28efb6d1f0494"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Cars_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Cars/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Cars/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Cars_Details))]
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
#line 1 "C:\Users\Lenovo\Desktop\Gameplace\Gameplace.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Gameplace.Web;

#line default
#line hidden
#line 2 "C:\Users\Lenovo\Desktop\Gameplace\Gameplace.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Gameplace.Web.Models;

#line default
#line hidden
#line 3 "C:\Users\Lenovo\Desktop\Gameplace\Gameplace.Web\Areas\Admin\Views\_ViewImports.cshtml"
using CarParadise.Models.UserAndTopics;

#line default
#line hidden
#line 4 "C:\Users\Lenovo\Desktop\Gameplace\Gameplace.Web\Areas\Admin\Views\_ViewImports.cshtml"
using CarParadise.Web.Areas.Admin.Models.BindingModels;

#line default
#line hidden
#line 5 "C:\Users\Lenovo\Desktop\Gameplace\Gameplace.Web\Areas\Admin\Views\_ViewImports.cshtml"
using CarParadise.Web.Helpers;

#line default
#line hidden
#line 7 "C:\Users\Lenovo\Desktop\Gameplace\Gameplace.Web\Areas\Admin\Views\_ViewImports.cshtml"
using CarParadise.Web.Areas.Admin.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a38b46cf45e5d2b526595a50eda28efb6d1f0494", @"/Areas/Admin/Views/Cars/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f87a32b70eaff0928f49bff6252319e641a0468c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Cars_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarConsiceViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cars", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Buy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Rent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(28, 61, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-sm-6\">\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 89, "\"", 110, 1);
#line 5 "C:\Users\Lenovo\Desktop\Gameplace\Gameplace.Web\Areas\Admin\Views\Cars\Details.cshtml"
WriteAttributeValue("", 95, Model.ImageUrl, 95, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(111, 12, true);
            WriteLiteral(" width=\"600\"");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 123, "\"", 156, 3);
            WriteAttributeValue("", 129, "Picture", 129, 7, true);
            WriteAttributeValue(" ", 136, "for", 137, 4, true);
#line 5 "C:\Users\Lenovo\Desktop\Gameplace\Gameplace.Web\Areas\Admin\Views\Cars\Details.cshtml"
WriteAttributeValue(" ", 140, Model.CarModel, 141, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(157, 85, true);
            WriteLiteral(" />\r\n    </div>\r\n    <br />\r\n\r\n    <div class=\"col-sm-6 col-sm-push-2\">\r\n        <h1>");
            EndContext();
            BeginContext(243, 11, false);
#line 10 "C:\Users\Lenovo\Desktop\Gameplace\Gameplace.Web\Areas\Admin\Views\Cars\Details.cshtml"
       Write(Model.Brand);

#line default
#line hidden
            EndContext();
            BeginContext(254, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(258, 14, false);
#line 10 "C:\Users\Lenovo\Desktop\Gameplace\Gameplace.Web\Areas\Admin\Views\Cars\Details.cshtml"
                      Write(Model.CarModel);

#line default
#line hidden
            EndContext();
            BeginContext(272, 19, true);
            WriteLiteral("</h1>\r\n        <h2>");
            EndContext();
            BeginContext(292, 15, false);
#line 11 "C:\Users\Lenovo\Desktop\Gameplace\Gameplace.Web\Areas\Admin\Views\Cars\Details.cshtml"
       Write(Model.TypeOfCar);

#line default
#line hidden
            EndContext();
            BeginContext(307, 37, true);
            WriteLiteral("</h2>\r\n        <h3>Produced in year: ");
            EndContext();
            BeginContext(345, 22, false);
#line 12 "C:\Users\Lenovo\Desktop\Gameplace\Gameplace.Web\Areas\Admin\Views\Cars\Details.cshtml"
                         Write(Model.ProduceDate.Year);

#line default
#line hidden
            EndContext();
            BeginContext(367, 86, true);
            WriteLiteral("</h3>\r\n        <br />\r\n        <div class=\"row col-sm-12 col-sm-push-1\">\r\n            ");
            EndContext();
            BeginContext(453, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8b435777beb40f1940482dbe5ff174d", async() => {
                BeginContext(519, 3, true);
                WriteLiteral("Buy");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(526, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(540, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3adb52cf1fd4111af475fef020f8d36", async() => {
                BeginContext(607, 4, true);
                WriteLiteral("Rent");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(615, 36, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarConsiceViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
