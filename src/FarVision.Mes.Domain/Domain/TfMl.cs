﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class TfMl
 : Entity<int>    {
        
        public int Mid { get; set; }
        public string Mlid { get; set; }
        public string MlNo { get; set; }
        public int? Itm { get; set; }
        public DateTime? MlDd { get; set; }
        public string MlId1 { get; set; }
        public string PrdNo { get; set; }
        public string PrdName { get; set; }
        public string PrdMark { get; set; }
        public string Unit { get; set; }
        public decimal? Qty { get; set; }
        public string Wh { get; set; }
        public string Rem { get; set; }
        public string BatNo { get; set; }
        public string MoNo { get; set; }
        public string TzNo { get; set; }
        public string BilNo { get; set; }
        public int? BilItm { get; set; }
        public string ZcNo { get; set; }
        public string IdNo { get; set; }
        public int? EstItm { get; set; }
        public decimal? QtyStd { get; set; }
        public string ZcPrd { get; set; }
        public decimal? QtyLeft { get; set; }
        public decimal? QtyOver { get; set; }
        public DateTime? RkDd { get; set; }
        public DateTime? ValidDd { get; set; }
        public decimal? QtyRtn { get; set; }
        public decimal? QtyQlGg { get; set; }
        public string QlNo { get; set; }
        public decimal? QtyMl { get; set; }
        public decimal? QtyWh { get; set; }
        public decimal? QtyRsv { get; set; }
        public DateTime? ScDd { get; set; }
        public int? PreItm { get; set; }
        public decimal? BeginningofPeriod { get; set; }
        public string IsLock { get; set; }

        public virtual MfMl MidNavigation { get; set; }
    }
}