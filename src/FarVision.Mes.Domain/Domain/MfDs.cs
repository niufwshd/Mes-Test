﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class MfDs
 : Entity<int>    {
        public MfDs()
        {
            TfDs = new HashSet<TfDs>();
        }

        
        public string DsId { get; set; }
        public string DsNo { get; set; }
        public DateTime? DsDd { get; set; }
        public string BatNo { get; set; }
        public string Rem { get; set; }
        public string Usr { get; set; }
        public string ChkMan { get; set; }
        public string PrtSw { get; set; }
        public string CpySw { get; set; }
        public DateTime? ClsDate { get; set; }
        public string Dep { get; set; }
        public string CusNo { get; set; }
        public string CusName { get; set; }
        public decimal? ExcRto { get; set; }
        public string CurId { get; set; }
        public string SpcId { get; set; }
        public string FixCst { get; set; }
        public string SalNo { get; set; }
        public string IcNo { get; set; }
        public string BilType { get; set; }
        public string MobId { get; set; }
        public string LockMan { get; set; }
        public DateTime? LockDate { get; set; }
        public DateTime? SysDate { get; set; }
        public string BilId { get; set; }
        public string BilNo { get; set; }
        public bool? ClsId { get; set; }
        public string PrtUsr { get; set; }
        public decimal? Qty { get; set; }
        public string McId { get; set; }
        public string CancelId { get; set; }
        public DateTime? PrtDate { get; set; }
        public string InvBcodeNo { get; set; }
        public DateTime? ModifyDd { get; set; }
        public string ModifyMan { get; set; }
        public string BusiNo { get; set; }
        public string BilType1 { get; set; }
        public string BilTypeName { get; set; }
        public string Usr1 { get; set; }
        public string UsrName { get; set; }
        public DateTime? SysDate1 { get; set; }
        public DateTime? UpdDate { get; set; }
        public string UpdUsrName { get; set; }
        public string UpdUsr { get; set; }
        public string ChkMan1 { get; set; }
        public string ChkManName { get; set; }
        public DateTime? ChkDate { get; set; }
        public bool? IsClose { get; set; }
        public DateTime? ClsDate1 { get; set; }
        public string ClsUsr { get; set; }
        public string ClsUsrName { get; set; }
        public string ChkMob { get; set; }
        public bool? IsPrint { get; set; }

        public virtual ICollection<TfDs> TfDs { get; set; }
    }
}