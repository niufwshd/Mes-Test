﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class ShDj
 : Entity<int>    {
        
        public string BusiNo { get; set; }
        public string BilNo { get; set; }
        public int BilItm { get; set; }
        public DateTime? BillDate { get; set; }
        public string Yn { get; set; }
        public string Dep { get; set; }
        public string UsrMake { get; set; }
        public string UsrCheck { get; set; }
        public string UsrCheckMain { get; set; }
        public string UsrClose { get; set; }
        public string Rem { get; set; }
        public string PreChkMan { get; set; }
        public string ChkMob { get; set; }
        public string OtId { get; set; }
        public string OtNo { get; set; }
        public string UsrN { get; set; }
        public DateTime? ShDd { get; set; }
        public string Othusr { get; set; }
        public int? ShItm { get; set; }
        public int? PreShItm { get; set; }
        public int? PrePreShItm { get; set; }
        public string UsrRejigger { get; set; }
        public DateTime? StartDd { get; set; }
        public DateTime? ChkDd { get; set; }
        public DateTime? LastDd { get; set; }
        public string OtId2 { get; set; }
        public string OtNo2 { get; set; }
        public string CusNo { get; set; }
        public string DepBil { get; set; }
        public string BilType { get; set; }
        public string SalNo { get; set; }
        public string CusOsNo { get; set; }
        public string BatNo { get; set; }
        public string EipSts { get; set; }
        public string DtshSw { get; set; }
        public string DtshNo { get; set; }
        public string VerNo { get; set; }
        public string NotReturn { get; set; }
        public DateTime? SysDate { get; set; }
        public string TypeNo { get; set; }
        public string Unsubmit { get; set; }
        public bool? IsRemodify { get; set; }
        public string RemBil { get; set; }
        public string BilNoFieldName { get; set; }
    }
}