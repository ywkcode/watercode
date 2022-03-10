﻿using NetCoreFrame.Entity.BaseEntity;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NetCoreFrame.Entity.Water
{
    /// <summary>
    /// 气体
    /// </summary>
    public class Water_Gas  
    {
        [StringLength(50)]
        public string ID { get; set; } = Guid.NewGuid().ToString();


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

        [Display(Name = "创建日期")]
        public DateTime CreateTime { get; set; }
    }
}
