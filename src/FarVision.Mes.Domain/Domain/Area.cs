﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class Area
 : Entity<int>    {
        
        public string AreaNo { get; set; }
        public string Name { get; set; }
        public string AreaUp { get; set; }
        public DateTime? StopDd { get; set; }
        public string Rem { get; set; }
        public DateTime? UpDd { get; set; }
    }
}