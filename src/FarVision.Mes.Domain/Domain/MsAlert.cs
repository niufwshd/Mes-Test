﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class MsAlert
 : Entity<int>    {
        
        public int Pid { get; set; }
        public int SortIndex { get; set; }
        public string ItemName { get; set; }
        public string ItemCountSql { get; set; }
        public string Qrysql { get; set; }
        public int? AheadQty { get; set; }
        public string AheadType { get; set; }
        public bool IsSysProtect { get; set; }
        public string DataBusiNo { get; set; }
        public string Fields { get; set; }
        public string FieldsName { get; set; }
        public string QuryField { get; set; }
        public string QuryFieldName { get; set; }
        public string RpCalStatus { get; set; }
        public string RpCalStatusName { get; set; }
        public string Usr { get; set; }
        public string UsrName { get; set; }
        public DateTime SysDate { get; set; }
        public string UpdUsr { get; set; }
        public string UpdUsrName { get; set; }
        public DateTime? UpdDate { get; set; }
        public string ChkMan { get; set; }
        public string ChkManName { get; set; }
        public DateTime? ChkDate { get; set; }
        public string ChkMob { get; set; }
        public bool? IsPrint { get; set; }
    }
}