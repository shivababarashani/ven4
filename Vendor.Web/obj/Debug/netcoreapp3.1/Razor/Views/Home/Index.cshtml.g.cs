#pragma checksum "C:\Users\Shiva\Downloads\Vendor(1)\Vendor(1)\Vendor\Vendor\Vendor.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc13ed9f22c8d218aa696764464b6930da5ed5ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Shiva\Downloads\Vendor(1)\Vendor(1)\Vendor\Vendor\Vendor.Web\Views\_ViewImports.cshtml"
using Vendor.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shiva\Downloads\Vendor(1)\Vendor(1)\Vendor\Vendor\Vendor.Web\Views\_ViewImports.cshtml"
using Vendor.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc13ed9f22c8d218aa696764464b6930da5ed5ea", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32b89ce51ccf45b1c282b0c1f07cce8adb9c9e10", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Shiva\Downloads\Vendor(1)\Vendor(1)\Vendor\Vendor\Vendor.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "";



#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1 class=""m-0 text-dark"">داشبورد</h1>
                </div><!-- /.col -->
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-left"">
                        <li class=""breadcrumb-item""><a href=""#"">خانه</a></li>
                        <li class=""breadcrumb-item active"">داشبورد ورژن ۲</li>
                    </ol>
                </div><!-- /.col -->
            </div><!-- /.row -->
        </div><!-- /.container-fluid -->
    </div>



    <div class=""row justify-content-lg-center"">
        <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-info"">
                <div class=""inner"">
                   <h3>");
#nullable restore
#line 30 "C:\Users\Shiva\Downloads\Vendor(1)\Vendor(1)\Vendor\Vendor\Vendor.Web\Views\Home\Index.cshtml"
                  Write(ViewData["ProductCount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                    <p>تعداد محصولات</p>
                </div>
                <div class=""icon"">
                    <i class=""ion ion-bag""></i>
                </div>
                <a href=""#"" class=""small-box-footer"">اطلاعات بیشتر <i class=""fa fa-arrow-circle-left""></i></a>
            </div>
        </div>
        <!-- ./col -->
        <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-success"">
                <div class=""inner"">
                    <h3>");
#nullable restore
#line 45 "C:\Users\Shiva\Downloads\Vendor(1)\Vendor(1)\Vendor\Vendor\Vendor.Web\Views\Home\Index.cshtml"
                   Write(ViewData["VendorCount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                    <p>تعداد وندور لیست</p>
                </div>
                <div class=""icon"">
                    <i class=""ion ion-stats-bars""></i>
                </div>
                <a href=""#"" class=""small-box-footer"">اطلاعات بیشتر <i class=""fa fa-arrow-circle-left""></i></a>
            </div>
        </div>
        <!-- ./col -->
        <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-warning"">
                <div class=""inner"">
                    <h3>");
#nullable restore
#line 60 "C:\Users\Shiva\Downloads\Vendor(1)\Vendor(1)\Vendor\Vendor\Vendor.Web\Views\Home\Index.cshtml"
                   Write(ViewData["CompanyCount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                    <p>تعداد شرکت ها</p>
                </div>
                <div class=""icon"">
                    <i class=""ion ion-person-add""></i>
                </div>
                <a href=""#"" class=""small-box-footer"">اطلاعات بیشتر <i class=""fa fa-arrow-circle-left""></i></a>
            </div>
        </div>
        <!-- ./col -->
        <!--<div class=""col-lg-3 col-6"">-->
        <!-- small box -->
        <!--<div class=""small-box bg-danger"">
                <div class=""inner"">
                    <h3>۶۵</h3>

                    <p>بازدید جدید</p>
                </div>
                <div class=""icon"">
                    <i class=""ion ion-pie-graph""></i>
                </div>
                <a href=""#"" class=""small-box-footer"">اطلاعات بیشتر <i class=""fa fa-arrow-circle-left""></i></a>
            </div>
        </div>-->
        <!-- ./col -->
    </div>



");
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
