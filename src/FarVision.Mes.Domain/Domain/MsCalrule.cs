﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class MsCalrule
 : Entity<int>    {
        
        public string MsType { get; set; }
        public string No { get; set; }
        public string RuleName { get; set; }
        public string Rem { get; set; }
        public string Attachment { get; set; }
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
    }
}