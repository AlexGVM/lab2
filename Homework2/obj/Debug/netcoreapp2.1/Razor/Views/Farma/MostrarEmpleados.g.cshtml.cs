#pragma checksum "/Users/lisdiaz/Documents/U/Semetre III/Estructura de datos I/Lab/Tareas/Tarea Laboratorio 2/Homework2/Homework2/Views/Farma/MostrarEmpleados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f841a962a00c33ac161590acdf9cc0b5a82aaf98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Farma_MostrarEmpleados), @"mvc.1.0.view", @"/Views/Farma/MostrarEmpleados.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Farma/MostrarEmpleados.cshtml", typeof(AspNetCore.Views_Farma_MostrarEmpleados))]
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
#line 1 "/Users/lisdiaz/Documents/U/Semetre III/Estructura de datos I/Lab/Tareas/Tarea Laboratorio 2/Homework2/Homework2/Views/_ViewImports.cshtml"
using Homework2;

#line default
#line hidden
#line 2 "/Users/lisdiaz/Documents/U/Semetre III/Estructura de datos I/Lab/Tareas/Tarea Laboratorio 2/Homework2/Homework2/Views/_ViewImports.cshtml"
using Homework2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f841a962a00c33ac161590acdf9cc0b5a82aaf98", @"/Views/Farma/MostrarEmpleados.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f837328123930bb558077f148cd277c37b888573", @"/Views/_ViewImports.cshtml")]
    public class Views_Farma_MostrarEmpleados : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Homework2.Models.FarmaModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/lisdiaz/Documents/U/Semetre III/Estructura de datos I/Lab/Tareas/Tarea Laboratorio 2/Homework2/Homework2/Views/Farma/MostrarEmpleados.cshtml"
  
    ViewBag.Title = "MostrarEmpleado";

#line default
#line hidden
            BeginContext(85, 61, true);
            WriteLiteral("\r\n<h2>Cantidad de empleados</h2>\r\n<h3>Total Empleados: </h3> ");
            EndContext();
            BeginContext(147, 22, false);
#line 8 "/Users/lisdiaz/Documents/U/Semetre III/Estructura de datos I/Lab/Tareas/Tarea Laboratorio 2/Homework2/Homework2/Views/Farma/MostrarEmpleados.cshtml"
                      Write(ViewBag.TotalEmpleados);

#line default
#line hidden
            EndContext();
            BeginContext(169, 61, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(231, 42, false);
#line 12 "/Users/lisdiaz/Documents/U/Semetre III/Estructura de datos I/Lab/Tareas/Tarea Laboratorio 2/Homework2/Homework2/Views/Farma/MostrarEmpleados.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(273, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(317, 42, false);
#line 15 "/Users/lisdiaz/Documents/U/Semetre III/Estructura de datos I/Lab/Tareas/Tarea Laboratorio 2/Homework2/Homework2/Views/Farma/MostrarEmpleados.cshtml"
       Write(Html.DisplayNameFor(model => model.Codigo));

#line default
#line hidden
            EndContext();
            BeginContext(359, 57, true);
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Homework2.Models.FarmaModel> Html { get; private set; }
    }
}
#pragma warning restore 1591