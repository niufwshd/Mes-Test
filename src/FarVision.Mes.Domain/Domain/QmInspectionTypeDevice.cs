﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class QmInspectionTypeDevice
 : Entity<int>    {
        
        public string DeviceNo { get; set; }
        public string InspectionType { get; set; }
        public string Usr { get; set; }
        public DateTime? SysDate { get; set; }
    }
}