﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class MdmBom
 : Entity<int>    {
        public string PartNo { get; set; }
        public string ProductionPurpose { get; set; }
        public string VersionNo { get; set; }
        public string EffectiveDate { get; set; }
        public string ExpirationDate { get; set; }
        public string IsEffective { get; set; }
        
        public string IsDelete { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}