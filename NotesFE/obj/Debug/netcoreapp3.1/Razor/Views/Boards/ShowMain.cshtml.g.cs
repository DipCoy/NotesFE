#pragma checksum "/home/artem/Рабочий стол/C#/NotesFE/NotesFE/Views/Boards/ShowMain.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e327f1de3413733a041c7bc1001ebe3594657f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Boards_ShowMain), @"mvc.1.0.view", @"/Views/Boards/ShowMain.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e327f1de3413733a041c7bc1001ebe3594657f2", @"/Views/Boards/ShowMain.cshtml")]
    public class Views_Boards_ShowMain : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/artem/Рабочий стол/C#/NotesFE/NotesFE/Views/Boards/ShowMain.cshtml"
  
    Layout = "_layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row mx-md-n3"">
    <div class=""col px-3"">
        <div class=""p-3 border bg-light"">
            Create Board
        </div>
    </div>
    
    <div class=""col px-md-3"">
        <form action=""/new"" method=""GET"">
            <input class=""btn btn-primary btn-lg active"" type=""submit"" value=""+"">
        </form>
    </div>
    
</div>
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
