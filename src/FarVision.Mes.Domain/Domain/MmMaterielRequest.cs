﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class MmMaterielRequest
 : Entity<int>    {
        
        public string StationNo { get; set; }
        public string WkCenterNo { get; set; }
        public string ProcessNo { get; set; }
        public string ProdNo { get; set; }
        public decimal PlanQuantity { get; set; }
        public decimal RequestQuantity { get; set; }
        public decimal? SendQuantity { get; set; }
        public decimal? ReceiveQuantity { get; set; }
        public string Unit { get; set; }
        public string TargetWh { get; set; }
        public string SourceWh { get; set; }
        public string SourceNo { get; set; }
        public string TransferNo { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime? LatestDate { get; set; }
        public bool? IsPlan { get; set; }
        public string Status { get; set; }
        public bool? IsCall { get; set; }
        public string Supplier { get; set; }
        public string CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Type { get; set; }
    }
}