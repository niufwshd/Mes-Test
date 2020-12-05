﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class MfPos
 : Entity<int>    {
        public MfPos()
        {
            TfPos = new HashSet<TfPos>();
        }

        
        public string OsId { get; set; }
        public string OsNo { get; set; }
        public string BatNo { get; set; }
        public DateTime? OsDd { get; set; }
        public string QtNo { get; set; }
        public string VohId { get; set; }
        public string VohNo { get; set; }
        public string TradMth { get; set; }
        public string PayMth { get; set; }
        public short? PayDays { get; set; }
        public short? ChkDays { get; set; }
        public string PayRem { get; set; }
        public string SendMth { get; set; }
        public string SendWh { get; set; }
        public DateTime? EstDd { get; set; }
        public string CusNo { get; set; }
        public string SalNo { get; set; }
        public string UseDep { get; set; }
        public string CurId { get; set; }
        public decimal? ExcRto { get; set; }
        public decimal? AmtnInt { get; set; }
        public decimal? AmtInt { get; set; }
        public decimal? DisCnt { get; set; }
        public string BackId { get; set; }
        public bool? HisPrice { get; set; }
        public string Adr { get; set; }
        public string PoDep { get; set; }
        public string PoSoNo { get; set; }
        public short? SoByMm { get; set; }
        public short? SoOtDd { get; set; }
        public short? SoByDd { get; set; }
        public string SoLngCas { get; set; }
        public DateTime? SoEndDd { get; set; }
        public DateTime? SoLstDd { get; set; }
        public string InvDisId { get; set; }
        public string InvNo { get; set; }
        public string TaxId { get; set; }
        public string RpNo { get; set; }
        public string OldInvNo { get; set; }
        public decimal? AmtnNet { get; set; }
        public decimal? Tax { get; set; }
        public DateTime? PayDd { get; set; }
        public short? IntDays { get; set; }
        public string Contract { get; set; }
        public string PrtSw { get; set; }
        public string CpySw { get; set; }
        public string BilNo { get; set; }
        public string LcNo { get; set; }
        public decimal? AmtnDis { get; set; }
        public bool? ClsMpId { get; set; }
        public string ClsRem { get; set; }
        public string BilId { get; set; }
        public bool? RkClsId { get; set; }
        public bool? PreId { get; set; }
        public string IsPos { get; set; }
        public string PosNo { get; set; }
        public string PclId { get; set; }
        public string CusOsNo { get; set; }
        public string BzNo { get; set; }
        public bool? HsId { get; set; }
        public decimal? AmtLc { get; set; }
        public string CnttNo { get; set; }
        public string SbNo { get; set; }
        public string LockMan { get; set; }
        public DateTime? LockDate { get; set; }
        public bool? Isoversh { get; set; }
        public string DjNo { get; set; }
        public short? FjNum { get; set; }
        public string CasNo { get; set; }
        public string SqId { get; set; }
        public DateTime? InvDd { get; set; }
        public int? InvYm { get; set; }
        public string TitleBuy { get; set; }
        public string MethId { get; set; }
        public decimal? AmtInv { get; set; }
        public decimal? TaxInv { get; set; }
        public decimal? Qty { get; set; }
        public string FxWh { get; set; }
        public string YhNo { get; set; }
        public string Bybox { get; set; }
        public decimal? TotQty { get; set; }
        public decimal? TotBox { get; set; }
        public int? TaskId { get; set; }
        public string PrtUsr { get; set; }
        public string RpNo1 { get; set; }
        public string SqNo { get; set; }
        public string CardNo { get; set; }
        public string SendArea { get; set; }
        public DateTime? JfendDd { get; set; }
        public string SgId { get; set; }
        public int? PrtNum { get; set; }
        public string PayNo { get; set; }
        public decimal? AmtnYjbx { get; set; }
        public decimal? AmtnBx { get; set; }
        public string Issvs { get; set; }
        public string BilMark { get; set; }
        public string ChkFx { get; set; }
        public string HasFx { get; set; }
        public decimal? AmtnCbac { get; set; }
        public string CbacCls { get; set; }
        public string InvChk { get; set; }
        public string InvUniNo { get; set; }
        public string InvTitle { get; set; }
        public decimal? InvAmt { get; set; }
        public string PayB2c { get; set; }
        public string CancelId { get; set; }
        public string SgId1 { get; set; }
        public string BilComp { get; set; }
        public decimal? RtoFqsk { get; set; }
        public string DateflagFqsk { get; set; }
        public DateTime? DateFqsk { get; set; }
        public int? QsFqsk { get; set; }
        public string CusNoPos { get; set; }
        public string InstTeam { get; set; }
        public decimal? AmtnDs { get; set; }
        public string CfmSw { get; set; }
        public string InvId { get; set; }
        public DateTime? PrtDate { get; set; }
        public string InvBilId { get; set; }
        public string InvBilNo { get; set; }
        public string OffOsNo { get; set; }
        public string InvBcodeNo { get; set; }
        public string ZhangId { get; set; }
        public decimal? AmtnCbacPs { get; set; }
        public string ActNo { get; set; }
        public string TtTypeSet { get; set; }
        public DateTime? TtYmB { get; set; }
        public string IcosId { get; set; }
        public string CntMan1 { get; set; }
        public DateTime? ModifyDd { get; set; }
        public string ModifyMan { get; set; }
        public string ClsMeId { get; set; }
        public string Mrk { get; set; }
        public string PrmNo { get; set; }
        public string CxId { get; set; }
        public string CxNo { get; set; }
        public string ChkLatest { get; set; }
        public string SrcId { get; set; }
        public string SgBilComp { get; set; }
        public string Sokp { get; set; }
        public string CusFh { get; set; }
        public string DepFh { get; set; }
        public string CusFx { get; set; }
        public decimal? AmtnHx { get; set; }
        public decimal? AmtnHxMax { get; set; }
        public string HxjsId { get; set; }
        public string ChkCache { get; set; }
        public bool? ChkFullPay { get; set; }
        public string GroupDep { get; set; }
        public bool? ChkFullPaid { get; set; }
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
        public string Rem { get; set; }
        public bool? IsClose { get; set; }
        public DateTime? ClsDate { get; set; }
        public string ClsUsr { get; set; }
        public string ClsUsrName { get; set; }
        public string ChkMob { get; set; }
        public bool? IsPrint { get; set; }

        public virtual ICollection<TfPos> TfPos { get; set; }
    }
}