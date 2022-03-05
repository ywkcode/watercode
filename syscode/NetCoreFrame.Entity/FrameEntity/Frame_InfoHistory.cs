using NetCoreFrame.Entity.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NetCoreFrame.Entity.FrameEntity
{
    /// <summary>
    /// 信息搜索历史
    /// </summary>
    public class Frame_InfoHistory : CoreBaseEntity
    {
        /// <summary>
        /// CWIOS用户ID
        /// </summary>
        [Display(Name = "CWIOS用户ID")]
        [Description("CWIOS用户ID")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string CUserId { get; set; }

        /// <summary>
        /// 搜索关键词
        /// </summary>
        [Display(Name = "搜索关键词")]
        [Description("搜索关键词")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string KeyWord { get; set; }
    }
}
