#pragma checksum "C:\Users\zaino\Documents\Visual Studio 2022\Projects\Car Loan App\CarLoan.App\CarLoan.App\Views\Home\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c92b5434270bc041e2de9a2eb424f0939fbf20c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Delete), @"mvc.1.0.view", @"/Views/Home/Delete.cshtml")]
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
#line 2 "C:\Users\zaino\Documents\Visual Studio 2022\Projects\Car Loan App\CarLoan.App\CarLoan.App\Views\_ViewImports.cshtml"
using CarLoan.App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c92b5434270bc041e2de9a2eb424f0939fbf20c", @"/Views/Home/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"226c8bd41bc5afee988996600995a45f3145493d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarLoan.App.Models.QuoteViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("js-validate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\zaino\Documents\Visual Studio 2022\Projects\Car Loan App\CarLoan.App\CarLoan.App\Views\Home\Delete.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<!-- ========== MAIN ========== -->
<main id=""content"" role=""main"" class=""main"">
    <div class=""content container-fluid"">
        <div class=""page-header"">
            <div class=""row align-items-end"">
                <div class=""col-sm mb-2 mb-sm-0"">
                    <nav aria-label=""breadcrumb"">
                        <ol class=""breadcrumb breadcrumb-no-gutter"">
                            <li class=""breadcrumb-item""><a class=""breadcrumb-link"" href=""javascript:;"">Quotation</a></li>
                            <li class=""breadcrumb-item""><a class=""breadcrumb-link"" href=""javascript:;"">Overview</a></li>
                        </ol>
                    </nav>

                    <h1 class=""page-header-title"">Delete Quotation?</h1>
                </div>
            </div>
            <!-- End Row -->
        </div>
        <!-- End Breadcrumb Section -->
        <!-- Content Section -->
        <div class=""w-100 pt-10 pt-lg-7 pb-7"" style=""max-width: 25rem;"">
            <!-- Fo");
            WriteLiteral("rm -->\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c92b5434270bc041e2de9a2eb424f0939fbf20c6378", async() => {
                WriteLiteral("\r\n\r\n                <!-- Form Group -->\r\n                <div class=\"js-form-message form-group\">\r\n                    <label class=\"input-label\" for=\"signupSrEmail\">Name</label>\r\n                    ");
#nullable restore
#line 36 "C:\Users\zaino\Documents\Visual Studio 2022\Projects\Car Loan App\CarLoan.App\CarLoan.App\Views\Home\Delete.cshtml"
               Write(Html.TextBoxFor(model => model.Quote.name,new{ @class="form-control form-control-lg", @name="name" ,@id="signupSrEmail" ,@placeholder="Clareon", @readonly="readonly" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"js-form-message form-group\">\r\n                    <label class=\"input-label\" for=\"signupSrEmail\">Surname</label>\r\n                    ");
#nullable restore
#line 40 "C:\Users\zaino\Documents\Visual Studio 2022\Projects\Car Loan App\CarLoan.App\CarLoan.App\Views\Home\Delete.cshtml"
               Write(Html.TextBoxFor(model => model.Quote.surname,new{ @class="form-control form-control-lg", @name="surname" ,@id="signupSrEmail" ,@placeholder="Williams", @readonly="readonly" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"js-form-message form-group\">\r\n                    <label class=\"input-label\" for=\"signupSrEmail\">Email</label>\r\n                    ");
#nullable restore
#line 44 "C:\Users\zaino\Documents\Visual Studio 2022\Projects\Car Loan App\CarLoan.App\CarLoan.App\Views\Home\Delete.cshtml"
               Write(Html.TextBoxFor(model => model.Quote.email,new{ @class="form-control form-control-lg", @name="email" ,@id="signupSrEmail" ,@placeholder="sands@gmail.com", @readonly="readonly" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                </div>\r\n                <div class=\"js-form-message form-group\">\r\n                    <label class=\"input-label\" for=\"signupSrEmail\">Phone</label>\r\n\r\n                    ");
#nullable restore
#line 50 "C:\Users\zaino\Documents\Visual Studio 2022\Projects\Car Loan App\CarLoan.App\CarLoan.App\Views\Home\Delete.cshtml"
               Write(Html.TextBoxFor(model => model.Quote.phone,new{ @class="form-control form-control-lg", @name="phone" ,@id="signupSrEmail" ,@placeholder="0315076898", @readonly="readonly" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"js-form-message form-group\">\r\n                    <label class=\"input-label\" for=\"signupSrEmail\">Address</label>\r\n                    ");
#nullable restore
#line 54 "C:\Users\zaino\Documents\Visual Studio 2022\Projects\Car Loan App\CarLoan.App\CarLoan.App\Views\Home\Delete.cshtml"
               Write(Html.TextBoxFor(model => model.Quote.address,new{ @class="form-control form-control-lg", @name="address" ,@id="signupSrEmail" ,@placeholder="20 Long beach, California", @readonly="readonly" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"js-form-message form-group\">\r\n                    <label class=\"input-label\" for=\"signupSrEmail\">Amount</label>\r\n                    ");
#nullable restore
#line 58 "C:\Users\zaino\Documents\Visual Studio 2022\Projects\Car Loan App\CarLoan.App\CarLoan.App\Views\Home\Delete.cshtml"
               Write(Html.TextBoxFor(model => model.Quote.amount,new{ @id="txtChar", @class="form-control form-control-lg", @onkeypress="return isNumberKey(event,this.id)",@name="txtChar", @readonly="readonly"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 59 "C:\Users\zaino\Documents\Visual Studio 2022\Projects\Car Loan App\CarLoan.App\CarLoan.App\Views\Home\Delete.cshtml"
               Write(Html.HiddenFor(model => model.Quote.quoteID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 60 "C:\Users\zaino\Documents\Visual Studio 2022\Projects\Car Loan App\CarLoan.App\CarLoan.App\Views\Home\Delete.cshtml"
               Write(Html.HiddenFor(model => model.Quote.createdOn));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <button type=\"submit\" class=\"btn btn-lg btn-block btn-primary\">Submit</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <!-- End Form -->\r\n            <div class=\"js-form-message mt-5\" style=\"color:#ed4c78;font-size:80%;\">\r\n                ");
#nullable restore
#line 66 "C:\Users\zaino\Documents\Visual Studio 2022\Projects\Car Loan App\CarLoan.App\CarLoan.App\Views\Home\Delete.cshtml"
           Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <!-- End Content Section -->\r\n    </div>\r\n</main>\r\n<!-- ========== END MAIN ========== -->\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarLoan.App.Models.QuoteViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
