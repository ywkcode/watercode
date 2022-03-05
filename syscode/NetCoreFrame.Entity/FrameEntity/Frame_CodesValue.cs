using NetCoreFrame.Entity.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace NetCoreFrame.Entity.FrameEntity
{
    /// <summary>
    /// 字典内容
    /// </summary>
    public class Frame_CodesValue : CoreBaseEntity
    {
        /// <summary>
        /// PID
        /// </summary>
        [Display(Name = "PID")]
        [Description("PID")] 
        public int PID { get; set; }


        /// <summary>
        /// CodeValueID
        /// </summary>

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "CodeValueID")]
        [Description("CodeValueID")]
        public int CodeValueID { get; set; }

        /// <summary>
        /// 字典名称
        /// </summary>
        [Display(Name = "字典名称")]
        [Description("字典名称")]
        [StringLength(100)]
        public string ItemName { get; set; }

        /// <summary>
        /// 字典值
        /// </summary>
        [Display(Name = "字典值")]
        [Description("字典值")]
        [StringLength(100)]
       
        public string ItemValue { get; set; }

        /// <summary>
        /// 字典名称英文
        /// </summary>
        [Display(Name = "字典名称英文")]
        [Description("字典名称英文")]
        [StringLength(100)]
        public string ItemEng { get; set; }


    }
}
