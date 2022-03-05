using NetCoreFrame.Entity.BaseEntity;
using NetCoreFrame.Entity.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace NetCoreFrame.Entity.FrameEntity
{
    /// <summary>
    /// 关系表
    /// </summary>
    public class Frame_Relations : CoreBaseEntity
    {
        [Display(Name = "关系类型")]
        [Description("关系类型")] 
        public RelationType RelationType { get; set; }

        [Display(Name = "一级Id")]
        [Description("一级Id")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string FirstId { get; set; }


        [Display(Name = "二级Id")]
        [Description("二级Id")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string SecondId { get; set; }

        [Display(Name = "三级Id")]
        [Description("三级Id")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string ThirdId { get; set; }
    }
}
