#pragma checksum "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\Home\_hotel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a620a3c78313662cf6ab5f7a1a848e058b06e0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__hotel), @"mvc.1.0.view", @"/Views/Home/_hotel.cshtml")]
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
#line 1 "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\_ViewImports.cshtml"
using HotelReservationWebsite.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\_ViewImports.cshtml"
using HotelReservationWebsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a620a3c78313662cf6ab5f7a1a848e058b06e0d", @"/Views/Home/_hotel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e75e3e6474a3421664077bae90941165a3f0188b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__hotel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hotel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n            <div class=\"image\"");
            BeginWriteAttribute("style", " style=\"", 46, "\"", 93, 4);
            WriteAttributeValue("", 54, "background-image:", 54, 17, true);
            WriteAttributeValue(" ", 71, "url(", 72, 5, true);
#nullable restore
#line 3 "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\Home\_hotel.cshtml"
WriteAttributeValue("", 76, Model.ImageUrl, 76, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 91, ");", 91, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"descrip text-center\">\r\n                    <p><small>For as low as</small><span>$100/night</span></p>\r\n                </div>\r\n               \r\n            </div>\r\n            <div class=\"desc\">\r\n                <h3>");
#nullable restore
#line 10 "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\Home\_hotel.cshtml"
               Write(Model.HotelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <p>Address: \r\n");
#nullable restore
#line 12 "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\Home\_hotel.cshtml"
                     foreach (var item1 in Model.Addresses)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>");
#nullable restore
#line 14 "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\Home\_hotel.cshtml"
                      Write(item1.HotelAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 15 "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\Home\_hotel.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                   </p>\r\n                <p>number of rooms left: </p>\r\n                 <p>\r\n                    ");
#nullable restore
#line 19 "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\Home\_hotel.cshtml"
               Write(Model.ImageUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <p><a href=\"#\" class=\"btn btn-primary btn-luxe-primary\">Book Now <i class=\"ti-angle-right\"></i></a></p>\r\n            </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hotel> Html { get; private set; }
    }
}
#pragma warning restore 1591
