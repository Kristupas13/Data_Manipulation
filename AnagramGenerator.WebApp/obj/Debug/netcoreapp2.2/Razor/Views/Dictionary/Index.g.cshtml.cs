#pragma checksum "C:\Users\kristupas\Desktop\UpdatedDataManipulation\Data_Manipulation-master\AnagramGenerator.WebApp\Views\Dictionary\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90fdbc504fd521b9117f4611e181db83f7be6970"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dictionary_Index), @"mvc.1.0.view", @"/Views/Dictionary/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dictionary/Index.cshtml", typeof(AspNetCore.Views_Dictionary_Index))]
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
#line 1 "C:\Users\kristupas\Desktop\UpdatedDataManipulation\Data_Manipulation-master\AnagramGenerator.WebApp\Views\_ViewImports.cshtml"
using AnagramGenerator.WebApp;

#line default
#line hidden
#line 2 "C:\Users\kristupas\Desktop\UpdatedDataManipulation\Data_Manipulation-master\AnagramGenerator.WebApp\Views\_ViewImports.cshtml"
using AnagramGenerator.WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90fdbc504fd521b9117f4611e181db83f7be6970", @"/Views/Dictionary/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8403a213a789ede4ccf9b4ac936f518f5c4b3a09", @"/Views/_ViewImports.cshtml")]
    public class Views_Dictionary_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PageSearchWord>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\kristupas\Desktop\UpdatedDataManipulation\Data_Manipulation-master\AnagramGenerator.WebApp\Views\Dictionary\Index.cshtml"
  int previousPage = Model.Page - 1;

#line default
#line hidden
#line 4 "C:\Users\kristupas\Desktop\UpdatedDataManipulation\Data_Manipulation-master\AnagramGenerator.WebApp\Views\Dictionary\Index.cshtml"
  int nextPage = Model.Page + 1;

#line default
#line hidden
#line 5 "C:\Users\kristupas\Desktop\UpdatedDataManipulation\Data_Manipulation-master\AnagramGenerator.WebApp\Views\Dictionary\Index.cshtml"
  int wordIndex = (Model.Page - 1) * 100 + 1;

