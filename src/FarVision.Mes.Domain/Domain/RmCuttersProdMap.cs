﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class RmCuttersProdMap
 : Entity<int>    {
        
        public string PrdNo { get; set; }
        public string PrdName { get; set; }
        public string ZcNo { get; set; }
        public string ZcName { get; set; }
        public string ZcStep { get; set; }
        public string CutterNo { get; set; }
        public string CutterName { get; set; }
        public bool? IsAvailable { get; set; }
        public string ZcGroup { get; set; }
        public string ZcType { get; set; }
        public string Usr { get; set; }
        public string UsrName { get; set; }
        public DateTime SysDate { get; set; }
        public DateTime? UpdDate { get; set; }
        public string UpdUsrName { get; set; }
        public string UpdUsr { get; set; }
    }
}