#pragma checksum "/home/dipcoy/RiderProjects/NotesFE/NotesFE/Views/Boards/ListBoard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e508261e529291071f1cca226cfb472f3aa44435"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e508261e529291071f1cca226cfb472f3aa44435", @"/Views/Boards/ListBoard.cshtml")]
    public class Views_Boards_ListBoard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Domain.Models.Board>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/dipcoy/RiderProjects/NotesFE/NotesFE/Views/Boards/ListBoard.cshtml"
  
    Layout = "../_layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js""></script>
<script src=""https://code.jquery.com/ui/1.11.3/jquery-ui.js""></script>
<link rel=""stylesheet"" type=""text/css"" href=""http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.18/themes/overcast/jquery-ui.css"" />

");
            DefineSection("Auth", async() => {
                WriteLiteral("\n");
#nullable restore
#line 12 "/home/dipcoy/RiderProjects/NotesFE/NotesFE/Views/Boards/ListBoard.cshtml"
      
        if (User.Identity.IsAuthenticated)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div>\n                <form action=\"/logout\">\n                    ");
#nullable restore
#line 17 "/home/dipcoy/RiderProjects/NotesFE/NotesFE/Views/Boards/ListBoard.cshtml"
               Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    <button type=\"submit\" class=\"btn btn-link\">Logout</button>\n                </form>\n            </div>\n");
#nullable restore
#line 21 "/home/dipcoy/RiderProjects/NotesFE/NotesFE/Views/Boards/ListBoard.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <form action=""/login"">
                <button class=""w-80 btn btn-lg btn-light"" type=""submit"">Sign in</button>
            </form>
            <form action=""/register"">
                <button class=""w-80 btn btn-lg btn-primary"" type=""submit"">Sign up</button>
            </form>
");
#nullable restore
#line 30 "/home/dipcoy/RiderProjects/NotesFE/NotesFE/Views/Boards/ListBoard.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            }
            );
            WriteLiteral("\n<form action=\"/\">\n    <button type=\"submit\" class=\"btn btn-success\">Home</button>\n</form>\n\n<div>\n    <h2>The Board</h2>\n    <div class=\"container\">\n");
#nullable restore
#line 41 "/home/dipcoy/RiderProjects/NotesFE/NotesFE/Views/Boards/ListBoard.cshtml"
          
            foreach (var sticker in Model.Content.Stickers)
            {
                if (sticker.Content.Text != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"align-baseline\">\n                        <div class=\"col-4 themed-grid-col\">\n                            <div class=\"p-3 border bg-light\">\n                                ");
#nullable restore
#line 49 "/home/dipcoy/RiderProjects/NotesFE/NotesFE/Views/Boards/ListBoard.cshtml"
                           Write(sticker.Content.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </div>\n                        </div>\n                    </div>\n                    <br>\n");
#nullable restore
#line 54 "/home/dipcoy/RiderProjects/NotesFE/NotesFE/Views/Boards/ListBoard.cshtml"
                }
                else if (sticker.Content.TimeTable != null)
                {
                    var table = sticker.Content.TimeTable;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"align-baseline\">\n                    <div class=\"col-4 themed-grid-col\">\n                        <div class=\"p-3 border bg-light\">\n                            <table border=\"2\">\n");
#nullable restore
#line 62 "/home/dipcoy/RiderProjects/NotesFE/NotesFE/Views/Boards/ListBoard.cshtml"
                                  
                                    foreach (var row in table)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\n");
#nullable restore
#line 66 "/home/dipcoy/RiderProjects/NotesFE/NotesFE/Views/Boards/ListBoard.cshtml"
                                              
                                                foreach (var cell in row)
                                                {
                                                    if (cell == null)
                                                    {
                                                        continue;
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td>\n                                                        ");
#nullable restore
#line 74 "/home/dipcoy/RiderProjects/NotesFE/NotesFE/Views/Boards/ListBoard.cshtml"
                                                   Write(cell);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                                    </td>\n");
#nullable restore
#line 76 "/home/dipcoy/RiderProjects/NotesFE/NotesFE/Views/Boards/ListBoard.cshtml"
                                                }
                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </tr>\n");
#nullable restore
#line 79 "/home/dipcoy/RiderProjects/NotesFE/NotesFE/Views/Boards/ListBoard.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </table>\n                        </div>\n                    </div>\n                    </div>\n                    <br>\n");
#nullable restore
#line 86 "/home/dipcoy/RiderProjects/NotesFE/NotesFE/Views/Boards/ListBoard.cshtml"
                }
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
