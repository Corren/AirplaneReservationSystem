#pragma checksum "C:\Users\jonat\Desktop\WebApplication44\WebApplication44\Pages\Flights\CustomerDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "268648eae63c50a5d3e05d14e9431d985f9ea326"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication44.Pages.Flights.Pages_Flights_CustomerDetails), @"mvc.1.0.razor-page", @"/Pages/Flights/CustomerDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Flights/CustomerDetails.cshtml", typeof(WebApplication44.Pages.Flights.Pages_Flights_CustomerDetails), null)]
namespace WebApplication44.Pages.Flights
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\jonat\Desktop\WebApplication44\WebApplication44\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\jonat\Desktop\WebApplication44\WebApplication44\Pages\_ViewImports.cshtml"
using WebApplication44;

#line default
#line hidden
#line 3 "C:\Users\jonat\Desktop\WebApplication44\WebApplication44\Pages\_ViewImports.cshtml"
using WebApplication44.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"268648eae63c50a5d3e05d14e9431d985f9ea326", @"/Pages/Flights/CustomerDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bff97cf897b8bd1319e5a275bbd66c6a8c7eb06", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Flights_CustomerDetails : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./CustomerIndex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Seats/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\jonat\Desktop\WebApplication44\WebApplication44\Pages\Flights\CustomerDetails.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(102, 127, true);
            WriteLiteral("\r\n<h2>Flight Details</h2>\r\n\r\n<div>\r\n    <h4>Flight</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(230, 61, false);
#line 14 "C:\Users\jonat\Desktop\WebApplication44\WebApplication44\Pages\Flights\CustomerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Flight.CapacityFirstClass));

#line default
#line hidden
            EndContext();
            BeginContext(291, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(335, 57, false);
#line 17 "C:\Users\jonat\Desktop\WebApplication44\WebApplication44\Pages\Flights\CustomerDetails.cshtml"
       Write(Html.DisplayFor(model => model.Flight.CapacityFirstClass));

#line default
#line hidden
            EndContext();
            BeginContext(392, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(436, 58, false);
#line 20 "C:\Users\jonat\Desktop\WebApplication44\WebApplication44\Pages\Flights\CustomerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Flight.CapacityEconomy));

#line default
#line hidden
            EndContext();
            BeginContext(494, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(538, 54, false);
#line 23 "C:\Users\jonat\Desktop\WebApplication44\WebApplication44\Pages\Flights\CustomerDetails.cshtml"
       Write(Html.DisplayFor(model => model.Flight.CapacityEconomy));

#line default
#line hidden
            EndContext();
            BeginContext(592, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(636, 58, false);
#line 26 "C:\Users\jonat\Desktop\WebApplication44\WebApplication44\Pages\Flights\CustomerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Flight.PriceFirstClass));

#line default
#line hidden
            EndContext();
            BeginContext(694, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(738, 54, false);
#line 29 "C:\Users\jonat\Desktop\WebApplication44\WebApplication44\Pages\Flights\CustomerDetails.cshtml"
       Write(Html.DisplayFor(model => model.Flight.PriceFirstClass));

#line default
#line hidden
            EndContext();
            BeginContext(792, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(836, 55, false);
#line 32 "C:\Users\jonat\Desktop\WebApplication44\WebApplication44\Pages\Flights\CustomerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Flight.PriceEconomy));

#line default
#line hidden
            EndContext();
            BeginContext(891, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(935, 51, false);
#line 35 "C:\Users\jonat\Desktop\WebApplication44\WebApplication44\Pages\Flights\CustomerDetails.cshtml"
       Write(Html.DisplayFor(model => model.Flight.PriceEconomy));

#line default
#line hidden
            EndContext();
            BeginContext(986, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1030, 56, false);
#line 38 "C:\Users\jonat\Desktop\WebApplication44\WebApplication44\Pages\Flights\CustomerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Flight.TimeDeparture));

#line default
#line hidden
            EndContext();
            BeginContext(1086, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1130, 52, false);
#line 41 "C:\Users\jonat\Desktop\WebApplication44\WebApplication44\Pages\Flights\CustomerDetails.cshtml"
       Write(Html.DisplayFor(model => model.Flight.TimeDeparture));

#line default
#line hidden
            EndContext();
            BeginContext(1182, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1226, 54, false);
#line 44 "C:\Users\jonat\Desktop\WebApplication44\WebApplication44\Pages\Flights\CustomerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Flight.TimeArrival));

#line default
#line hidden
            EndContext();
            BeginContext(1280, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1324, 50, false);
#line 47 "C:\Users\jonat\Desktop\WebApplication44\WebApplication44\Pages\Flights\CustomerDetails.cshtml"
       Write(Html.DisplayFor(model => model.Flight.TimeArrival));

#line default
#line hidden
            EndContext();
            BeginContext(1374, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1418, 59, false);
#line 50 "C:\Users\jonat\Desktop\WebApplication44\WebApplication44\Pages\Flights\CustomerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Flight.AirportDeparture));

#line default
#line hidden
            EndContext();
            BeginContext(1477, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1521, 55, false);
#line 53 "C:\Users\jonat\Desktop\WebApplication44\WebApplication44\Pages\Flights\CustomerDetails.cshtml"
       Write(Html.DisplayFor(model => model.Flight.AirportDeparture));

#line default
#line hidden
            EndContext();
            BeginContext(1576, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1620, 57, false);
#line 56 "C:\Users\jonat\Desktop\WebApplication44\WebApplication44\Pages\Flights\CustomerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Flight.AirportArrival));

#line default
#line hidden
            EndContext();
            BeginContext(1677, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1721, 53, false);
#line 59 "C:\Users\jonat\Desktop\WebApplication44\WebApplication44\Pages\Flights\CustomerDetails.cshtml"
       Write(Html.DisplayFor(model => model.Flight.AirportArrival));

#line default
#line hidden
            EndContext();
            BeginContext(1774, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1821, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ee0c97bf74040bf89a0418e80cf6067", async() => {
                BeginContext(1851, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1867, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1875, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d6a7a024eba4fb4b936a126228a6f1e", async() => {
                BeginContext(1950, 10, true);
                WriteLiteral("View Seats");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-SeatFlightId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "C:\Users\jonat\Desktop\WebApplication44\WebApplication44\Pages\Flights\CustomerDetails.cshtml"
                                           WriteLiteral(Model.Flight.FlightId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["SeatFlightId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-SeatFlightId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["SeatFlightId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1964, 11, true);
            WriteLiteral(" \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication44.Pages.Flights.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication44.Pages.Flights.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication44.Pages.Flights.DetailsModel>)PageContext?.ViewData;
        public WebApplication44.Pages.Flights.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
