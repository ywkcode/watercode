#pragma checksum "D:\MyPrj\2021\ESOP\代码\NetCoreFrame.WebUI\Views\FrameInformation\FrameInformation_Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f436daefdac48c74a0b68a8aef1c67aee44ab5d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FrameInformation_FrameInformation_Index), @"mvc.1.0.view", @"/Views/FrameInformation/FrameInformation_Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f436daefdac48c74a0b68a8aef1c67aee44ab5d9", @"/Views/FrameInformation/FrameInformation_Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c13831c9e89f928e27b32da7307544f215310db6", @"/Views/_ViewImports.cshtml")]
    public class Views_FrameInformation_FrameInformation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "CreateTime", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::NetCoreFrame.WebUI.TagHelpers.DateTimeTagHelper __NetCoreFrame_WebUI_TagHelpers_DateTimeTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\MyPrj\2021\ESOP\代码\NetCoreFrame.WebUI\Views\FrameInformation\FrameInformation_Index.cshtml"
  
    ViewData["Title"] = "FrameInformation_Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@" 
<style type=""text/css"">
    .layui-colla-title {
        position: relative;
        height: 30px;
        line-height: 30px;
        padding: 0 15px 0 35px;
        color: white;
        background-color: #1AA094;
        cursor: pointer;
        font-size: 14px;
        overflow: hidden;
    }

    .layui-colla-content {
        border-color: #1AA094;
        padding: 5px;
    }

    .layui-form-label {
        padding: 8px 10px;
        width: 60px;
    }

    .layui-input, .layui-select, .layui-textarea {
        height: 30px;
    }

    .layui-collapse {
        border-radius: 11px;
        margin-bottom: 7px;
    }
</style>
<div class=""layui-collapse"">
    <div class=""layui-colla-item"">
        <h2 class=""layui-colla-title"">搜索条件</h2>
        <div class=""layui-colla-content layui-show"">
            <div class=""layui-input-inline"">
                <label class=""layui-form-label"">标题</label>
                <div class=""layui-input-inline"">
                    <input");
            WriteLiteral(@" type=""text"" name=""FileTitle"" id=""FileTitle"" placeholder=""文件标题"" autocomplete=""off"" class=""layui-input"">
                </div>
                <div class=""layui-inline"">
                    <label class=""layui-form-label"">发布日期</label>
                    <div class=""layui-input-inline"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form:DateTime", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f436daefdac48c74a0b68a8aef1c67aee44ab5d95821", async() => {
            }
            );
            __NetCoreFrame_WebUI_TagHelpers_DateTimeTagHelper = CreateTagHelper<global::NetCoreFrame.WebUI.TagHelpers.DateTimeTagHelper>();
            __tagHelperExecutionContext.Add(__NetCoreFrame_WebUI_TagHelpers_DateTimeTagHelper);
            __NetCoreFrame_WebUI_TagHelpers_DateTimeTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 51 "D:\MyPrj\2021\ESOP\代码\NetCoreFrame.WebUI\Views\FrameInformation\FrameInformation_Index.cshtml"
