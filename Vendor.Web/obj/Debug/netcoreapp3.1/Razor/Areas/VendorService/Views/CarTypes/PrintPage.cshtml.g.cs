#pragma checksum "C:\Users\Afsane\Desktop\Vendor(1)\Vendor(1)\Vendor(1)\Vendor\Vendor\Vendor.Web\Areas\VendorService\Views\CarTypes\PrintPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24644b5027a50f9151c189beae719a78ffb6f2c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_VendorService_Views_CarTypes_PrintPage), @"mvc.1.0.view", @"/Areas/VendorService/Views/CarTypes/PrintPage.cshtml")]
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
#line 1 "C:\Users\Afsane\Desktop\Vendor(1)\Vendor(1)\Vendor(1)\Vendor\Vendor\Vendor.Web\Areas\VendorService\Views\_ViewImports.cshtml"
using Vendor.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Afsane\Desktop\Vendor(1)\Vendor(1)\Vendor(1)\Vendor\Vendor\Vendor.Web\Areas\VendorService\Views\_ViewImports.cshtml"
using Vendor.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Afsane\Desktop\Vendor(1)\Vendor(1)\Vendor(1)\Vendor\Vendor\Vendor.Web\Areas\VendorService\Views\CarTypes\PrintPage.cshtml"
using Stimulsoft.Report.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24644b5027a50f9151c189beae719a78ffb6f2c6", @"/Areas/VendorService/Views/CarTypes/PrintPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32b89ce51ccf45b1c282b0c1f07cce8adb9c9e10", @"/Areas/VendorService/Views/_ViewImports.cshtml")]
    public class Areas_VendorService_Views_CarTypes_PrintPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Afsane\Desktop\Vendor(1)\Vendor(1)\Vendor(1)\Vendor\Vendor\Vendor.Web\Areas\VendorService\Views\CarTypes\PrintPage.cshtml"
       Layout = ""; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h2>Show Report in the Viewer</h2>\r\n\r\n    <div class=\"row\">\r\n        ");
#nullable restore
#line 8 "C:\Users\Afsane\Desktop\Vendor(1)\Vendor(1)\Vendor(1)\Vendor\Vendor\Vendor.Web\Areas\VendorService\Views\CarTypes\PrintPage.cshtml"
   Write(Html.StiNetCoreViewer(new StiNetCoreViewerOptions()
        {

            Server =
                            {
             Controller = "CarTypes"

                            },
            Actions =
            {
                GetReport = "Print",
                ViewerEvent = "ViewerEvent"
            }
        }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n");
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
