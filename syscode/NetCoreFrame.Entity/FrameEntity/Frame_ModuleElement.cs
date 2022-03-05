using NetCoreFrame.Entity.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace NetCoreFrame.Entity.FrameEntity
{
    /// <summary>
    /// 模块元素表
    /// </summary>
    public class Frame_ModuleElement : CoreBaseEntity
    {
        [Display(Name = "模块元素名称")]
        [Description("模块元素名称")]
        [StringLength(50)]
        public string Name { get; set; }

        [Display(Name = "DomId")]
        [Description("DomId")]
        [StringLength(50)]
        public string DomId { get; set; }

        [Display(Name = "执行方法")]
        [Description("执行方法")]
        [StringLength(50)]
        public string Script { get; set; }

        [Display(Name = "图标")]
        [Description("图标")]
        [StringLength(50)]
        public string IconName { get; set; }

        [Display(Name = "图标样式")]
        [Description("图标样式")]
        [StringLength(50)]
        public string BtnClass { get; set; }

        [Display(Name = "模块id")]
        [Description("模块id")]
        public int ModuleId { get; set; }
    }
}