__NetCoreFrame_WebUI_TagHelpers_DateTimeTagHelper.IsNow = false;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("is-now", __NetCoreFrame_WebUI_TagHelpers_DateTimeTagHelper.IsNow, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f436daefdac48c74a0b68a8aef1c67aee44ab5d97517", async() => {
                WriteLiteral(@"
    <div class=""layui-row"">
        <script type=""text/html"" id=""toolbar"">
            <div class=""layui-btn-group"">
                <button type=""button"" class=""layui-btn layui-btn-primary"" lay-event=""btnSearch""> <i class=""layui-icon"">&#xe615;</i>查询</button>
                <button type=""button"" class=""layui-btn layui-btn-primary"" lay-event=""btnAdd""> <i class=""layui-icon"">&#xe654;</i>新建</button>
                <button type=""button"" class=""layui-btn layui-btn-primary"" lay-event=""btnEdit""> <i class=""layui-icon"">&#xe642;</i>编辑</button>
                <button type=""button"" class=""layui-btn layui-btn-primary"" lay-event=""btnDel""><i class=""layui-icon"">&#xe640;</i>删除</button>
                <button type=""button"" class=""layui-btn layui-btn-primary"" lay-event=""btnPush""><i class=""layui-icon"">&#xe640;</i>公告推送</button>
            </div>
        </script>
        <table id=""mainList"" lay-filter=""mainList"" class=""layui-table"" lay-size=""sm""></table>
    </div>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script type=""text/javascript"">
        var index;
        layui.use(['layer', 'table', ""tree""], function ()
        {
            var form = layui.form,
                layer = layui.layer,
                $ = layui.jquery;
            var  Layuitable = layui.table;
            var columns = [
                { checkbox: true, fixed: true },
                { field: 'Index', title: '序号', width: 60, templet: '#Index' },
                { field: 'CategoryName', title: '栏目类别', width: 120 },
                { field: 'FileTitle', title: '文件标题' },
                { field: 'FileContent', title: '文件内容' }, 
                { field: 'CreateBy', title: '发布人', width: 120 },
                { field: 'CreateTime', title: '发布日期', width: 120 },
                {
                    field: 'DataStatus', title: '是否发布', width: 80, templet: function (data)
                    {
                        return data.IsPush == true ? ""是"" : ""否"";
                    }
                },
            ];
 ");
                WriteLiteral(@"           Layuitable.render({
                even: false,//开启隔行背景
                size: 'sm', //小尺寸的表格
                height: 'full-50',
                elem: '#mainList',
                page: true,
				toolbar: '#toolbar', //开启头部工具栏，并为其绑定左侧模板
                url: '/FrameInformation/All',
			    limits: [15,20,25],
                limit: 20 , //每页默认显示的数量
                cols: [columns] ,
                response: {
                    statusCode: 200 //规定成功的状态码，默认：0
                },
                loading: true
            });
			 //头工具栏事件
            Layuitable.on('toolbar(mainList)', function(obj){
                    var table = layui.table;
                    var checkStatus = table.checkStatus('mainList');
                    var datas = checkStatus.data;
                    var id = new Array();//声明数组
                    for (var i in datas) {
                        id[i] = datas[i].ID;//得到复选框的值
                    }
                  switch(obj.event){
               ");
                WriteLiteral(@"     case 'btnAdd':
                        Create();
                  break;
                  case 'btnDel':
                        Delete(id);
                  break;
                  case 'btnEdit':
                        Edit(datas[0][""ID""]);
                   break;
                      case 'btnPush':
                          Push(id); 
                          break;
                };
              });
            //主列表加载，可反复调用进行刷新
            var config = {};  //table的参数，如搜索key，点击tree的id
            var refreshList = function (options) {
                if (options != undefined) {
                    $.extend(config, options);
                }
                Layuitable.reload('mainList', {
                    url: '/FrameInformation/All',
                    where: config
                    , response: {
                        statusCode: 200 //规定成功的状态码，默认：0
                    }
                });
            };



        });
        function Create() ");
                WriteLiteral("{\r\n              index = layer.open\r\n                ({\r\n                    type: 2,\r\n                    title:\'新建\',\r\n                    content: \'");
#nullable restore
#line 164 "D:\MyPrj\2021\ESOP\代码\NetCoreFrame.WebUI\Views\FrameInformation\FrameInformation_Index.cshtml"
                         Write(Url.Action("FrameInformation_Create", "FrameInformation"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                    area: ['1210px', '700px'],
                    btnAlign: 'c',
                    //窗口关闭执行
                    end: function () {
                        //回调业务
                        debugger;
                       location.reload();
                    }
                });
        }

         function Delete(id) {
               $.ajax({
                        url: '/FrameInformation/Delete',
                        type: ""POST"",
                        traditional: true,//传数组一定要加的
                        data: { ""ids"": id},
                        dataType: ""json"",
                        success: function (data) {
                            if (data.Code == 200) {
                                ShowNotice();
                            }
                        }
                    });
        }
        function Push(id) {
            $.ajax({
                url: '/FrameInformation/Push',
                type: ""POST"",
                traditional");
                WriteLiteral(@": true,//传数组一定要加的
                data: { ""ids"": id },
                dataType: ""json"",
                success: function (data) {
                    if (data.Code == 200) {
                        ShowNotice();
                    }
                }
            });
        }
        function Edit(id) {
             index = layer.open
                ({
                    type: 2,
                    title:'编辑',
                    content: '");
#nullable restore
#line 209 "D:\MyPrj\2021\ESOP\代码\NetCoreFrame.WebUI\Views\FrameInformation\FrameInformation_Index.cshtml"
                         Write(Url.Action("FrameInformation_Edit", "FrameInformation"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"?Id=' + id,
                    area: ['1210px', '700px'],
                    btnAlign: 'c',
                    end: function () {
                        //回调业务
                        location.reload();
                    }
                });
        }

        function ShowNotice() {
            var noticeIndex = layer.load(1, {
                shade: [0.1, '#fff'] //0.1透明度的白色背景
            });
            layer.msg(""操作成功"");
            layer.close(noticeIndex);
            location.reload();//弹出层结束后，刷新主页面

            //var index = parent.layer.getFrameIndex(window.name); //先得到当前iframe层的索引
            //parent.layer.close(index); //再执行关闭
        }



    </script>

    <script type=""text/html"" id=""Index"">
        {{d.LAY_TABLE_INDEX+1}}
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
