﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class NyxhRecord
 : Entity<int>    {
        
        public string Dep { get; set; }
        public decimal? PlanLevel { get; set; }
        public decimal? ActualLevel { get; set; }
        public decimal? DiffLevel { get; set; }
        public string ConsumType { get; set; }
        public DateTime? ConsumDate { get; set; }
        public string Usr { get; set; }
        public string Usrname { get; set; }
        public DateTime Sysdate { get; set; }
        public string Updusr { get; set; }
        public string Updusrname { get; set; }
        public DateTime? Upddate { get; set; }
    }
}