#pragma checksum "D:\Документы\!GitHub\NotesFE\NotesFE\Views\Boards\ListBoard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "035e54e21c4d192f555298065b581b3a9a04cf03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Boards_ListBoard), @"mvc.1.0.view", @"/Views/Boards/ListBoard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"035e54e21c4d192f555298065b581b3a9a04cf03", @"/Views/Boards/ListBoard.cshtml")]
    public class Views_Boards_ListBoard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Domain.Models.Board>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Документы\!GitHub\NotesFE\NotesFE\Views\Boards\ListBoard.cshtml"
  
    Layout = "_layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js""></script>
<script src=""https://code.jquery.com/ui/1.11.3/jquery-ui.js""></script>
<link rel=""stylesheet"" type=""text/css"" href=""http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.18/themes/overcast/jquery-ui.css"" />

<div class=""fixed-top"">
    <h2>Доска ID: ");
#nullable restore
#line 12 "D:\Документы\!GitHub\NotesFE\NotesFE\Views\Boards\ListBoard.cshtml"
             Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <div class=\"container\">\r\n");
#nullable restore
#line 14 "D:\Документы\!GitHub\NotesFE\NotesFE\Views\Boards\ListBoard.cshtml"
      
        foreach (var sticker in Model.Content.Stickers)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"align-baseline\">\r\n                <div class=\"col-4 themed-grid-col\">\r\n                    <div class=\"p-3 border bg-light\">\r\n                        ");
#nullable restore
#line 20 "D:\Документы\!GitHub\NotesFE\NotesFE\Views\Boards\ListBoard.cshtml"
                   Write(sticker.Content.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n                </div>\r\n\r\n            </div>\r\n");
            WriteLiteral("            <br>\r\n");
#nullable restore
#line 28 "D:\Документы\!GitHub\NotesFE\NotesFE\Views\Boards\ListBoard.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Domain.Models.Board> Html { get; private set; }
    }
}
#pragma warning restore 1591
