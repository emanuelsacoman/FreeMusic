#pragma checksum "C:\Users\User\OneDrive\Documentos\Curso Técnico\freemusic\Views\Home\Playlists.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b2d751a137d6a0db9a3f45f05e1df0ae7acd558"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Playlists), @"mvc.1.0.view", @"/Views/Home/Playlists.cshtml")]
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
#line 1 "C:\Users\User\OneDrive\Documentos\Curso Técnico\freemusic\Views\_ViewImports.cshtml"
using freemusic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\OneDrive\Documentos\Curso Técnico\freemusic\Views\_ViewImports.cshtml"
using freemusic.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b2d751a137d6a0db9a3f45f05e1df0ae7acd558", @"/Views/Home/Playlists.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d713e117b9f08bc1712526294ea084fafdbe0b4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Playlists : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\OneDrive\Documentos\Curso Técnico\freemusic\Views\Home\Playlists.cshtml"
  
    ViewData["Title"] = "Playlists";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b2d751a137d6a0db9a3f45f05e1df0ae7acd5583476", async() => {
                WriteLiteral(@"
  <meta charset=""UTF-8"">
    <title>FREE MUSIC</title>
<style>
  body {
    background-image: url(""/images/fundo.jpg""), url(fundo2.jpg);
    background-size: 100%;
    background-repeat:no-repeat;
    background-color: rgb(21, 29, 33);
  }
h1.intro {
  color: rgb(0, 255, 34);
  text-align: center;
}

.important {
  background-color: rgb(21, 29, 33);
}

body {
    display: block;
    margin: 8px;
}
</style>
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b2d751a137d6a0db9a3f45f05e1df0ae7acd5584878", async() => {
                WriteLiteral(@"

<h1 class=""intro important"">FREE MUSIC</h1>
<style>
h1.intro {
  color: rgb(0, 255, 34);
  text-align: center;
}
</style>
<header>
  <nav>
    <ul class=""topnav"">
      
     <a href=""http://localhost:5000/Home""><img src=""/images/logo.png"" alt=""Logo"" width=300 height=85></a>
      
    </ul>
  </nav>
</header>
<br/>

<header>

</header>
</section>
<br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>
<selection>
  <section class=""CENTRO"">
    <h1>VOCÊ PODE GOSTAR:</h1>
    <style>
      .CENTRO {
            display: flex;
            align-items: center;
            justify-content: center;
      }
      body{
        color:chartreuse;
      }
    </style>
  </section>
</selection>

<br/><br/><br/><br/>

<section class=""LOFI"">
<h3>LOFI</h3>
<style>
  .LOFI {
    display:list-item;
    align-items: center;
    justify-content: center;
  }
</style>

<iframe src=""https://open.spotify.com/embed/track/1wq9VorVTLKL2pmRnfOJsk"" width=""300"" height=""380"" framebo");
                WriteLiteral(@"rder=""0"" allowtransparency=""true"" allow=""encrypted-media""></iframe>

</section>
<section class=""ELETRONICA"">
  <h3>ELETRONICA</h3>
  <style>
    .ELETRONICA{
      display: list-item;
      align-items: center;
      justify-content: center;
    }
  </style>

<iframe src=""https://open.spotify.com/embed/track/6ePQanKJhe0GcKOqwj6lOU"" width=""300"" height=""380"" frameborder=""0"" allowtransparency=""true"" allow=""encrypted-media""></iframe>

</section>
<section class=""DUBSTEP"">
  <h3>DUBSTEP</h3>
  <style>
    .DUBSTEP {
      display: list-item;
      align-items: center;
      justify-content: center;
    }
  </style>

<iframe src=""https://open.spotify.com/embed/track/76I3PmbGZazzNlEwlp1y85"" width=""300"" height=""380"" frameborder=""0"" allowtransparency=""true"" allow=""encrypted-media""></iframe>

</section>

<section class=""TRAP"">
  <h3>TRAP</h3>
  <style>
.TRAP {
      display: list-item;
      align-items: center;
      justify-content: center;
}
  </style>

<iframe src=""https://ope");
                WriteLiteral("n.spotify.com/embed-podcast/episode/5KPjdiUHY98OnsCjGN2oC0\" width=\"100%\" height=\"232\" frameborder=\"0\" allowtransparency=\"true\" allow=\"encrypted-media\"></iframe>\r\n<p>MAIS OPÇÕES NO APP!</p>\r\n</section>\r\n\r\n");
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
            WriteLiteral("\r\n</html>");
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
