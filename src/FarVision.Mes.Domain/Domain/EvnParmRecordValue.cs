﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class EvnParmRecordValue
 : Entity<int>    {
        
        public int? Mid { get; set; }
        public string EvnNo { get; set; }
        public string EvnName { get; set; }
        public decimal? NumMax { get; set; }
        public decimal? NumMin { get; set; }
        public string Unit { get; set; }
    }
}