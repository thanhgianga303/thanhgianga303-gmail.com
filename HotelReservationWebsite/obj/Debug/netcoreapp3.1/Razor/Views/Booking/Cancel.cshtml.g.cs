#pragma checksum "D:\project-HotelReservationWebsite\HotelReservationWebsite\Views\Booking\Cancel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0c0cc653e5934b50027f11d7491dc960c8956b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_Cancel), @"mvc.1.0.view", @"/Views/Booking/Cancel.cshtml")]
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
#line 1 "D:\project-HotelReservationWebsite\HotelReservationWebsite\Views\_ViewImports.cshtml"
using HotelReservationWebsite.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\project-HotelReservationWebsite\HotelReservationWebsite\Views\_ViewImports.cshtml"
using HotelReservationWebsite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\project-HotelReservationWebsite\HotelReservationWebsite\Views\_ViewImports.cshtml"
using HotelReservationWebsite.Services.IService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\project-HotelReservationWebsite\HotelReservationWebsite\Views\_ViewImports.cshtml"
using HotelReservationWebsite.Services.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\project-HotelReservationWebsite\HotelReservationWebsite\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\project-HotelReservationWebsite\HotelReservationWebsite\Views\_ViewImports.cshtml"
using HotelReservationWebsite.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0c0cc653e5934b50027f11d7491dc960c8956b5", @"/Views/Booking/Cancel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24568e5d181a623e84ea2790a3202d4b0bb05c6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_Cancel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Booking>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cancel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\project-HotelReservationWebsite\HotelReservationWebsite\Views\Booking\Cancel.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-md-12"">
        <div class=""row"">
            <div class=""col-md-3""><hr style=""height:1px;border:none;color:#333;background-color:#333;""/></div>
            <div class=""col-md-6"" style=""text-align: center;""><h1>Details of the reservation list have id ");
