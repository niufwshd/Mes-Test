﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class PpMoschedTemp
 : Entity<int>    {
        public int? DailyCapacity { get; set; }
        public DateTime? EndDate { get; set; }
        
        public bool? IsUrgent { get; set; }
        public string LayoutNo { get; set; }
        public int? LineCount { get; set; }
        public string LineNos { get; set; }
        public string MoNo { get; set; }
        public string ProdName { get; set; }
        public string ProdNo { get; set; }
        public string SchedInfo { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime SysDate { get; set; }
        public DateTime? UpdDate { get; set; }
        public string UpdUsr { get; set; }
        public string UpdUsrName { get; set; }
        public string Usr { get; set; }
        public string UsrName { get; set; }
        public int? Item { get; set; }
    }
}