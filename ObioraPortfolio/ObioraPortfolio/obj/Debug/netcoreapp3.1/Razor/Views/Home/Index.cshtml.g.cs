#pragma checksum "C:\Users\hp\Documents\Decagon_Tasks\week8-ObioraM\ObioraPortfolio\ObioraPortfolio\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7214ef08af4acae6e39a292d93ed0aec91cc3735"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\hp\Documents\Decagon_Tasks\week8-ObioraM\ObioraPortfolio\ObioraPortfolio\Views\_ViewImports.cshtml"
using ObioraPortfolio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Documents\Decagon_Tasks\week8-ObioraM\ObioraPortfolio\ObioraPortfolio\Views\_ViewImports.cshtml"
using ObioraPortfolio.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\Documents\Decagon_Tasks\week8-ObioraM\ObioraPortfolio\ObioraPortfolio\Views\_ViewImports.cshtml"
using ObioraPortfolio.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7214ef08af4acae6e39a292d93ed0aec91cc3735", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d27f23d2d26d1e6b2869a42bb2c12ef8c5bd4a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Profile>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/ObioraPhoto.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Obiora\'s Picture"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\hp\Documents\Decagon_Tasks\week8-ObioraM\ObioraPortfolio\ObioraPortfolio\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <h4>To</h4>\r\n    <h2>");
#nullable restore
#line 9 "C:\Users\hp\Documents\Decagon_Tasks\week8-ObioraM\ObioraPortfolio\ObioraPortfolio\Views\Home\Index.cshtml"
   Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "C:\Users\hp\Documents\Decagon_Tasks\week8-ObioraM\ObioraPortfolio\ObioraPortfolio\Views\Home\Index.cshtml"
                    Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s PortFolio</h2>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7214ef08af4acae6e39a292d93ed0aec91cc37355000", async() => {
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
            WriteLiteral("\r\n        \r\n    </div>\r\n    <p><strong>I am a ");
#nullable restore
#line 14 "C:\Users\hp\Documents\Decagon_Tasks\week8-ObioraM\ObioraPortfolio\ObioraPortfolio\Views\Home\Index.cshtml"
                 Write(Model.WorkExperiences[0].JobTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" with ");
#nullable restore
#line 14 "C:\Users\hp\Documents\Decagon_Tasks\week8-ObioraM\ObioraPortfolio\ObioraPortfolio\Views\Home\Index.cshtml"
                                                         Write(Model.WorkExperiences[0].CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n    <div class=\"d-flex\">\r\n        <div class=\"card mr-auto  col-5\" style=\"background-color:steelblue;\">\r\n            <div style=\"position:center;\">\r\n                <h3>Qualification</h3>\r\n                <p><strong>");
#nullable restore
#line 19 "C:\Users\hp\Documents\Decagon_Tasks\week8-ObioraM\ObioraPortfolio\ObioraPortfolio\Views\Home\Index.cshtml"
                      Write(Model.Qualification);

#line default
#line hidden
#nullable disable
            WriteLiteral(" in Electrical/Electronic Engineering</strong></p>\r\n                <p>Profession: <strong>");
#nullable restore
#line 20 "C:\Users\hp\Documents\Decagon_Tasks\week8-ObioraM\ObioraPortfolio\ObioraPortfolio\Views\Home\Index.cshtml"
                                  Write(Model.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"card mr-auto  col-5\" style=\"background-color:white\">\r\n            <div>\r\n                <h3>Work Experience</h3>\r\n                <h4>Title</h4>\r\n                <p>");