#nullable restore
#line 9 "D:\project-HotelReservationWebsite\HotelReservationWebsite\Views\Booking\Cancel.cshtml"
                                                                                                     Write(Model.BookingId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h1></div>
            <div class=""col-md-3""><hr style=""height:1px;border:none;color:#333;background-color:#333;""/></div>
        </div>
        <div class=""row"">
            <div class=""col-md-12"">
                <table class=""table table-dark"">
                    <thead>
                        <tr>
                        <th scope=""col"">Booking ID</th>
                        <th scope=""col"">Name</th>
                        <th scope=""col"">Phone</th>
                        <th scope=""col"">Identity Card</th>
                        <th scope=""col"">Booking Date</th>
                        <th scope=""col"">Status</th>
                        <th scope=""col"">Total cost</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                        <td>");
#nullable restore
#line 28 "D:\project-HotelReservationWebsite\HotelReservationWebsite\Views\Booking\Cancel.cshtml"
                       Write(Model.BookingId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 29 "D:\project-HotelReservationWebsite\HotelReservationWebsite\Views\Booking\Cancel.cshtml"
                       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "D:\project-HotelReservationWebsite\HotelReservationWebsite\Views\Booking\Cancel.cshtml"
                       Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "D:\project-HotelReservationWebsite\HotelReservationWebsite\Views\Booking\Cancel.cshtml"
                       Write(Model.IdentityCard);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "D:\project-HotelReservationWebsite\HotelReservationWebsite\Views\Booking\Cancel.cshtml"
                       Write(Model.BookingDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 33 "D:\project-HotelReservationWebsite\HotelReservationWebsite\Views\Booking\Cancel.cshtml"
                       Write(Model.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "D:\project-HotelReservationWebsite\HotelReservationWebsite\Views\Booking\Cancel.cshtml"
                       Write(Model.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr> \r\n                    </tbody>\r\n                    </table>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 40 "D:\project-HotelReservationWebsite\HotelReservationWebsite\Views\Booking\Cancel.cshtml"
             foreach (var item in Model.Items)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row shadow p-3 mb-5 bg-white rounded\">\r\n                    <div class=\"col-md-4\"><img");
            BeginWriteAttribute("src", " src=\"", 1833, "\"", 1853, 1);
#nullable restore
#line 43 "D:\project-HotelReservationWebsite\HotelReservationWebsite\Views\Booking\Cancel.cshtml"
WriteAttributeValue("", 1839, item.ImageUri, 1839, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" width=""266.6px"" height=""300px"" /></div>
                    <div class=""col-md-4"">
                        <div class=""row"">
                            <div class=""col-md-6""><h3>Hotel name:</h3></div>
                            <div class=""col-md-6"">");
#nullable restore
#line 47 "D:\project-HotelReservationWebsite\HotelReservationWebsite\Views\Booking\Cancel.cshtml"
                                             Write(item.HotelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-6\"><h3>Room name:</h3></div>\r\n                            <div class=\"col-md-6\">");
#nullable restore
#line 51 "D:\project-HotelReservationWebsite\HotelReservationWebsite\Views\Booking\Cancel.cshtml"
                                             Write(item.RoomName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-6\"><h3>Number of rooms:</h3></div>\r\n                            <div class=\"col-md-6\">");
#nullable restore
#line 55 "D:\project-HotelReservationWebsite\HotelReservationWebsite\Views\Booking\Cancel.cshtml"
                                             Write(item.RoomNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-6\"><h3>Address:</h3></div>\r\n                            <div class=\"col-md-6\">");
#nullable restore
#line 59 "D:\project-HotelReservationWebsite\HotelReservationWebsite\Views\Booking\Cancel.cshtml"
                                             Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 59 "D:\project-HotelReservationWebsite\HotelReservationWebsite\Views\Booking\Cancel.cshtml"
                                                            Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-6\"><h3>Category name:</h3></div>\r\n                            <div class=\"col-md-6\">");
#nullable restore
#line 63 "D:\project-HotelReservationWebsite\HotelReservationWebsite\Views\Booking\Cancel.cshtml"
                                             Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                        
                    </div>
                    <div class=""col-md-4"">
                        <div class=""row"">
                            <div class=""col-md-6""><h3>Check in:</h3></div>
                            <div class=""col-md-6"">");
#nullable restore
#line 70 "D:\project-HotelReservationWebsite\HotelReservationWebsite\Views\Booking\Cancel.cshtml"
                                             Write(item.CheckIn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-6\"><h3>Check out:</h3></div>\r\n                            <div class=\"col-md-6\">");
#nullable restore
#line 74 "D:\project-HotelReservationWebsite\HotelReservationWebsite\Views\Booking\Cancel.cshtml"
                                             Write(item.CheckOut);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-6\"><h3>Unit price:</h3></div>\r\n                            <div class=\"col-md-6\">");
#nullable restore
#line 78 "D:\project-HotelReservationWebsite\HotelReservationWebsite\Views\Booking\Cancel.cshtml"
                                             Write(item.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" USD</div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-6\"><h3>Day number:</h3></div>\r\n                            <div class=\"col-md-6\">");
#nullable restore
#line 82 "D:\project-HotelReservationWebsite\HotelReservationWebsite\Views\Booking\Cancel.cshtml"
                                             Write(item.DayNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-6\"><h3>Cost:</h3></div>\r\n                            <div class=\"col-md-6\">");
#nullable restore
#line 86 "D:\project-HotelReservationWebsite\HotelReservationWebsite\Views\Booking\Cancel.cshtml"
                                             Write(item.Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 90 "D:\project-HotelReservationWebsite\HotelReservationWebsite\Views\Booking\Cancel.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-md-12\" style=\"text-align:center\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0c0cc653e5934b50027f11d7491dc960c8956b515178", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e0c0cc653e5934b50027f11d7491dc960c8956b515461", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 94 "D:\project-HotelReservationWebsite\HotelReservationWebsite\Views\Booking\Cancel.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.BookingId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <input type=\"submit\" class=\"btn btn-danger\" value=\"Cancel\"/>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Booking> Html { get; private set; }
    }
}
#pragma warning restore 1591