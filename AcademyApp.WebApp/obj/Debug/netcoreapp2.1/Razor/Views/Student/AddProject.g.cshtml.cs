#pragma checksum "C:\Users\Stojmilova\Desktop\ASP.NET Data-Driven\Workshop-Vezba od Cas-Class04\SEDC.AcademyApp\AcademyApp.WebApp\Views\Student\AddProject.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54d92f1ddcee01a93fc2d036af6dd466ac4b64f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_AddProject), @"mvc.1.0.view", @"/Views/Student/AddProject.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/AddProject.cshtml", typeof(AspNetCore.Views_Student_AddProject))]
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
#line 1 "C:\Users\Stojmilova\Desktop\ASP.NET Data-Driven\Workshop-Vezba od Cas-Class04\SEDC.AcademyApp\AcademyApp.WebApp\Views\_ViewImports.cshtml"
using AcademyApp.WebApp;

#line default
#line hidden
#line 2 "C:\Users\Stojmilova\Desktop\ASP.NET Data-Driven\Workshop-Vezba od Cas-Class04\SEDC.AcademyApp\AcademyApp.WebApp\Views\_ViewImports.cshtml"
using AcademyApp.WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54d92f1ddcee01a93fc2d036af6dd466ac4b64f0", @"/Views/Student/AddProject.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61aa9a3b9ed66c754ba1ab2de98644157c72f3d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_AddProject : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AddProjectViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 16, true);
            WriteLiteral("<br />\r\n<br />\r\n");
            EndContext();
#line 4 "C:\Users\Stojmilova\Desktop\ASP.NET Data-Driven\Workshop-Vezba od Cas-Class04\SEDC.AcademyApp\AcademyApp.WebApp\Views\Student\AddProject.cshtml"
  
    ViewBag.Title = "Add Project";

#line default
#line hidden
            BeginContext(87, 35, true);
            WriteLiteral("<br />\r\n<h1 style=\"color:deeppink\">");
            EndContext();
            BeginContext(123, 13, false);
#line 8 "C:\Users\Stojmilova\Desktop\ASP.NET Data-Driven\Workshop-Vezba od Cas-Class04\SEDC.AcademyApp\AcademyApp.WebApp\Views\Student\AddProject.cshtml"
                      Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(136, 42, true);
            WriteLiteral("</h1>\r\n<br />\r\n<div class=\"jumbotron\">\r\n\r\n");
            EndContext();
#line 12 "C:\Users\Stojmilova\Desktop\ASP.NET Data-Driven\Workshop-Vezba od Cas-Class04\SEDC.AcademyApp\AcademyApp.WebApp\Views\Student\AddProject.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
            BeginContext(225, 25, false);
#line 14 "C:\Users\Stojmilova\Desktop\ASP.NET Data-Driven\Workshop-Vezba od Cas-Class04\SEDC.AcademyApp\AcademyApp.WebApp\Views\Student\AddProject.cshtml"
   Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
            EndContext();
            BeginContext(261, 32, false);
#line 15 "C:\Users\Stojmilova\Desktop\ASP.NET Data-Driven\Workshop-Vezba od Cas-Class04\SEDC.AcademyApp\AcademyApp.WebApp\Views\Student\AddProject.cshtml"
   Write(Html.HiddenFor(x => x.StudentId));

#line default
#line hidden
            EndContext();
            BeginContext(304, 27, false);
#line 16 "C:\Users\Stojmilova\Desktop\ASP.NET Data-Driven\Workshop-Vezba od Cas-Class04\SEDC.AcademyApp\AcademyApp.WebApp\Views\Student\AddProject.cshtml"
   Write(Html.LabelFor(x => x.Title));

#line default
#line hidden
            EndContext();
            BeginContext(342, 29, false);
#line 17 "C:\Users\Stojmilova\Desktop\ASP.NET Data-Driven\Workshop-Vezba od Cas-Class04\SEDC.AcademyApp\AcademyApp.WebApp\Views\Student\AddProject.cshtml"
   Write(Html.TextBoxFor(x => x.Title));

#line default
#line hidden
            EndContext();
            BeginContext(373, 16, true);
            WriteLiteral("        <br />\r\n");
            EndContext();
            BeginContext(398, 35, false);
#line 19 "C:\Users\Stojmilova\Desktop\ASP.NET Data-Driven\Workshop-Vezba od Cas-Class04\SEDC.AcademyApp\AcademyApp.WebApp\Views\Student\AddProject.cshtml"
   Write(Html.LabelFor(x => x.EstimatedTime));

#line default
#line hidden
            EndContext();
            BeginContext(444, 37, false);
#line 20 "C:\Users\Stojmilova\Desktop\ASP.NET Data-Driven\Workshop-Vezba od Cas-Class04\SEDC.AcademyApp\AcademyApp.WebApp\Views\Student\AddProject.cshtml"
   Write(Html.TextBoxFor(x => x.EstimatedTime));

#line default
#line hidden
            EndContext();
            BeginContext(483, 16, true);
            WriteLiteral("        <br />\r\n");
            EndContext();
            BeginContext(508, 31, false);
#line 22 "C:\Users\Stojmilova\Desktop\ASP.NET Data-Driven\Workshop-Vezba od Cas-Class04\SEDC.AcademyApp\AcademyApp.WebApp\Views\Student\AddProject.cshtml"
   Write(Html.LabelFor(x => x.TimeSpend));

#line default
#line hidden
            EndContext();
            BeginContext(550, 33, false);
#line 23 "C:\Users\Stojmilova\Desktop\ASP.NET Data-Driven\Workshop-Vezba od Cas-Class04\SEDC.AcademyApp\AcademyApp.WebApp\Views\Student\AddProject.cshtml"
   Write(Html.TextBoxFor(x => x.TimeSpend));

#line default
#line hidden
            EndContext();
            BeginContext(585, 91, true);
            WriteLiteral("        <br />\r\n        <button class=\"btn btn-danger\" type=\"submit\">Add Project</button>\r\n");
            EndContext();
#line 26 "C:\Users\Stojmilova\Desktop\ASP.NET Data-Driven\Workshop-Vezba od Cas-Class04\SEDC.AcademyApp\AcademyApp.WebApp\Views\Student\AddProject.cshtml"
    }

#line default
#line hidden
            BeginContext(683, 19, true);
            WriteLiteral("\r\n</div>\r\n  \r\n \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AddProjectViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
