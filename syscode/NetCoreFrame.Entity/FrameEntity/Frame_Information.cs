using NetCoreFrame.Entity.BaseEntity;
using NetCoreFrame.Entity.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace NetCoreFrame.Entity.FrameEntity
{
    /// <summary>
    /// Frame_Information
    /// </summary>
    public class Frame_Information : CoreBaseEntity
    {
        /// <summary>
        /// 附件ID
        /// </summary>
        [Display(Name = "附件ID")]
        [Description("附件ID")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string AttachID { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [Display(Name = "文件类型")]
        [Description("文件类型")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string FileType { get; set; }


        /// <summary>
        /// 下载量
        /// </summary>
        [Display(Name = "下载量")]
        [Description("下载量")]
        public int DownloadCount { get; set; }


        /// <summary>
        /// 播放次数
        /// </summary>
        [Display(Name = "播放次数")]
        [Description("播放次数")]
        [StringLength(0, ErrorMessage = "{0}最多输入{1}个字符")]
        public int BoardCount { get; set; }


        /// <summary>
        /// 文件内容
        /// </summary>
        [Display(Name = "文件内容")]
        [Description("文件内容")]
        [StringLength(5000, ErrorMessage = "{0}最多输入{1}个字符")]
        public string FileContent { get; set; }


        /// <summary>
        /// 文件内容英文
        /// </summary>
        [Display(Name = "文件内容英文")]
        [Description("文件内容英文")]
        [StringLength(5000, ErrorMessage = "{0}最多输入{1}个字符")]
        public string FileContentEn { get; set; }

        /// <summary>
        /// 文件标题
        /// </summary>
        [Display(Name = "文件标题")]
        [Description("文件标题")]
        [StringLength(100, ErrorMessage = "{0}最多输入{1}个字符")]
        public string FileTitle { get; set; }

        /// <summary>
        /// 文件标题英文
        /// </summary>
        [Display(Name = "文件标题英文")]
        [Description("文件标题英文")]
        [StringLength(100, ErrorMessage = "{0}最多输入{1}个字符")]
        public string FileTitleEn { get; set; }

        /// <summary>
        /// 封面图ID
        /// </summary>
        [Display(Name = "封面图ID")]
        [Description("封面图ID")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string ImgAttachID { get; set; }
        /// <summary>
        /// 视频时长（秒）
        /// </summary>
        [Display(Name = "视频时长")]
        [Description("视频时长")]
        public int VideoLength { get; set; }

        /// <summary>
        /// 视频时长Str
        /// </summary>
        [Display(Name = "视频时长Str")]
        [Description("视频时长Str")]
        public string VideoMinLength { get; set; } = "00:00:00";

        /// <summary>
        /// 栏目名称
        /// </summary>
        [Display(Name = "栏目名称")]
        [Description("栏目名称")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 栏目编号
        /// </summary>
        [Display(Name = "栏目编号")]
        [Description("栏目编号")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 点赞次数
        /// </summary>
        [Display(Name = "点赞次数")]
        [Description("点赞次数")]
        public int RegardCount { get; set; }


        /// <summary>
        /// 转发次数
        /// </summary>
        [Display(Name = "转发次数")]
        [Description("转发次数")]
        public int RelayCount { get; set; }

        /// <summary>
        /// 评论次数
        /// </summary>
        [Display(Name = "评论次数")]
        [Description("评论次数")]
        public int CommentCount { get; set; }


        /// <summary>
        /// 结束日期
        /// </summary>
        [Display(Name = "结束日期")]
        [Description("结束日期")] 
        public DateTime? EndDate { get; set; } = DateTime.Now;

        /// <summary>
        /// 数据状态
        /// </summary>
        public DataStatus DataStatus { get; set; } = DataStatus.Save;

        /// <summary>
        /// 是否推送
        /// </summary>
        public bool IsPush { get; set; } = false;

    }
}
