﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class QcPrdMeasureRecordItem
 : Entity<int>    {
        public long Id { get; set; }
        public long Mid { get; set; }
        public string Dimension { get; set; }
        public string Description { get; set; }
        public string Axis { get; set; }
        public decimal? Meas { get; set; }
    }
}