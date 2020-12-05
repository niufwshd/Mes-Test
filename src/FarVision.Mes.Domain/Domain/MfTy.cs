﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class MfTy
 : Entity<int>    {
        public MfTy()
        {
            TfTy = new HashSet<TfTy>();
        }

        
        public string TyId { get; set; }
        public string TyNo { get; set; }
        public DateTime? TyDd { get; set; }
        public string SalNo { get; set; }
        public string CusNo { get; set; }
        public string TiNo { get; set; }
        public string TbNo { get; set; }
        public string PrjType { get; set; }
        public string PfaNo { get; set; }
        public Guid? PhotoZc { get; set; }
        public string PreClsId { get; set; }
        public string PrdList { get; set; }
        public string BilNo { get; set; }
        public string BilId { get; set; }
        public string Olefield { get; set; }
        public string Dep { get; set; }
        public string CusOsNo { get; set; }
        public string Barcode { get; set; }
        public string TiId { get; set; }
        public string FxWh { get; set; }
        public bool? ClsIdOk { get; set; }
        public bool? ClsIdLost { get; set; }
        public string VohId { get; set; }
        public string VohNo { get; set; }
        public string ZhangId { get; set; }
        public string TaxId { get; set; }
        public string ArpNo { get; set; }
        public string CurId { get; set; }
        public decimal? ExcRto { get; set; }
        public string CnttNo { get; set; }
        public string ChkKnd { get; set; }
        public string ChkResult { get; set; }
        public string CancelId { get; set; }
        public DateTime? PrtDate { get; set; }
        public string ScanId { get; set; }
        public string ScanUsr { get; set; }
        public DateTime? ScanDate { get; set; }
        public string Rem { get; set; }
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
        public string PrdNo { get; set; }
        public string PrjNo { get; set; }
        public decimal? Qty { get; set; }
        public decimal? QtyActChk { get; set; }
        public decimal? QtyOk { get; set; }
        public decimal? QtyLost { get; set; }
        public decimal? QtyScrap { get; set; }
        public string QcReport { get; set; }
        public string TzNo { get; set; }
        public bool? IsQualified { get; set; }
        public string PrjFeature { get; set; }

        public virtual ICollection<TfTy> TfTy { get; set; }
    }
}