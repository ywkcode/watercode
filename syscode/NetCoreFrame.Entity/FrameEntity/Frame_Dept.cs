 
using NetCoreFrame.Entity.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NetCoreFrame.Entity.FrameEntity
{
    /// <summary>
    /// 部门管理
    /// </summary>
    public class Frame_Dept : CoreBaseEntity
    {
        [Display(Name = "部门名称")]
        [Description("部门名称")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string DeptName { get; set; }

        [Display(Name = "部门编码")]
        [Description("部门编码")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string DeptCode { get; set; }


        [Display(Name = "部门ID")]
        [Description("部门ID")]
        public int DeptID { get; set; }

        [Display(Name = "父部门ID")]
        [Description("父部门ID")]
        public int PDeptID { get; set; }
    }
}
