﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class TbTzrbHz
 : Entity<int>    {
        public DateTime? Inputdate { get; set; }
        public string PrdNo { get; set; }
        public string PrdName { get; set; }
        public string PrdSnm { get; set; }
        public string PrdSpc { get; set; }
        public int? Initnum { get; set; }
        public int? Innum { get; set; }
        public int? Outnum { get; set; }
        public int? PreWaste { get; set; }
        public int? CurWaste { get; set; }
        public int? Trailwaste { get; set; }
        public int? Otherwaste { get; set; }
        public int? Rn { get; set; }
    }
}