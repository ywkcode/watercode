using NetCoreFrame.Entity.BaseEntity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NetCoreFrame.Entity.Water
{
    /// <summary>
    /// 设备信息
    /// </summary>
    public class Water_Equipment : CoreBaseEntity
    {
        [Display(Name = "设备Id")]
        [Description("设备Id")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string EquipId { get; set; }

        [Display(Name = "设备名称")]
        [Description("设备名称")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string Name { get; set; }
    }
}
