﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class MdmWorkCenter
 : Entity<int>    {
        
        public string No { get; set; }
        public string Name { get; set; }
        public string FactoryNo { get; set; }
        public string Usr { get; set; }
        public string UsrName { get; set; }
        public DateTime SysDate { get; set; }
        public DateTime? UpdDate { get; set; }
        public string UpdUsr { get; set; }
        public string UpdUsrName { get; set; }
        public string PullMaterialWh1 { get; set; }
        public string PullMaterialWh2 { get; set; }
        public string PullMaterialWh3 { get; set; }
        public decimal? ExceedRatio { get; set; }
        public int? MinMemberNum { get; set; }
        public decimal? ScheduleValue { get; set; }
        public decimal? ExceedQty { get; set; }
    }
}