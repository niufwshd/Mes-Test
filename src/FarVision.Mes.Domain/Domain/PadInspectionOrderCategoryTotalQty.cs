﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class PadInspectionOrderCategoryTotalQty
 : Entity<int>    {
        public string SourceType { get; set; }
        public int? PendingInspection { get; set; }
        public int? InInspection { get; set; }
        public int? HasInspection { get; set; }
    }
}