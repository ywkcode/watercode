#pragma checksum "D:\MyPrj\2021\ESOP\代码\NetCoreFrame.WebUI\Views\FrameCharts\ChartsShow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd1895237cabb4b0c7c37e473deff22b1a2c31b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FrameCharts_ChartsShow), @"mvc.1.0.view", @"/Views/FrameCharts/ChartsShow.cshtml")]
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
#line 1 "D:\MyPrj\2021\ESOP\代码\NetCoreFrame.WebUI\Views\_ViewImports.cshtml"
using NetCoreFrame.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MyPrj\2021\ESOP\代码\NetCoreFrame.WebUI\Views\_ViewImports.cshtml"
using NetCoreFrame.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd1895237cabb4b0c7c37e473deff22b1a2c31b9", @"/Views/FrameCharts/ChartsShow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c13831c9e89f928e27b32da7307544f215310db6", @"/Views/_ViewImports.cshtml")]
    public class Views_FrameCharts_ChartsShow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NetCoreFrame.Entity.FrameEntity.Frame_Charts>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\MyPrj\2021\ESOP\代码\NetCoreFrame.WebUI\Views\FrameCharts\ChartsShow.cshtml"
  
    ViewData["Title"] = "ChartsShow";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div   style=\"margin:0 auto;margin:50px;letter-spacing:10px;text-align: center\">");
#nullable restore
#line 7 "D:\MyPrj\2021\ESOP\代码\NetCoreFrame.WebUI\Views\FrameCharts\ChartsShow.cshtml"
                                                                               Write(Model.ChartTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<table class=\"layui-table\" lay-size=\"sm\">\r\n    <colgroup>\r\n        <col width=\"150\">\r\n        <col width=\"200\">\r\n        <col>\r\n    </colgroup>\r\n    <thead>\r\n        <tr>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n    </tbody>\r\n</table>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(function () {
            Initial();
        });
        function Initial() {
              $.ajax({
                url: '/FrameCharts/ToDataTable',
                type: ""POST"",
                traditional: true,//传数组一定要加的
                data: { ""chartid"": '");
#nullable restore
#line 31 "D:\MyPrj\2021\ESOP\代码\NetCoreFrame.WebUI\Views\FrameCharts\ChartsShow.cshtml"
                               Write(ViewBag.chartid);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' },
                dataType: ""json"",
                  success: function (data) {

                    if (data.code == 200) {
                      
                        var headlist = data.data.headlist;
                        $.each(headlist, function (index, data) {
                            $("".layui-table colgroup"").append("" <col width='150'>"");
                            $("".layui-table thead tr"").append(""<td>""+data+""</td>"");
                        });

                        var datalist = data.data.datalist;
                        $.each(datalist, function (index, data) {
                            var item = ""<tr>"";
                            $.each(data, function (innerindex, innerdata) {
                                item+=""<td>""+innerdata+""</td>""
                            });
                             item+=  ""</tr>"";
                           $("".layui-table tbody"").append(item);
                        });

                    }
                }
  ");
                WriteLiteral("          });\r\n\r\n        }\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NetCoreFrame.Entity.FrameEntity.Frame_Charts> Html { get; private set; }
    }
}
#pragma warning restore 1591
