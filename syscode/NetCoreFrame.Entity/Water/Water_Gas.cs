using NetCoreFrame.Entity.BaseEntity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NetCoreFrame.Entity.Water
{
    /// <summary>
    /// 气体
    /// </summary>
    public class Water_Gas : CoreBaseEntity
    {
        [Display(Name = "设备Id")]
        [Description("设备Id")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string EquipId { get; set; }


        [Display(Name = "硫化氢")]
        [Description("硫化氢")]
        public decimal H2S { get; set; }

        [Display(Name = "氯化氢")]
        [Description("氯化氢")]
        public decimal HCL { get; set; }

        [Display(Name = "氯气")]
        [Description("氯气")]
        public decimal CL2 { get; set; }

        [Display(Name = "氨气")]
        [Description("氨气")]
        public decimal NH3 { get; set; }

         
    }
}
