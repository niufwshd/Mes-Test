﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class VMaterialPreparaPlanDetail
 : Entity<int>    {
        
        public int? Mid { get; set; }
        public string WoNo { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? NeedPickMaterialTime { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string WkCenterNo { get; set; }
        public string WkCenterName { get; set; }
        public int? WorkOrder { get; set; }
        public string AddInfo { get; set; }
        public string MprodNo { get; set; }
        public string MprodName { get; set; }
        public string MprodSpc { get; set; }
        public string ProdNo { get; set; }
        public string ProdName { get; set; }
        public string ProdSpc { get; set; }
        public decimal? PlanQuantity { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Unquantity { get; set; }
    }
}