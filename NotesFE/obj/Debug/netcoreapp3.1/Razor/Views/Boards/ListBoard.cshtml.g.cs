#pragma checksum "/home/dipcoy/RiderProjects/NotesFE/NotesFE/Views/Boards/ListBoard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cacdf88688e66764ca96991896d2f862f08ef63d"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cacdf88688e66764ca96991896d2f862f08ef63d", @"/Views/Boards/ListBoard.cshtml")]
    public class Views_Boards_ListBoard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Domain.Models.Board>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/dipcoy/RiderProjects/NotesFE/NotesFE/Views/Boards/ListBoard.cshtml"
  
    Layout = "_layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<style type=\"text/css\">\n       .block1 { \n        width: 600px; \n        height: 500px;\n        \n        border: solid 1px black; \n        float: left;\n       }\n</style>\n\n<div class=\"fixed-top\">\n    <h2>The Board</h2>\n    <div class=\"container\">\n");
#nullable restore
#line 20 "/home/dipcoy/RiderProjects/NotesFE/NotesFE/Views/Boards/ListBoard.cshtml"
          
            foreach (var sticker in Model.Content.Stickers)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"mx-md-n5\">\n                    <span class=\"border border-danger\">\n                        ");
#nullable restore
#line 25 "/home/dipcoy/RiderProjects/NotesFE/NotesFE/Views/Boards/ListBoard.cshtml"
                   Write(sticker.Content.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </span>\n                </div>\n                <br>\n");
#nullable restore
#line 29 "/home/dipcoy/RiderProjects/NotesFE/NotesFE/Views/Boards/ListBoard.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n    \n</div>");
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
