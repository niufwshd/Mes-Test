﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class SysFile
 : Entity<int>    {
        
        public string FileName { get; set; }
        public string FileSize { get; set; }
        public DateTime UploadTime { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? LastEditTime { get; set; }
        public string Remark { get; set; }
        public byte[] FileBytes { get; set; }
        public string Userno { get; set; }
        public string FilePath { get; set; }
        public string SrcBusiNo { get; set; }
    }
}