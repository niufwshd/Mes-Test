﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class TfJh
 : Entity<int>    {
        
        public int Mid { get; set; }
        public string JhNo { get; set; }
        public int Itm { get; set; }
        public DateTime? JhDd { get; set; }
        public string PrdNo { get; set; }
        public string PrdMark { get; set; }
        public string PrdName { get; set; }
        public string Wh { get; set; }
        public string Unit { get; set; }
        public decimal? Qty { get; set; }
        public DateTime? EstDd { get; set; }
        public string BatNo { get; set; }
        public bool? MpClsId { get; set; }
        public string Rem { get; set; }
        public string CpySw { get; set; }
        public string IdNo { get; set; }
        public string PfNo { get; set; }
        public decimal? Qty1 { get; set; }
        public string ComposeIdno { get; set; }
        public string OsId { get; set; }
        public string OsNo { get; set; }
        public int? EstItm { get; set; }
        public string CusOsNo { get; set; }
        public int? PreItm { get; set; }
        public decimal? QtyPo { get; set; }
        public decimal? QtyPoUnsh { get; set; }
        public decimal? QtyUseWh { get; set; }
        public string SupPrdNo { get; set; }
        public decimal? QtySo { get; set; }
        public decimal? QtySoUnsh { get; set; }
        public string SupPrdMark { get; set; }
        public string MaiNo { get; set; }
        public string ClsMeId { get; set; }
        public decimal? QtyIc { get; set; }
        public decimal? QtyIcUnsh { get; set; }
        public decimal? QtyIcsq { get; set; }
        public decimal? QtyIcsqUnsh { get; set; }
        public decimal? QtySq { get; set; }
        public decimal? QtySqUnsh { get; set; }
        public string BackId { get; set; }
        public DateTime? StopDd { get; set; }
        public string StopUsr { get; set; }
        public DateTime? PlanStartDate { get; set; }
        public DateTime? PlannEndDate { get; set; }
        public string Bomno { get; set; }

        public virtual MfJh MidNavigation { get; set; }
    }
}