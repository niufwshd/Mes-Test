﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class RmMeasuringLedger
 : Entity<int>    {
        
        public string MeasuringCode { get; set; }
        public string MeasuringName { get; set; }
        public string Parent { get; set; }
        public string Customers { get; set; }
        public string Supplier { get; set; }
        public string MeasuringType { get; set; }
        public string Factory { get; set; }
        public bool? Isdelete { get; set; }
        public string Createuser { get; set; }
        public DateTime? Createtime { get; set; }
        public string Updateuser { get; set; }
        public DateTime? Updatetime { get; set; }
    }
}