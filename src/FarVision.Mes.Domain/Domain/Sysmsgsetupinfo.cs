﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class Sysmsgsetupinfo
 : Entity<int>    {
        
        public int Mid { get; set; }
        public int RecLevel { get; set; }
        public int? ToRole { get; set; }
        public string ToUsrs { get; set; }
        public string ToMails { get; set; }
        public int? ValidTime { get; set; }
        public int? DelayTime { get; set; }
        public string Tonext { get; set; }
    }
}