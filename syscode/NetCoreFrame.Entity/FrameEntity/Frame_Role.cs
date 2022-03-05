using NetCoreFrame.Entity.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NetCoreFrame.Entity.FrameEntity
{
    public class Frame_Role : CoreBaseEntity
    {
        [Display(Name = "角色名称")]
        [Description("角色名称")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string RoleName { get; set; }
    }
}
