﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class VDctProcessParameter
 : Entity<int>    {
        public int? TimeStamp { get; set; }
        public string DataModel { get; set; }
        public string DeviceNo { get; set; }
        public string ProductNo { get; set; }
        public string ProcessParameterCode { get; set; }
        public string ProcessParameterName { get; set; }
        public decimal? LowerLimit { get; set; }
        public decimal? UpperLimit { get; set; }
        public decimal? Standard { get; set; }
        public string TableName { get; set; }
        public DateTime CreateTime { get; set; }
        public int IsProcessed { get; set; }
        public int? ProcessResult { get; set; }
        public decimal Interval { get; set; }
    }
}