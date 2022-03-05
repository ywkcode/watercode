using NetCoreFrame.Entity.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NetCoreFrame.Entity.FrameEntity
{
    /// <summary>
    /// 模块表
    /// </summary>
    public class Frame_Module : CoreBaseEntity
    {
        [Display(Name = "模块名称")]
        [Description("模块名称")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string Name { get; set; }

        [Display(Name = "模块Id")]
        [Description("模块Id")]
        public int ModuleId { get; set; }


        [Display(Name = "上级模块ID")]
        [Description("上级模块ID")]
        public int PModuleId { get; set; }

        [Display(Name = "模块编号")]
        [Description("模块编号")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string ModuleCode { get; set; }

        [Display(Name = "上级模块名称")]
        [Description("上级模块名称")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string PModuleName { get; set; }

        [Display(Name = "Url地址")]
        [Description("Url地址")]
        [StringLength(100, ErrorMessage = "{0}最多输入{1}个字符")]
        public string Url { get; set; }

        [Display(Name = "图标")]
        [Description("图标")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string IconName { get; set; }



    }
}
