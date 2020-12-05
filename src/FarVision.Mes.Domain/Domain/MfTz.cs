﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class MfTz
 : Entity<int>    {
        public MfTz()
        {
            TfTz = new HashSet<TfTz>();
        }

        
        public string TzNo { get; set; }
        public DateTime TzDd { get; set; }
        public string MoNo { get; set; }
        public string MrpNo { get; set; }
        public string PrdMark { get; set; }
        public string Unit { get; set; }
        public decimal? Qty { get; set; }
        public string ZcNo { get; set; }
        public DateTime? StaDd { get; set; }
        public DateTime? EndDd { get; set; }
        public string DepUp { get; set; }
        public string DepDown { get; set; }
        public decimal? QtyFin { get; set; }
        public string BilId { get; set; }
        public string BilNo { get; set; }
        public string Dep { get; set; }
        public string BatNo { get; set; }
        public string SoNo { get; set; }
        public decimal? QtyMl { get; set; }
        public DateTime? OpnDd { get; set; }
        public DateTime? FinDd { get; set; }
        public string HeatNum { get; set; }
        public string MlOk { get; set; }
        public string MdNo { get; set; }
        public int? ZcItm { get; set; }
        public string ChkId { get; set; }
        public string MvId { get; set; }
        public decimal? QtyPrc { get; set; }
        public decimal? QtyChk { get; set; }
        public decimal? QtyMv { get; set; }
        public decimal? QtyLost { get; set; }
        public string ZcNoUp { get; set; }
        public string ZcNoDn { get; set; }
        public string IdNo { get; set; }
        public decimal? QtyRk { get; set; }
        public decimal? CstMake { get; set; }
        public decimal? CstPrd { get; set; }
        public decimal? CstOut { get; set; }
        public decimal? CstMan { get; set; }
        public decimal? UsedTime { get; set; }
        public decimal? Cst { get; set; }
        public decimal? TimeCnt { get; set; }
        public decimal? Qty1 { get; set; }
        public int? EstItm { get; set; }
        public int? PcItm { get; set; }
        public string SebNo { get; set; }
        public string GrpNo { get; set; }
        public DateTime? OutDdMoj { get; set; }
        public string SalNo { get; set; }
        public int? TaskId { get; set; }
        public string CusOsNo { get; set; }
        public bool? Chkqcsj { get; set; }
        public decimal? QtyLostSzc { get; set; }
        public decimal? QtyQs { get; set; }
        public decimal? QtyQsUnsh { get; set; }
        public bool? MlFin { get; set; }
        public string ZtId { get; set; }
        public DateTime? ZtDd { get; set; }
        public decimal? QtyChkUnsh { get; set; }
        public string TzState { get; set; }
        public string BusiNo { get; set; }
        public string BilType { get; set; }
        public string BilTypeName { get; set; }
        public string Usr { get; set; }
        public string UsrName { get; set; }
        public DateTime? SysDate { get; set; }
        public DateTime? UpdDate { get; set; }
        public string UpdUsrName { get; set; }
        public string UpdUsr { get; set; }
        public string ChkMan { get; set; }
        public string ChkManName { get; set; }
        public DateTime? ChkDate { get; set; }
        public bool? IsClose { get; set; }
        public DateTime? ClsDate { get; set; }
        public string ClsUsr { get; set; }
        public string ClsUsrName { get; set; }
        public string ChkMob { get; set; }
        public bool? IsPrint { get; set; }
        public bool? GpId { get; set; }
        public decimal? QtyScrap { get; set; }
        public string PcBan { get; set; }
        public string Rem { get; set; }
        public string Rrem { get; set; }

        public virtual ICollection<TfTz> TfTz { get; set; }
    }
}