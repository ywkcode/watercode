using NetCoreFrame.Entity.BaseEntity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace NetCoreFrame.Entity.Water
{
    /// <summary>
    /// 水质
    /// </summary>
    public class Water_Quality : CoreBaseEntity
    {
        [Display(Name = "设备Id")]
        [Description("设备Id")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string EquipId { get; set; }


        [Display(Name = "Toc")]
        [Description("Toc")]
        public decimal TOC { get; set; }

        [Display(Name = "氨氯")]
        [Description("氨氯")]
        public decimal AD { get; set; }

        [Display(Name = "总磷")]
        [Description("总磷")]
        public decimal ZL { get; set; }

        [Display(Name = "PH")]
        [Description("PH")]
        public decimal PH { get; set; }

        [Display(Name = "流量")]
        [Description("流量")]
        public decimal LL { get; set; }


    }
}
