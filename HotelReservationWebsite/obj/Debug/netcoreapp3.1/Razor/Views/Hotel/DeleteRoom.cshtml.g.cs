#pragma checksum "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\Hotel\DeleteRoom.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0156216fb64b119c748a66c4b029dc906284216b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hotel_DeleteRoom), @"mvc.1.0.view", @"/Views/Hotel/DeleteRoom.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0156216fb64b119c748a66c4b029dc906284216b", @"/Views/Hotel/DeleteRoom.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24568e5d181a623e84ea2790a3202d4b0bb05c6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Hotel_DeleteRoom : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoomViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SeeRoomList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Hotel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\Hotel\DeleteRoom.cshtml"
  
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";


#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\Hotel\DeleteRoom.cshtml"
 if(@Model.Room!= null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0156216fb64b119c748a66c4b029dc906284216b6666", async() => {
                WriteLiteral("\r\n<div class=\"row\" style=\"margin-top:40px\">\r\n    <div class=\"col-md-12\">\r\n        <h1>Chi tiết phòng của khách sạn ");
#nullable restore
#line 11 "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\Hotel\DeleteRoom.cshtml"
                                    Write(Html.DisplayFor(model => model.Room.Hotel.HotelName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n     </div>\r\n</div>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0156216fb64b119c748a66c4b029dc906284216b7419", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 14 "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\Hotel\DeleteRoom.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Room.RoomID);

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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0156216fb64b119c748a66c4b029dc906284216b9168", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 15 "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\Hotel\DeleteRoom.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Room.HotelID);

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
                WriteLiteral("\r\n\r\n    <div class=\"row\" style=\"margin-top:40px\">\r\n    <div class=\"col-md-5\">\r\n        <img");
                BeginWriteAttribute("src", " src=\"", 533, "\"", 559, 1);
#nullable restore
#line 19 "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\Hotel\DeleteRoom.cshtml"
WriteAttributeValue("", 539, Model.Room.ImageUrl, 539, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n     </div>\r\n    <div class=\"col-md-7\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-7\">Room Name:</div>\r\n            <div class=\"col-md-5\">");
#nullable restore
#line 24 "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\Hotel\DeleteRoom.cshtml"
                             Write(Model.Room.RoomName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-7\">Room Number:</div>\r\n            <div class=\"col-md-5\">");
#nullable restore
#line 28 "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\Hotel\DeleteRoom.cshtml"
                             Write(Model.Room.RoomNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        </div>\r\n        <div class=\"row\">\r\n           <div class=\"col-md-7\">Room Category:</div> \r\n            <div class=\"col-md-5\">\r\n                ");
#nullable restore
#line 33 "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\Hotel\DeleteRoom.cshtml"
           Write(Model.Room.RoomCategory.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n           <div class=\"col-md-7\">Room Status:</div> \r\n            <div class=\"col-md-5\">\r\n");
#nullable restore
#line 39 "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\Hotel\DeleteRoom.cshtml"
                 if(Model.Room.RoomStatus == 1)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <a class=\"btn btn-danger\">Can put</a>\r\n");
#nullable restore
#line 42 "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\Hotel\DeleteRoom.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                   <a class=\"btn btn-info\">Reserved</a> \r\n");
#nullable restore
#line 46 "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\Hotel\DeleteRoom.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n           <div class=\"col-md-5\">Unit Price:</div> \r\n            <div class=\"col-md-7\">");
#nullable restore
#line 51 "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\Hotel\DeleteRoom.cshtml"
                             Write(Model.Room.UnitPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        </div>\r\n        <div class=\"row\">\r\n           ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0156216fb64b119c748a66c4b029dc906284216b14501", async() => {
                    WriteLiteral("Back");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\Hotel\DeleteRoom.cshtml"
                                                                                       WriteLiteral(Model.Room.HotelID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n           <button type=\"submit\" class=\"btn btn-danger\">Delete</button>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 60 "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\Hotel\DeleteRoom.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\" style=\"margin-top:40px\">\r\n    <div class=\"col-md-12\">\r\n        <h1>No Data</h1>\r\n     </div> \r\n    </div>    \r\n");
#nullable restore
#line 68 "C:\Users\thanh\OneDrive\Documents\project-HotelReservationWebsite\HotelReservationWebsite\Views\Hotel\DeleteRoom.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoomViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
