﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class VQcPrdInspectWs
 : Entity<int>    {
        public string InspectType { get; set; }
        public string ZcNo { get; set; }
        public string PrdNo { get; set; }
        public string IsWsInspect { get; set; }
    }
}