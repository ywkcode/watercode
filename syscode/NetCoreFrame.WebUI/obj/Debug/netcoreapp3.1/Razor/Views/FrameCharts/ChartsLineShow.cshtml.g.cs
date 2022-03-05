#pragma checksum "D:\MyPrj\2021\ESOP\代码\NetCoreFrame.WebUI\Views\FrameCharts\ChartsLineShow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c84c915432d6979195fb56b3e3f7dee855de961"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FrameCharts_ChartsLineShow), @"mvc.1.0.view", @"/Views/FrameCharts/ChartsLineShow.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c84c915432d6979195fb56b3e3f7dee855de961", @"/Views/FrameCharts/ChartsLineShow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c13831c9e89f928e27b32da7307544f215310db6", @"/Views/_ViewImports.cshtml")]
    public class Views_FrameCharts_ChartsLineShow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NetCoreFrame.Entity.FrameEntity.Frame_Charts>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\MyPrj\2021\ESOP\代码\NetCoreFrame.WebUI\Views\FrameCharts\ChartsLineShow.cshtml"
  
    ViewData["Title"] = "ChartsLineShow";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"main\" style=\"width: 600px;height:400px;margin:0 auto;margin-top:50px\"></div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.staticfile.org/echarts/4.3.0/echarts.min.js""></script>
    <script type=""text/javascript"">
        $(function () {
            Initial();
        });
        function Initial() {
              $.ajax({
                url: '/FrameCharts/PieChart',
                type: ""POST"",
                traditional: true,//传数组一定要加的
                data: { ""chartid"": '");
#nullable restore
#line 19 "D:\MyPrj\2021\ESOP\代码\NetCoreFrame.WebUI\Views\FrameCharts\ChartsLineShow.cshtml"
                               Write(ViewBag.chartid);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' },
                dataType: ""json"",
                  success: function (data) { 
                    if (data.code == 200) { 
                        var headlist = data.data.headlist; 
                        var datalist = data.data.datalist;
                        LoadChart(headlist, datalist); 
                    }
                }
            }); 
        }
    </script>
    <script type=""text/javascript"">
        function LoadChart(headlist,datalist) {
            // 基于准备好的dom，初始化echarts实例
            var myChart = echarts.init(document.getElementById('main'));

            myChart.setOption({
                title: {
                    text: '");
#nullable restore
#line 38 "D:\MyPrj\2021\ESOP\代码\NetCoreFrame.WebUI\Views\FrameCharts\ChartsLineShow.cshtml"
                      Write(Model.ChartTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                    subtext: ' ',
                    left: 'center'
                },
                tooltip: {
                    trigger: 'item',
                    formatter: '{a} <br/>{b} : {c} ({d}%)'
                },
                legend: {
                    orient: 'vertical',
                    left: 'left',
                    data: headlist
                },
                series: [
                    {
                        name: '");
#nullable restore
#line 53 "D:\MyPrj\2021\ESOP\代码\NetCoreFrame.WebUI\Views\FrameCharts\ChartsLineShow.cshtml"
                          Write(Model.ChartTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                        type: 'pie',
                        radius: '55%',
                        center: ['50%', '60%'],
                        data: datalist,
                        emphasis: {
                            itemStyle: {
                                shadowBlur: 10,
                                shadowOffsetX: 0,
                                shadowColor: 'rgba(0, 0, 0, 0.5)'
                            }
                        }
                    }
                ]
            })
        }


    </script>
");
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
