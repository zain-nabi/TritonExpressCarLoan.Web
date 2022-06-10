#pragma checksum "C:\Users\zaino\Documents\Visual Studio 2022\Projects\Car Loan App\CarLoan.App\CarLoan.App\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "faf33a6c98256ce5671dc5145d693e4672437ffe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
#line 1 "C:\Users\zaino\Documents\Visual Studio 2022\Projects\Car Loan App\CarLoan.App\CarLoan.App\Views\_ViewImports.cshtml"
using CarLoan.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\zaino\Documents\Visual Studio 2022\Projects\Car Loan App\CarLoan.App\CarLoan.App\Views\Shared\Error.cshtml"
using CarLoan.App.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zaino\Documents\Visual Studio 2022\Projects\Car Loan App\CarLoan.App\CarLoan.App\Views\Shared\Error.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faf33a6c98256ce5671dc5145d693e4672437ffe", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"226c8bd41bc5afee988996600995a45f3145493d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-60 w-sm-100 mx-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/front-dashboard-v1.1/dist/assets/svg/illustrations/think.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image Description"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width: 15rem;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\zaino\Documents\Visual Studio 2022\Projects\Car Loan App\CarLoan.App\CarLoan.App\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";
    var header = ViewData["Header"] ?? "404";
    var message = ViewData["Message"] ?? "Sorry, the page you're looking for cannot be found.";
    var redirectUrl = ViewData["RedirectUrl"] ?? @Url.Action("Index", "Home");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main id=""content"" role=""main"" class=""main"">
    <!-- Content -->
    <div class=""content container-fluid"">
        <div class=""row align-items-sm-center py-sm-10"">
            <div class=""col-sm-6"">
                <div class=""text-center text-sm-right mr-sm-4 mb-5 mb-sm-0"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "faf33a6c98256ce5671dc5145d693e4672437ffe5781", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n");
#nullable restore
#line 23 "C:\Users\zaino\Documents\Visual Studio 2022\Projects\Car Loan App\CarLoan.App\CarLoan.App\Views\Shared\Error.cshtml"
             if (ViewData["RedirectUrl"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-sm-6 col-md-4 text-center text-sm-left\">\r\n                    <h1 class=\"display-1 mb-0\">");
#nullable restore
#line 26 "C:\Users\zaino\Documents\Visual Studio 2022\Projects\Car Loan App\CarLoan.App\CarLoan.App\Views\Shared\Error.cshtml"
                                          Write(Html.Raw(header));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <p class=\"lead\">");
#nullable restore
#line 27 "C:\Users\zaino\Documents\Visual Studio 2022\Projects\Car Loan App\CarLoan.App\CarLoan.App\Views\Shared\Error.cshtml"
                               Write(Html.Raw(message));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1222, "\"", 1251, 1);
#nullable restore
#line 28 "C:\Users\zaino\Documents\Visual Studio 2022\Projects\Car Loan App\CarLoan.App\CarLoan.App\Views\Shared\Error.cshtml"
WriteAttributeValue("", 1229, Html.Raw(redirectUrl), 1229, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Continue</a>\r\n                </div>\r\n");
#nullable restore
#line 30 "C:\Users\zaino\Documents\Visual Studio 2022\Projects\Car Loan App\CarLoan.App\CarLoan.App\Views\Shared\Error.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-sm-6 col-md-4 text-center text-sm-left\">\r\n                    <h1 class=\"display-1 mb-0\">");
#nullable restore
#line 34 "C:\Users\zaino\Documents\Visual Studio 2022\Projects\Car Loan App\CarLoan.App\CarLoan.App\Views\Shared\Error.cshtml"
                                          Write(Html.Raw(header));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <p class=\"lead\">");
#nullable restore
#line 35 "C:\Users\zaino\Documents\Visual Studio 2022\Projects\Car Loan App\CarLoan.App\CarLoan.App\Views\Shared\Error.cshtml"
                               Write(Html.Raw(message));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1590, "\"", 1625, 1);
#nullable restore
#line 36 "C:\Users\zaino\Documents\Visual Studio 2022\Projects\Car Loan App\CarLoan.App\CarLoan.App\Views\Shared\Error.cshtml"
WriteAttributeValue("", 1597, Url.Action("Index", "Home"), 1597, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Go back to the App</a>\r\n                </div>\r\n");
#nullable restore
#line 38 "C:\Users\zaino\Documents\Visual Studio 2022\Projects\Car Loan App\CarLoan.App\CarLoan.App\Views\Shared\Error.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <!-- End Row -->\r\n    </div>\r\n    <!-- End Content -->\r\n</main>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration Configuration { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