#line default
#line hidden
            BeginContext(147, 10, true);
            WriteLiteral("\r\n\r\n\r\n    ");
            EndContext();
            BeginContext(157, 196, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90fdbc504fd521b9117f4611e181db83f7be69704717", async() => {
                BeginContext(163, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(173, 167, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90fdbc504fd521b9117f4611e181db83f7be69705108", async() => {
                    BeginContext(240, 93, true);
                    WriteLiteral("\r\n            <input type=\"text\" name=\"searchWord\" placeholder=\"Search word..\" />\r\n\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 10 "C:\Users\kristupas\Desktop\UpdatedDataManipulation\Data_Manipulation-master\AnagramGenerator.WebApp\Views\Dictionary\Index.cshtml"
AddHtmlAttributeValue("", 186, Url.Action("SearchPage", "Dictionary"), 186, 39, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(340, 6, true);
                WriteLiteral("\r\n    ");
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
            BeginContext(353, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 16 "C:\Users\kristupas\Desktop\UpdatedDataManipulation\Data_Manipulation-master\AnagramGenerator.WebApp\Views\Dictionary\Index.cshtml"
   if (Model.Page != 1)
    {


#line default
#line hidden
            BeginContext(391, 37, true);
            WriteLiteral("        <font size=\"4\">\r\n            ");
            EndContext();
            BeginContext(429, 73, false);
#line 20 "C:\Users\kristupas\Desktop\UpdatedDataManipulation\Data_Manipulation-master\AnagramGenerator.WebApp\Views\Dictionary\Index.cshtml"
       Write(Html.ActionLink("<<", "Index", "Dictionary", new { page = previousPage }));

#line default
#line hidden
            EndContext();
            BeginContext(502, 19, true);
            WriteLiteral("\r\n        </font>\r\n");
            EndContext();
#line 22 "C:\Users\kristupas\Desktop\UpdatedDataManipulation\Data_Manipulation-master\AnagramGenerator.WebApp\Views\Dictionary\Index.cshtml"

    }

#line default
#line hidden
            BeginContext(533, 15, true);
            WriteLiteral("<font size=\"4\">");
            EndContext();
            BeginContext(549, 75, false);
#line 25 "C:\Users\kristupas\Desktop\UpdatedDataManipulation\Data_Manipulation-master\AnagramGenerator.WebApp\Views\Dictionary\Index.cshtml"
          Write(Html.ActionLink(">>", "Index", "Dictionary", new { page = nextPage }, null));

#line default
#line hidden
            EndContext();
            BeginContext(624, 38, true);
            WriteLiteral("</font>\r\n\r\n\r\n<br />\r\n<font size=\"4\">\r\n");
            EndContext();
#line 30 "C:\Users\kristupas\Desktop\UpdatedDataManipulation\Data_Manipulation-master\AnagramGenerator.WebApp\Views\Dictionary\Index.cshtml"
     foreach (var anagram in ViewBag.Words)
    {

#line default
#line hidden
            BeginContext(714, 14, true);
            WriteLiteral("    <il>\r\n\r\n\r\n");
            EndContext();
#line 35 "C:\Users\kristupas\Desktop\UpdatedDataManipulation\Data_Manipulation-master\AnagramGenerator.WebApp\Views\Dictionary\Index.cshtml"
           if (anagram == Model.SearchedWord)
            {

#line default
#line hidden
            BeginContext(790, 56, true);
            WriteLiteral("                <font color=\"red\">\r\n                    ");
            EndContext();
            BeginContext(847, 9, false);
#line 38 "C:\Users\kristupas\Desktop\UpdatedDataManipulation\Data_Manipulation-master\AnagramGenerator.WebApp\Views\Dictionary\Index.cshtml"
               Write(wordIndex);

#line default
#line hidden
            EndContext();
            BeginContext(856, 28, true);
            WriteLiteral(".\r\n                </font>\r\n");
            EndContext();
#line 40 "C:\Users\kristupas\Desktop\UpdatedDataManipulation\Data_Manipulation-master\AnagramGenerator.WebApp\Views\Dictionary\Index.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(932, 57, true);
            WriteLiteral("                <font color=\"grey\">\r\n                    ");
            EndContext();
            BeginContext(990, 9, false);
#line 44 "C:\Users\kristupas\Desktop\UpdatedDataManipulation\Data_Manipulation-master\AnagramGenerator.WebApp\Views\Dictionary\Index.cshtml"
               Write(wordIndex);

#line default
#line hidden
            EndContext();
            BeginContext(999, 28, true);
            WriteLiteral(".\r\n                </font>\r\n");
            EndContext();
#line 46 "C:\Users\kristupas\Desktop\UpdatedDataManipulation\Data_Manipulation-master\AnagramGenerator.WebApp\Views\Dictionary\Index.cshtml"
            }
        

#line default
#line hidden
            BeginContext(1053, 17, true);
            WriteLiteral("\r\n\r\n\r\n    </il>\r\n");
            EndContext();
            BeginContext(1079, 118, false);
#line 52 "C:\Users\kristupas\Desktop\UpdatedDataManipulation\Data_Manipulation-master\AnagramGenerator.WebApp\Views\Dictionary\Index.cshtml"
   Write(Html.ActionLink((string)anagram, "Index", "Home", new { phrase = (string)anagram }, new { @style = "color:#FFFFFF;" }));

#line default
#line hidden
            EndContext();
            BeginContext(1199, 16, true);
            WriteLiteral("        <br />\r\n");
            EndContext();
#line 54 "C:\Users\kristupas\Desktop\UpdatedDataManipulation\Data_Manipulation-master\AnagramGenerator.WebApp\Views\Dictionary\Index.cshtml"
        wordIndex++;

    }

#line default
#line hidden
            BeginContext(1246, 11, true);
            WriteLiteral("</font>\r\n\r\n");
            EndContext();
#line 59 "C:\Users\kristupas\Desktop\UpdatedDataManipulation\Data_Manipulation-master\AnagramGenerator.WebApp\Views\Dictionary\Index.cshtml"
   if (Model.Page != 1)
    {


#line default
#line hidden
            BeginContext(1291, 37, true);
            WriteLiteral("        <font size=\"4\">\r\n            ");
            EndContext();
            BeginContext(1329, 79, false);
#line 63 "C:\Users\kristupas\Desktop\UpdatedDataManipulation\Data_Manipulation-master\AnagramGenerator.WebApp\Views\Dictionary\Index.cshtml"
       Write(Html.ActionLink("<<", "Index", "Dictionary", new { page = previousPage }, null));

#line default
#line hidden
            EndContext();
            BeginContext(1408, 19, true);
            WriteLiteral("\r\n        </font>\r\n");
            EndContext();
#line 65 "C:\Users\kristupas\Desktop\UpdatedDataManipulation\Data_Manipulation-master\AnagramGenerator.WebApp\Views\Dictionary\Index.cshtml"

    }

#line default
#line hidden
            BeginContext(1439, 15, true);
            WriteLiteral("<font size=\"4\">");
            EndContext();
            BeginContext(1455, 75, false);
#line 68 "C:\Users\kristupas\Desktop\UpdatedDataManipulation\Data_Manipulation-master\AnagramGenerator.WebApp\Views\Dictionary\Index.cshtml"
          Write(Html.ActionLink(">>", "Index", "Dictionary", new { page = nextPage }, null));

#line default
#line hidden
            EndContext();
            BeginContext(1530, 7, true);
            WriteLiteral("</font>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PageSearchWord> Html { get; private set; }
    }
}
#pragma warning restore 1591
