#pragma checksum "/home/artem/Рабочий стол/C#/NotesFE/NotesFE/Views/Boards/CreateBoard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b861400cd5a168b22daac74afe86a134a570bd70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Boards_CreateBoard), @"mvc.1.0.view", @"/Views/Boards/CreateBoard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b861400cd5a168b22daac74afe86a134a570bd70", @"/Views/Boards/CreateBoard.cshtml")]
    public class Views_Boards_CreateBoard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex h-100 text-center text-black bg-blue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/artem/Рабочий стол/C#/NotesFE/NotesFE/Views/Boards/CreateBoard.cshtml"
  
    Layout = "../_layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!doctype html>\n<html lang=\"en\" class=\"h-100\">\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b861400cd5a168b22daac74afe86a134a570bd703282", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 217, "\"", 227, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <meta name=""author"" content=""Mark Otto, Jacob Thornton, and Bootstrap contributors"">
    <meta name=""generator"" content=""Hugo 0.79.0"">
    <title>Cover Template · Bootstrap v5.0</title>

    <link rel=""canonical"" href=""https://getbootstrap.com/docs/5.0/examples/cover/"">
    <style>
      .bd-placeholder-img {
        font-size: 1.125rem;
        text-anchor: middle;
        -webkit-user-select: none;
        -moz-user-select: none;
        user-select: none;
      }

      ");
                WriteLiteral(@"@media (min-width: 768px) {
        .bd-placeholder-img-lg {
          font-size: 3.5rem;
        }
      }
    </style>
    
    
    <!-- Custom styles for this template -->
    <link href=""cover.css"" rel=""stylesheet"">
  <script src=""//widget-feature.local"" async></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b861400cd5a168b22daac74afe86a134a570bd705337", async() => {
                WriteLiteral("\n");
                DefineSection("Auth", async() => {
                    WriteLiteral("\n");
#nullable restore
#line 39 "/home/artem/Рабочий стол/C#/NotesFE/NotesFE/Views/Boards/CreateBoard.cshtml"
              
                if (User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                        <div class=""cover-container d-flex w-100 h-100 p-3 mx-auto flex-column"">
                            <header class=""mb-auto"">
                                <div>
                                    <h3 class=""float-md-start mb-0"">Sinrise Soft</h3>
                                    <nav class=""nav nav-masthead justify-content-center float-md-end"">
                                        <a class=""nav-link active"" aria-current=""page"" href=""#"">Home</a>
                                        <form action=""/logout"">
                                            <a class=""nav-link active"" aria-current=""page"">");
#nullable restore
#line 49 "/home/artem/Рабочий стол/C#/NotesFE/NotesFE/Views/Boards/CreateBoard.cshtml"
                                                                                      Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</a>
                                        </form>
                                        <form action=""/logout"">
                                            <a class=""nav-link active"" aria-current=""page"" href=""/logout"">Logout</a>
                                        </form>
                                        
                                    </nav>
                                </div>
                                <form method=""post"">
                                    <p><input name=""boardModel.AccessType"" type=""radio"" value=""Public"" checked onclick=""select_users_access(this);"">Для всех</p><br/>
                                    <p><input name=""boardModel.AccessType"" type=""radio"" value=""Private"" id=""privateRB"" onclick=""select_users_access(this);"">Только для некоторых</p><br/>
                                                                      
                                    <div>
                                        <button type=""button"" id=""add_input"" class=""btn btn-primary b");
                    WriteLiteral(@"tn-lg active"" onclick=""add_text_sticker();"">Добавить стикер</button>
                                    </div>
                                                                      
                                    <div>
                                        <button type=""button"" id=""add_table"" class=""btn btn-primary btn-lg active"" onclick=""add_table_sticker();"">Добавить расписание</button>
                                    </div>
                                                                      
                                    <div class=""mp-2"">
                                        <button type=""submit"" class=""btn btn-success"">Submit</button>
                                    </div>
                                </form>
                                
                            </header>
                        </div>
");
#nullable restore
#line 76 "/home/artem/Рабочий стол/C#/NotesFE/NotesFE/Views/Boards/CreateBoard.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                        <div class=""cover-container d-flex w-100 h-100 p-3 mx-auto flex-column"">
                            <header class=""mb-auto"">
                                <div>
                                    <h3 class=""float-md-start mb-0"">Sunrise Soft</h3>
                                    <nav class=""nav nav-masthead justify-content-center float-md-end"">
                                        <a class=""nav-link active"" aria-current=""page"" href=""#"">Home</a>
                                        <form action=""/login"">
                                            <a class=""nav-link active"" aria-current=""page"" href=""/login"">Sign in</a>
                                        </form>
                                        <form action=""/register"">
                                            <a class=""nav-link active"" aria-current=""page"" href=""/register"">Sign up</a>
                                        </form>
                                    </nav>
                                </div");
                    WriteLiteral(@">
                                <form method=""post"">
                                    <p><input name=""boardModel.AccessType"" type=""radio"" value=""Public"" checked onclick=""select_users_access(this);"">Для всех</p><br/>
                                    <p><input name=""boardModel.AccessType"" type=""radio"" value=""Private"" id=""privateRB"" onclick=""select_users_access(this);"">Только для некоторых</p><br/>
                                                                      
                                    <div>
                                        <button type=""button"" id=""add_input"" class=""btn btn-primary btn-lg active"" onclick=""add_text_sticker();"">Добавить стикер</button>
                                    </div>
                                                                      
                                    <div>
                                        <button type=""button"" id=""add_table"" class=""btn btn-primary btn-lg active"" onclick=""add_table_sticker();"">Добавить расписание</button>
   ");
                    WriteLiteral(@"                                 </div>
                                                                      
                                    <div class=""mp-2"">
                                        <button type=""submit"" class=""btn btn-success"">Submit</button>
                                    </div>
                                </form>
                            </header>  
                        </div>
");
#nullable restore
#line 111 "/home/artem/Рабочий стол/C#/NotesFE/NotesFE/Views/Boards/CreateBoard.cshtml"
                    }
            

#line default
#line hidden
#nullable disable
                    WriteLiteral("  ");
                }
                );
                WriteLiteral("  <script src=\"js/CreateBoard.js\"></script>\n  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n");
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
