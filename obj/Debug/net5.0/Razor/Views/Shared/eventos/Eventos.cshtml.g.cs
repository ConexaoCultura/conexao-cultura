#pragma checksum "C:\Users\IgorMozetic\Documents\IFSP\TCC-ConexaoCultura\conexao-cultura\Views\Shared\eventos\Eventos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bd236b4b580dce01187b9e7b5a19ee3103a30db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_eventos_Eventos), @"mvc.1.0.view", @"/Views/Shared/eventos/Eventos.cshtml")]
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
#line 1 "C:\Users\IgorMozetic\Documents\IFSP\TCC-ConexaoCultura\conexao-cultura\Views\_ViewImports.cshtml"
using ConexaoCultura;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\IgorMozetic\Documents\IFSP\TCC-ConexaoCultura\conexao-cultura\Views\_ViewImports.cshtml"
using ConexaoCultura.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bd236b4b580dce01187b9e7b5a19ee3103a30db", @"/Views/Shared/eventos/Eventos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33260fe573a8196261d741d97b48e53211cb7286", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_eventos_Eventos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"pt-BR\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bd236b4b580dce01187b9e7b5a19ee3103a30db3372", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <!-- Bootstrap CSS -->
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet""
        integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
    <!-- CSS -->
    <link rel=""stylesheet"" href=""../CSS/style.css"">
    <link rel=""stylesheet"" href=""./css/eventos.css"">
    <!-- FAVICON -->
    <link rel=""shortcut icon"" href=""../img/favicon.ico"" type=""image/x-icon"">
    <title>Conex??o Cultura</title>
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bd236b4b580dce01187b9e7b5a19ee3103a30db5050", async() => {
                WriteLiteral(@"
    <!-- NAVIGATION -->
    <header>
        <nav class=""navbar navbar-expand-lg navbar-light bg-light"">
            <img class=""logo"" src=""../img/logo.png"" alt=""Logo Conex??o Cultura"">
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarTogglerDemo02""
                aria-controls=""navbarTogglerDemo02"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>

            <div class=""collapse navbar-collapse"" id=""navbarTogglerDemo02"">
                <ul class=""navbar-nav mr-auto mt-2 mt-lg-0"">
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""../inicio/index.html"">Home</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#"">Perfil</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#"">Mapa");
                WriteLiteral(@"</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#"">Roteiro</a>
                    </li>
                </ul>
            </div>
        </nav>
    </header>

    <main>
        <h2 class=""titulo"">Evento</h2>
        <div class=""linha""></div>
        <div class=""imgEvento"">
            <img src=""./img/eventoUm.png"" alt=""Imagem evento"">
        </div>


    </main>

    <!-- FOOTER -->
    <footer class=""text-center text-lg-start bg-light text-muted"">
        <section class=""contato"">
            <div class=""container text-center text-md-start mt-5"">
                <!-- Grid row -->
                <div class=""row mt-3"">
                    <!-- Grid column -->
                    <div class=""col-md-3 col-lg-4 col-xl-3 mx-auto mb-4"">
                        <img src=""../img/logoSemNome.png""");
                BeginWriteAttribute("alt", " alt=\"", 2671, "\"", 2677, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        <p>??2021 Conex??o Cultura</p>
                        <p>Todos os direitos reservados</p>
                    </div>

                    <!-- Grid column -->
                    <div class=""col-md-3 col-lg-3 col-xl-2 mx-auto mb-4"">
                        <h6 class=""text-uppercase fw-bold mb-4""><a href=""../inicio/index.html"">Home</a></h6>
                        <p><a href=""#!"" class=""text-reset"">Perfil</a></p>
                        <p><a href=""#!"" class=""text-reset"">Mapa</a></p>
                        <p><a href=""#!"" class=""text-reset"">Roteiro</a></p>
                    </div>

                    <!-- Grid column -->
                    <div class=""col-md-3 col-lg-3 col-xl-2 mx-auto mb-4"">
                        <h6 class=""text-uppercase fw-bold mb-4"">Contato</h6>
                        <p>conex??o@cultura.com</p>
                        <p>(11)2222-2222</p>
                    </div>

                    <!-- Grid column -->
                    <div class");
                WriteLiteral(@"=""col-md-3 col-lg-3 col-xl-3 mx-auto mb-4"">
                        <h6 class=""text-uppercase fw-bold mb-4"">Social
                        </h6>
                        <p><a href=""#!"" class=""text-reset""><i class=""fab fa-facebook""></i> Facebook</a></p>
                        <p><a href=""#!"" class=""text-reset""><i class=""fab fa-instagram""></i> Instagram</a></p>
                        <p><a href=""#!"" class=""text-reset""><i class=""fab fa-twitter""></i> Twitter</a></p>
                    </div>
                </div>
            </div>
        </section>
    </footer>

    <!-- Bootstrap-->
    <script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js""
        integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN""
        crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js""
        integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q""
        crossorigin=""anonym");
                WriteLiteral(@"ous""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js""
        integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl""
        crossorigin=""anonymous""></script>
    <!-- Font Awesome -->
    <script src=""https://kit.fontawesome.com/3eecc79a6a.js"" crossorigin=""anonymous""></script>
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
            WriteLiteral("\r\n\r\n</html>");
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
