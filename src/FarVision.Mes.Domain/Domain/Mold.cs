﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class Mold
 : Entity<int>    {
        
        public string ModNo { get; set; }
        public int ModItm { get; set; }
        public string Wh { get; set; }
        public string Purpose { get; set; }
        public decimal? LiftYear { get; set; }
        public decimal? LiftTime { get; set; }
        public decimal? LiftCrop { get; set; }
        public string UseSeb { get; set; }
        public decimal? MaintenanceTimes { get; set; }
        public decimal? RecheckTimes { get; set; }
        public decimal? WarmTime { get; set; }
        public decimal? WarmMtTime { get; set; }
        public string CusNo { get; set; }
        public string ModType { get; set; }
        public string ModStatus { get; set; }
        public string ModUseState { get; set; }
        public string ModStgState { get; set; }
        public string ModUsedtime { get; set; }
        public DateTime? LastStgTime { get; set; }
        public decimal? CycleTime { get; set; }
        public string Spc { get; set; }
        public string GraphNo { get; set; }
        public string ModQrcode { get; set; }
        public string Ut { get; set; }
        public int? UseNum { get; set; }
        public string ModId { get; set; }
        public int? WxTimes { get; set; }
        public DateTime? WxDdL { get; set; }
        public DateTime? InvalidDd { get; set; }
        public string DepUse { get; set; }
        public string SalNoBg { get; set; }
        public DateTime? OpnDd { get; set; }
        public DateTime? StopDd { get; set; }
        public string Stock { get; set; }
        public decimal? QtyCrop { get; set; }
        public decimal? QtyDay { get; set; }
        public string QtyLen { get; set; }
        public decimal? QtyCirIn { get; set; }
        public decimal? QtyCirOut { get; set; }
        public decimal? QtyCropUt { get; set; }
        public string ShowId { get; set; }
        public DateTime? GrDd { get; set; }
        public decimal? CstGr { get; set; }
        public int? UseTimes { get; set; }
        public decimal? HoursAll { get; set; }
        public string ChkQualified { get; set; }
        public DateTime? QualifiedDd { get; set; }
        public Guid? Pic { get; set; }
        public string Name { get; set; }
        public decimal? TaxRto { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Height { get; set; }
        public decimal? Width { get; set; }
        public string SpcId { get; set; }
        public decimal? UtTime { get; set; }
        public string TimeUnit { get; set; }
        public short? Lines { get; set; }
        public int? IdxNo { get; set; }
        public string FtType { get; set; }
        public short? FtMm { get; set; }
        public string Dep { get; set; }
        public string DeproNo { get; set; }
        public string Usr { get; set; }
        public string UsrName { get; set; }
        public DateTime? SysDate { get; set; }
        public DateTime? UpdDate { get; set; }
        public string UpdUsrName { get; set; }
        public string UpdUsr { get; set; }
        public string ChkMan { get; set; }
        public string ChkManName { get; set; }
        public DateTime? ChkDate { get; set; }
        public string ChkMob { get; set; }
        public bool? IsPrint { get; set; }
        public string PrdNo { get; set; }
        public DateTime? JgqtyChgdate { get; set; }
        public int? JgqtyChg { get; set; }
        public DateTime? UsetimeChgdate { get; set; }
        public int? UsetimeQtyChg { get; set; }
        public string Rem { get; set; }
        public string ModSpec { get; set; }
        public int? WarningNum { get; set; }
        public string VenderNo { get; set; }
    }
}