﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class WmMaterialPreparaPlanBarcode
 : Entity<int>    {
        
        public int? Mid { get; set; }
        public string ProdNo { get; set; }
        public string BatchNo { get; set; }
        public string PackageNo { get; set; }
        public decimal? Quantity { get; set; }
        public string Unit { get; set; }
        public DateTime? ProductionDate { get; set; }
        public string SourceLocation { get; set; }
        public string Status { get; set; }
        public string TargetLocation { get; set; }
        public string SourceWareHouseNo { get; set; }
        public decimal? FinishQuantity { get; set; }

        public virtual WmMaterialPreparaPlanItem MidNavigation { get; set; }
    }
}