#pragma checksum "/Users/queen/Projects/OBookStore/OBookStore/Views/Learning/Books.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fbbe24e81894fdef294e824096907ac9b839a8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Learning_Books), @"mvc.1.0.view", @"/Views/Learning/Books.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fbbe24e81894fdef294e824096907ac9b839a8f", @"/Views/Learning/Books.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80aed6cd022c14d58ca8eb4d40e200639fb2f33c", @"/Views/_ViewImports.cshtml")]
    public class Views_Learning_Books : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<script
  src=""https://code.jquery.com/jquery-3.4.1.min.js""
  integrity=""sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo=""
  crossorigin=""anonymous""></script>

<style>
    .div-page-content{
        left:0;
        width:80%;
    }

    .div-book-index{
        top:0;
        margin-left:80%;
        width:20%;
        background:yellow;
        height:100vh;
    }

    .div-book-index{
        display:none;
    }
</style>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fbbe24e81894fdef294e824096907ac9b839a8f3448", async() => {
                WriteLiteral(@"

    <div class=""div-page-content"">
        page content will go here.
    </div>

    <div class=""div-book-index"">
        <div class=""div-pageno"">
            <a href=""FirstIndex"">First Index</a>
        </div>
        <hr>
        <div class=""div-pageno"">
            Second Index
        </div>
        <hr>
        <div class=""div-pageno"">
            Third Index
        </div>
    </div>

");
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
            WriteLiteral("\n\n\n<script>\n    $(document).ready(function() {\n        fn_getPage();\n    })\n\n  function  fn_getPage(){\n        $.ajax({\n            url: \"/Learning/GetPage\",\n            data: {Book:");
#nullable restore
#line 57 "/Users/queen/Projects/OBookStore/OBookStore/Views/Learning/Books.cshtml"
                   Write(ViewBag.BookId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"},
            success: function (data) {
                $("".div-page-content"").html(data);
                return data;
            }
        });
  }



    function fn_getBook() {
        $.ajax({
            url: ""/Learning/getBook"",
            success: function (data) {
                return data;
            }
        });
    }

    function fn_getIndexes() {
        $.ajax({
            url: ""/Learning/Indexes"",
            success: function (data) {
                return data;
            }
        });
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
