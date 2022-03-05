﻿using NetCoreFrame.Entity.FrameEntity;
using Microsoft.EntityFrameworkCore;
 
using System;
using System.Collections.Generic;
using System.Text;
 

namespace NetCoreFrame.Entity
{
    /// <summary>
    /// 上下文
    /// </summary>
    public class NetCoreFrameDBContext :  DbContext
    {
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="options"></param>
        public NetCoreFrameDBContext(DbContextOptions<NetCoreFrameDBContext> options) : base(options)
        {

        }
        /// <summary>
        /// 重载
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //全局筛选器
            modelBuilder.Entity<Frame_User>().HasQueryFilter(p => p.IsDeleted != Enum.TrueOrFlase.True);
            base.OnModelCreating(modelBuilder);
        }

        #region 框架实体表
        public DbSet<Frame_User> Frame_User { get; set; }

        public DbSet<Frame_Codes> Frame_Codes { get; set; }

        public DbSet<Frame_CodesValue> Frame_CodesValue { get; set; }

        public DbSet<Frame_Dept> Frame_Dept { get; set; }

        public DbSet<Frame_Module> Frame_Module { get; set; }

        public DbSet<Frame_ModuleElement> Frame_ModuleElement { get; set; }

        public DbSet<Frame_Relations> Frame_Relations { get; set; }

        public DbSet<Frame_Role> Frame_Role { get; set; }

        public DbSet<Frame_FileUpload> Frame_FileUpload { get; set; }

        public DbSet<Frame_TableInfo> Frame_TableInfo { get; set; }

        public DbSet<Frame_TableField> Frame_TableField { get; set; }

        public DbSet<Frame_Information> Frame_Information { get; set; }

        public DbSet<Frame_InfoHistory> Frame_InfoHistory { get; set; }

        public DbSet<Frame_InfoComments> Frame_InfoComments { get; set; }

        public DbSet<ProductionStation> ProductionStation { get; set; }
        #endregion


    }
}