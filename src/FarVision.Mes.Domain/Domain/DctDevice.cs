﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class DctDevice
 : Entity<int>    {
        public Guid Id { get; set; }
        public string DeviceNo { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateTime { get; set; }
        public bool? IsProcessed { get; set; }
        public string ProcessResult { get; set; }
    }
}