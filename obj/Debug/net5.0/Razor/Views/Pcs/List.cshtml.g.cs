#pragma checksum "C:\Users\Рабочий\source\repos\EPCShop\EPCShop\Views\Pcs\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3da77ddf081f58abfd7a5079143299119019a63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pcs_List), @"mvc.1.0.view", @"/Views/Pcs/List.cshtml")]
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
#line 1 "C:\Users\Рабочий\source\repos\EPCShop\EPCShop\Views\_ViewImports.cshtml"
using EPCShop.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3da77ddf081f58abfd7a5079143299119019a63", @"/Views/Pcs/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7589ead1e87537b085bb5ba51a843531b0546c26", @"/Views/_ViewImports.cshtml")]
    public class Views_Pcs_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Все сборки</h1>\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 4 "C:\Users\Рабочий\source\repos\EPCShop\EPCShop\Views\Pcs\List.cshtml"
          
            foreach (var pc in Model.allPcs)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-sm-4\">\r\n                    <div class=\"card\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 250, "\"", 263, 1);
#nullable restore
#line 9 "C:\Users\Рабочий\source\repos\EPCShop\EPCShop\Views\Pcs\List.cshtml"
WriteAttributeValue("", 256, pc.img, 256, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">");
#nullable restore
#line 11 "C:\Users\Рабочий\source\repos\EPCShop\EPCShop\Views\Pcs\List.cshtml"
                                              Write(pc.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"card-text\">");
#nullable restore
#line 12 "C:\Users\Рабочий\source\repos\EPCShop\EPCShop\Views\Pcs\List.cshtml"
                                            Write(pc.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <a href=\"#\" class=\"btn btn-primary\">Подробнее</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 17 "C:\Users\Рабочий\source\repos\EPCShop\EPCShop\Views\Pcs\List.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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