﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class TbQuota
 : Entity<int>    {
        public string SebNo { get; set; }
        public string BanNo { get; set; }
        public DateTime? SysDate { get; set; }
        public string QuotaName { get; set; }
        public decimal? Numerator { get; set; }
        public decimal? Denominator { get; set; }
        public decimal? Rate { get; set; }
        public string SebType { get; set; }
        public DateTime? BilDd { get; set; }
        
        public int? Mid { get; set; }
        public decimal? Theorycount { get; set; }
    }
}