﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class Sbb
 : Entity<int>    {
        public long Id { get; set; }
        public string TzDd { get; set; }
        public string TzTime { get; set; }
        public string BatNo { get; set; }
        public byte? Isclose { get; set; }
    }
}