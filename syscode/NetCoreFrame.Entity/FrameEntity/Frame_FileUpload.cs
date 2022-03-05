using NetCoreFrame.Entity.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NetCoreFrame.Entity.FrameEntity
{
    /// <summary>
    /// 文件上传
    /// </summary>
    public class Frame_FileUpload : CoreBaseEntity
    {
        /// <summary>
        /// 文件名称
        /// </summary>
        [Display(Name = "文件名称")]
        [Description("文件名称")]
        [StringLength(100)]
        public string FileName { get; set; }

        /// <summary>
        /// 文件物理路径
        /// </summary>
        [Display(Name = "文件物理路径")]
        [Description("文件物理路径")]
        [StringLength(200)]
        public string FilePath { get; set; }

        /// <summary>
        /// 文件图片地址
        /// </summary>
        [Display(Name = "文件图片地址")]
        [Description("文件图片地址")]
        [StringLength(2000)]
        public string FileImgUrl { get; set; }

        /// <summary>
        /// 文件类别
        /// </summary>
        [Display(Name = "文件类别")]
        [Description("文件类别")]
        [StringLength(50)]
        public string FileType { get; set; }

       
    }
}
