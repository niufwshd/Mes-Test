﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class Qcinterfacerecordv
 : Entity<int>    {
        public DateTime? ChkDate { get; set; }
        public int? ChkTemplate { get; set; }
        public string ChkUser { get; set; }
        public DateTime? DInputDate { get; set; }
        
        public byte? IFlag { get; set; }
        public byte? IsPrint { get; set; }
        public string LockUser { get; set; }
        public int? MeasureType { get; set; }
        public int? Mid { get; set; }
        public DateTime? PrintDate { get; set; }
        public string PrintUser { get; set; }
        public int? QcItemId { get; set; }
        public int? Sort { get; set; }
        public string SUserId { get; set; }
        public decimal? Value { get; set; }
        public decimal? ValueMax { get; set; }
        public decimal? ValueMin { get; set; }
    }
}