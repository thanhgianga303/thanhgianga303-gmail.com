#pragma checksum "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\Shared\Components\BasketList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2ff23d8e0701e95f10f1cc5df4732fab610611d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BasketList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BasketList/Default.cshtml")]
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
#nullable restore
#line 3 "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\_ViewImports.cshtml"
using HotelReservationWebsite.Services.IService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\_ViewImports.cshtml"
using HotelReservationWebsite.Services.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\_ViewImports.cshtml"
using HotelReservationWebsite.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2ff23d8e0701e95f10f1cc5df4732fab610611d", @"/Views/Shared/Components/BasketList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24568e5d181a623e84ea2790a3202d4b0bb05c6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BasketList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cart>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n");
#nullable restore
#line 4 "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\Shared\Components\BasketList\Default.cshtml"
             for (int i = 0; i < Model.Items.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\" style=\"margin-top:20px;\">\r\n                    <div class=\"col-md-4\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 245, "\"", 275, 1);
#nullable restore
#line 8 "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\Shared\Components\BasketList\Default.cshtml"
WriteAttributeValue("", 251, Model.Items[i].ImageUrl, 251, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" width=""266.6px"" height=""300px""/>
                    </div>
                    <div class=""col-md-4"">
                        <div class=""row"">
                            <div class=""col-md-6""><h3>Room Name:</h3></div>
                            <div class=""col-md-6"">");
#nullable restore
#line 13 "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\Shared\Components\BasketList\Default.cshtml"
                                             Write(Model.Items[i].HotelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-4\">Delete</div>\r\n                </div>\r\n");
#nullable restore
#line 18 "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\Shared\Components\BasketList\Default.cshtml"
            }                

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cart> Html { get; private set; }
    }
}
#pragma warning restore 1591
