using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NetCoreFrame.Entity.Enum;

namespace NetCoreFrame.Entity.BaseEntity
{
    /// <summary>
    /// 核心实体表
    /// </summary>
    public class CoreBaseEntity:TopBaseEntity
    {

        /// <summary>
        /// 构造函数
        /// </summary>
        public CoreBaseEntity()
        {
            ID = Guid.NewGuid().ToString();
            //CreateTime = DateTime.Now;
            IsDeleted = TrueOrFlase.Flase;
            Sort = 0;
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Display(Name = "创建时间")]
        [Description("创建时间")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? CreateTime { get; set; } = DateTime.Now;

        /// <summary>
        /// 创建人
        /// </summary>
        [Display(Name = "创建人")]
        [Description("创建人")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string CreateBy { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [Display(Name = "修改时间")]
        [Description("修改时间")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdateTime { get; set; } = DateTime.Now;

        /// <summary>
        /// 修改人
        /// </summary>
        [Display(Name = "修改人")]
        [Description("修改人")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string UpdateBy { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [Display(Name = "排序")]
        [Description("排序")]
        public int Sort { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [Display(Name = "状态")]
        [Description("状态")]
        [StringLength(50)]
        public string Status { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        [Display(Name = "是否删除")]
        [Description("是否删除")]
        public TrueOrFlase IsDeleted { get; set; }
    }
}
