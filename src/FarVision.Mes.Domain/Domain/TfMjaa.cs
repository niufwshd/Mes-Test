﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class TfMjaa
 : Entity<int>    {
        
        public int Mid { get; set; }
        public string AaNo { get; set; }
        public int Itm { get; set; }
        public DateTime? AaDd { get; set; }
        public string BilId { get; set; }
        public string BilNo { get; set; }
        public short? TiItm { get; set; }
        public string Wh { get; set; }
        public string DepUse { get; set; }
        public string SalNoBg { get; set; }
        public string ModNo { get; set; }
        public int? ItmMj { get; set; }
        public string Name { get; set; }
        public string Ut { get; set; }
        public decimal? Cst { get; set; }
        public string StateId { get; set; }
        public string ModId { get; set; }
        public int? PreItm { get; set; }
        public string IsUse { get; set; }
        public string Spc { get; set; }
        public string Rem { get; set; }
        public string FtType { get; set; }
        public short? FtMm { get; set; }
        public int? UseTimes { get; set; }
        public int? UseNum { get; set; }
        public decimal? QtyCrop { get; set; }
        public decimal? HoursAll { get; set; }
        public int? WxTimes { get; set; }

        public virtual MfMjaa MidNavigation { get; set; }
    }
}