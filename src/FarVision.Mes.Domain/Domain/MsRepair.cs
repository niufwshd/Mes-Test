﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class MsRepair
 : Entity<int>    {
        
        public string No { get; set; }
        public string MsNo { get; set; }
        public string MsName { get; set; }
        public string MsType { get; set; }
        public string CalResult { get; set; }
        public string MngType { get; set; }
        public string CalMode { get; set; }
        public string CalLocal { get; set; }
        public DateTime RpDate { get; set; }
        public string RpMan { get; set; }
        public string RpStatusBefore { get; set; }
        public string RpStatusAfter { get; set; }
        public string RpDepNo { get; set; }
        public string RpCalStatus { get; set; }
        public string RpInstNo { get; set; }
        public string Contacts { get; set; }
        public string Phone { get; set; }
        public DateTime? RpDoneDate { get; set; }
        public decimal? RpCost { get; set; }
        public string RpContent { get; set; }
        public string Rem { get; set; }
        public string CalNoteNo { get; set; }
        public string Usr { get; set; }
        public DateTime SysDate { get; set; }
        public string UpdUsr { get; set; }
        public DateTime? UpdDate { get; set; }
        public string ChkMan { get; set; }
        public DateTime? ChkDate { get; set; }
        public string ChkMob { get; set; }
        public bool? IsPrint { get; set; }
        public string UsrName { get; set; }
        public string UpdUsrName { get; set; }
        public string ChkManName { get; set; }
        public bool? IsToCal { get; set; }
    }
}