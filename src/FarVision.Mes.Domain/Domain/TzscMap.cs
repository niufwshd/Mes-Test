﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class TzscMap
 : Entity<int>    {
        
        public string TzNo { get; set; }
        public string ZcNo { get; set; }
        public string SebNo { get; set; }
        public string PaNo { get; set; }
        public string PaValue { get; set; }
        public int TzId { get; set; }
        public DateTime MapDate { get; set; }
        public DateTime? PaDate { get; set; }
        public DateTime? OpnDd { get; set; }
        public string PaName { get; set; }
    }
}