#nullable restore
#line 29 "C:\Users\hp\Documents\Decagon_Tasks\week8-ObioraM\ObioraPortfolio\ObioraPortfolio\Views\Home\Index.cshtml"
              Write(Model.WorkExperiences[0].JobTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                <h4>Current Company</h4>\r\n                <p> ");
#nullable restore
#line 32 "C:\Users\hp\Documents\Decagon_Tasks\week8-ObioraM\ObioraPortfolio\ObioraPortfolio\Views\Home\Index.cshtml"
               Write(Model.WorkExperiences[0].CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <h4>Job Description</h4>\r\n                <p>");
#nullable restore
#line 34 "C:\Users\hp\Documents\Decagon_Tasks\week8-ObioraM\ObioraPortfolio\ObioraPortfolio\Views\Home\Index.cshtml"
              Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" is diligently ");
#nullable restore
#line 34 "C:\Users\hp\Documents\Decagon_Tasks\week8-ObioraM\ObioraPortfolio\ObioraPortfolio\Views\Home\Index.cshtml"
                                             Write(Model.WorkExperiences[0].JobDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <h4>Start Date</h4>\r\n                <p>");
#nullable restore
#line 36 "C:\Users\hp\Documents\Decagon_Tasks\week8-ObioraM\ObioraPortfolio\ObioraPortfolio\Views\Home\Index.cshtml"
              Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" started working in ");
#nullable restore
#line 36 "C:\Users\hp\Documents\Decagon_Tasks\week8-ObioraM\ObioraPortfolio\ObioraPortfolio\Views\Home\Index.cshtml"
                                                  Write(Model.WorkExperiences[0].CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" at ");
#nullable restore
#line 36 "C:\Users\hp\Documents\Decagon_Tasks\week8-ObioraM\ObioraPortfolio\ObioraPortfolio\Views\Home\Index.cshtml"
                                                                                           Write(Model.WorkExperiences[0].YearStarted.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n    <div class=\"d-flex\" style=\"margin: 4px\">\r\n        <div class=\"card mr-auto col-5\" style=\"background-color:white;\">\r\n            <p>You can reach out to ");
#nullable restore
#line 45 "C:\Users\hp\Documents\Decagon_Tasks\week8-ObioraM\ObioraPortfolio\ObioraPortfolio\Views\Home\Index.cshtml"
                               Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" or see ");
#nullable restore
#line 45 "C:\Users\hp\Documents\Decagon_Tasks\week8-ObioraM\ObioraPortfolio\ObioraPortfolio\Views\Home\Index.cshtml"
                                                       Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s works via</p>\r\n            <h3>Social Media handles</h3>\r\n            <p>LinkedIn: <strong>");
#nullable restore
#line 47 "C:\Users\hp\Documents\Decagon_Tasks\week8-ObioraM\ObioraPortfolio\ObioraPortfolio\Views\Home\Index.cshtml"
                            Write(Model.LinkedInUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> </p>\r\n            <p>GitHub: <strong> ");
#nullable restore
#line 48 "C:\Users\hp\Documents\Decagon_Tasks\week8-ObioraM\ObioraPortfolio\ObioraPortfolio\Views\Home\Index.cshtml"
                           Write(Model.GitHubUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n            <p>Email: <strong>");
#nullable restore
#line 49 "C:\Users\hp\Documents\Decagon_Tasks\week8-ObioraM\ObioraPortfolio\ObioraPortfolio\Views\Home\Index.cshtml"
                         Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n        </div>\r\n        <div class=\"card mr-auto  col-5\" style=\"background-color:steelblue;\">\r\n            <div>\r\n                <h3>Address</h3>\r\n                <p>You can find ");
#nullable restore
#line 54 "C:\Users\hp\Documents\Decagon_Tasks\week8-ObioraM\ObioraPortfolio\ObioraPortfolio\Views\Home\Index.cshtml"
                           Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" at:</p>\r\n\r\n                <p>Street: <strong>");
#nullable restore
#line 56 "C:\Users\hp\Documents\Decagon_Tasks\week8-ObioraM\ObioraPortfolio\ObioraPortfolio\Views\Home\Index.cshtml"
                              Write(Model.Addresses[0].Street);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n                <p>in</p>\r\n                <p>State: <strong>");
#nullable restore
#line 58 "C:\Users\hp\Documents\Decagon_Tasks\week8-ObioraM\ObioraPortfolio\ObioraPortfolio\Views\Home\Index.cshtml"
                             Write(Model.Addresses[0].State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n                <p>City: <strong>");
#nullable restore
#line 59 "C:\Users\hp\Documents\Decagon_Tasks\week8-ObioraM\ObioraPortfolio\ObioraPortfolio\Views\Home\Index.cshtml"
                            Write(Model.Addresses[0].City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n                <p>Country: <strong>");
#nullable restore
#line 60 "C:\Users\hp\Documents\Decagon_Tasks\week8-ObioraM\ObioraPortfolio\ObioraPortfolio\Views\Home\Index.cshtml"
                               Write(Model.Addresses[0].Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n    \r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Profile> Html { get; private set; }
    }
}
#pragma warning restore 1591