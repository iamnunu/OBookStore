#pragma checksum "/Users/queen/Projects/OBookStore/OBookStore/Views/AddTo/AddVideo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f96010d95ffcae3a81e8eb80a0e94d399b54902"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AddTo_AddVideo), @"mvc.1.0.razor-page", @"/Views/AddTo/AddVideo.cshtml")]
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
#line 1 "/Users/queen/Projects/OBookStore/OBookStore/Views/_ViewImports.cshtml"
using OBookStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/queen/Projects/OBookStore/OBookStore/Views/_ViewImports.cshtml"
using OBookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f96010d95ffcae3a81e8eb80a0e94d399b54902", @"/Views/AddTo/AddVideo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80aed6cd022c14d58ca8eb4d40e200639fb2f33c", @"/Views/_ViewImports.cshtml")]
    public class Views_AddTo_AddVideo : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-addvideo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n<script\n  src=\"https://code.jquery.com/jquery-3.4.1.min.js\"\n  integrity=\"sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo=\"\n  crossorigin=\"anonymous\"></script>\n\n\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f96010d95ffcae3a81e8eb80a0e94d399b549023674", async() => {
                WriteLiteral(@"
    <table>

        <tbody>
            <tr>
                <td>Name</td>
                <td><input type=""text"" name=""Name""/></td>
            </tr>
             <tr>
                <td>Object</td>
                <td><input type=""number"" name=""object""/></td>
            </tr>
            <tr>
                <td>Caption</td>
                <td><input type=""text"" name=""Caption""/></td>
            </tr>
            <tr>
                <td>Thumbnail</td>
                <td>
                    <input type=""file"" name=""Thumbnail""/>
                </td>
            </tr>
             <tr>
                <td>Path</td>
                <td>
                    <input type=""text"" name=""Path""/>
                </td>
            </tr>
              <tr>
                <td>Tags</td>
                <td>
                    <input type=""text"" name=""Tags""/>
                </td>
            </tr>
            <tr>
                <td>Categories</td>
                <td>
                    <input type=""text"" nam");
                WriteLiteral("e=\"Categories\"/>\n                </td>\n            </tr>\n        </tbody>\n    </table>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
   
    <button type=""button"" id=""save"" >Save</button>

</div>


<script>
    $(document).on('click', '#save', function (e) {
        var data = $(""#form-addvideo"").serialize();
        $.ajax({
            data: data,
            type: ""post"",
            url: ""/AddTo/AddVideoRow"",
            success: function (data) {
                alert(""Data Save: "" + data);
            }
        });
    });
    
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Views_AddTo_AddVideo> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_AddTo_AddVideo> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_AddTo_AddVideo>)PageContext?.ViewData;
        public Views_AddTo_AddVideo Model => ViewData.Model;
    }
}
#pragma warning restore 1591
