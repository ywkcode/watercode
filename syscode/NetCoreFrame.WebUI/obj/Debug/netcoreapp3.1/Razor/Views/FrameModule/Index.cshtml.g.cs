#pragma checksum "D:\MyPrj\2021\ESOP\代码\NetCoreFrame.WebUI\Views\FrameModule\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "027905ed168fd796daa1f3655e3880dd06c753dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FrameModule_Index), @"mvc.1.0.view", @"/Views/FrameModule/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"027905ed168fd796daa1f3655e3880dd06c753dc", @"/Views/FrameModule/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c13831c9e89f928e27b32da7307544f215310db6", @"/Views/_ViewImports.cshtml")]
    public class Views_FrameModule_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NetCoreFrame.Entity.ViewModel.SelectListViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\MyPrj\2021\ESOP\代码\NetCoreFrame.WebUI\Views\FrameModule\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n \r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "027905ed168fd796daa1f3655e3880dd06c753dc3829", async() => {
                WriteLiteral(@"

    <div class=""layui-row"">
        <div class=""layui-col-xs2"">
            <div id=""tree""></div>
        </div>
        <div class=""layui-col-xs7"">
            <script type=""text/html"" id=""toolbarDemo"">
                <div class=""layui-btn-container"">
                    <div class=""layui-btn-group"">
                        <button type=""button"" class=""layui-btn-sm layui-btn-primary"" lay-event=""btnAdd""> <i class=""layui-icon"">&#xe654;</i>新建</button>
                        <button type=""button"" class=""layui-btn-sm layui-btn-primary"" lay-event=""isAll""> <i class=""layui-icon"">&#xe642;</i>编辑</button>
                        <button type=""button"" class=""layui-btn-sm layui-btn-primary"" lay-event=""btnDel""><i class=""layui-icon"">&#xe640;</i>删除</button>
                    </div> 
                </div>
            </script>
            <table id=""mainList"" lay-filter=""mainList"" class=""layui-table""
                   lay-size=""sm""></table>
        </div>
        <div class=""layui-col-xs"">
       ");
                WriteLiteral(@"     <!--菜单列表-->
            <table class=""layui-table""
                   lay-data=""{height: 'full-40', id:'menuList',  text: { none: '单击模块列表数据行查看菜单' }}""
                   lay-filter=""menulist"" lay-size=""sm"">
                <thead>
                    <tr>
                        <th lay-data=""{checkbox:true, fixed: true}""></th>
                        <th lay-data=""{field:'IconName', width:150,templet: '#menuTpl'}"">已有菜单</th>
                    </tr>
                </thead>
            </table>
            <script type=""text/html"" id=""menuTpl"">
                <button class=""layui-btn layui-btn-xs {{ d.btnClass }} layui-btn-fluid"" alt=""{{ d.DomId }}""> <i class=""layui-icon {{ d.IconName }}""></i> {{ d.Name }}</button>
            </script>
        </div>
    </div>
    <script type=""text/html"" id=""iconTpl"">
        {{#  if( d.IconName != null && d.IconName != ''){ }}
        <i class=""layui-icon {{ d.IconName }}""></i>
        {{#  } else { }}
        {{ d.IconName }}
        {{#  } }}");
                WriteLiteral("\n    </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
        var treeData = """";
        var setedModule = """";
        function InitailDept() {
            $.ajax({
                type: 'POST',
                cache: false,
                dataType: 'json',
                url: '/FrameModule/LoadDeptTree',
                success: function (data) {
                    treeData = data.Message;
                    InitailTree();
                }
            });

        }
        function InitailTree() {
            layui.use([""tree""], function () {
                var tree = layui.tree;
                data = eval('(' + treeData + ')'); 
                tree.render({
                    elem: '#tree'
                    , data: data
                    , onlyIconControl: true  //是否仅允许节点左侧图标控制展开收缩
                    , click: function (obj) {
                        mainList({
                            DeptId: obj.data.id,
                            page: 1, limit: 1,
      ");
                WriteLiteral(@"                      ModuleCode: obj.data.treecode
                        });

                    }
                });
            });
        }
        layui.use(['layer', 'table', ""tree""], function () {
            var form = layui.form,
                layer = layui.layer,
                $ = layui.jquery;
            var Layuitable = layui.table;
            var tree = layui.tree;
            var treeSelect = layui.treeSelect;


            var columns = [

                { checkbox: true, fixed: true },
                { field: 'Name', title: '模块名称' },
                {
                    field: 'IconName', title: '图标', templet:""#iconTpl""
                },
                { field: 'ModuleId', title: '层级ID' },
                { field: 'ModuleCode', title: '模块编号' },
                { field: 'Url', title: 'Url地址' },
                { field: 'PModuleName', title: '上级模块' }
            ];
            Layuitable.render({
                // skin: 'line', //行边框风格
             ");
                WriteLiteral(@"   even: false,//开启隔行背景
                size: 'sm', //小尺寸的表格
                height: 'full-50',
                elem: '#mainList',
                page: true,
                url: '/FrameModule/All',
                toolbar: '#toolbarDemo', //开启头部工具栏，并为其绑定左侧模板
                cols: [columns]
                , response: {
                    statusCode: 200 //规定成功的状态码，默认：0
                },
                loading: true
            });

             //头工具栏事件
              Layuitable.on('toolbar(mainList)', function(obj){

                switch(obj.event){
                    case 'btnAdd':
                        Create();
                  break;
                  case 'btnDel':
                        Delete();
                  break;
                  case 'isAll':
                    layer.msg(checkStatus.isAll ? '全选': '未全选');
                  break;

                  //自定义头工具栏右侧图标 - 提示
                  case 'LAYTABLE_TIPS':
                    layer.alert('这是工具栏右侧自定义的一个");
                WriteLiteral(@"图标按钮');
                  break;
                };
              });
            //监听行单击事件（单击事件为：rowDouble）
            Layuitable.on('row(mainList)', function (obj) {

                menuList({ ModuleId: obj.data.ModuleId });
            });



            //主列表加载，可反复调用进行刷新
            var config = {};  //table的参数，如搜索key，点击tree的id
            var mainList = function (options) {
                if (options != undefined) {
                    $.extend(config, options);
                }
                Layuitable.reload('mainList', {
                    url: '/FrameModule/All',
                    where: config
                    , response: {
                        statusCode: 200 //规定成功的状态码，默认：0
                    }
                });
            };

            //加载部门树
            $.ajax({
                type: 'POST',
                cache: false,
                dataType: 'json',
                url: '/FrameModule/LoadDeptTree',
                success: function (dat");
                WriteLiteral(@"a) {
                    treeData = data.Message;
                    data = eval('(' + treeData + ')');
                    tree.render({
                        elem: '#tree'
                        , data: data
                        //, showCheckbox: true
                        , onlyIconControl: true  //是否仅允许节点左侧图标控制展开收缩
                        , click: function (obj) {
                            mainList({ ModuleCode: obj.data.treecode });

                        }
                    });
                }
            });

            //菜单列表
            var menucon = {};  //table的参数，如搜索key，点击tree的id
            var menuList = function (options) {
                if (options != undefined) {
                    $.extend(menucon, options);
                }
                Layuitable.reload('menuList', {
                    url: '/FrameModuleElement/LoadMenus',
                    where: menucon
                    , response: {
                        statusCode: 200 //规定成功的状");
                WriteLiteral(@"态码，默认：0
                    }
                });
            }

        });


        function Create() {
            index= layer.open
                ({
                    type: 2,
                    title:'新建',
                         content: '");
#nullable restore
#line 213 "D:\MyPrj\2021\ESOP\代码\NetCoreFrame.WebUI\Views\FrameModule\Index.cshtml"
                              Write(Url.Action("Create", "FrameModule"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                         area: ['700px', '500px'],
                    btnAlign: 'c',
                    //end: function () {
                    //    ShowNotice();
                    //}
                }); 
        }
        function Delete() {
         
                var table = layui.table;
                var checkStatus = table.checkStatus('mainList');
                var datas = checkStatus.data;
                var idArr = new Array();//声明数组
                for (var i in datas) {
                    idArr[i] = datas[i].ID;//得到复选框的值
                }
                $.ajax({
                    url: '/FrameModule/Delete',
                    type: ""POST"",
                    traditional: true,//传数组一定要加的
                    data: { ""ids"": idArr},
                    dataType: ""json"",
                    success: function (data) {

                        if (data.Code == 200) {
                            ShowNotice();
                        }
                    }
");
                WriteLiteral(@"                });
        }
        function Edit(id) {
             index = layer.open
                ({
                    type: 2,
                    title:'编辑',
                    content: '/FrameModule/Edit?id=' + id,
                         area: ['500px', '300px'],
                    btnAlign: 'c',
                    end: function () {
                        ShowNotice();
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
        }

        $('.layui-btn').on('click', function () {
           
            var type = $(this).data('type');
            active[type] ? active[type].call(this) : '';
        });

        //监听页面主按钮操作
        var active = {

            btnDel: function ()
            {      ");
                WriteLiteral(@"//批量删除
                
                var table = layui.table;
                var checkStatus = table.checkStatus('mainList');
                var datas = checkStatus.data;
                var idArr = new Array();//声明数组
                for (var i in datas) {
                    idArr[i] = datas[i].ID;//得到复选框的值
                }
                $.ajax({
                    url: '/FrameModule/Delete',
                    type: ""POST"",
                    traditional: true,//传数组一定要加的
                    data: { ""ids"": idArr},
                    dataType: ""json"",
                    success: function (data) {

                        if (data.Code == 200) {
                            ShowNotice();
                        }
                    }
                });
             }
            , btnAdd: function () {  //添加
                //editDlg.add();
                Create();
            }
            , btnEdit: function () {  //编辑
                var checkStatus = layui.table.c");
                WriteLiteral(@"heckStatus('mainList')
                    , data = checkStatus.data;
                if (data.length != 1) {
                    layer.msg(""请选择编辑的行，且同时只能编辑一行"");
                    return;
                }
                //editDlg.update(data[0]);
                Edit(data[0][""ID""]);
            }
            , btnMenuAdd: function () {

            }
            , search: function () {   //搜索
                mainList({ key: $('#key').val() });
            }
            , btnRefresh: function () {
                mainList();
            }
        };
        var editDlg = function () {
            var vm;
            var update = false;  //是否为更新
            var show = function (data) {
                var title = update ? ""编辑信息"" : ""添加"";
                 index = layer.open
                ({
                    type: 2,
                    title: title,
                    content: '");
#nullable restore
#line 334 "D:\MyPrj\2021\ESOP\代码\NetCoreFrame.WebUI\Views\FrameModule\Index.cshtml"
                         Write(Url.Action("Create", "FrameModule"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                    area: ['700px', '500px'],
                    btnAlign: 'c',

                });
            }
            return {
                add: function () { //弹出添加
                    update = false;
                    show({
                        Id: ''
                    });
                },
                update: function (data) { //弹出编辑框
                    update = true;
                    show(data);
                }
            };
        }();


    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NetCoreFrame.Entity.ViewModel.SelectListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
