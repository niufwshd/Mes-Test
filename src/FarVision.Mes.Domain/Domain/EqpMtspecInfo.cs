﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class EqpMtspecInfo
 : Entity<int>    {
        public string ChkEnumBusino { get; set; }
        public string ChkModel { get; set; }
        public string Content { get; set; }
        public string FaultHandle { get; set; }
        
        public int Itm { get; set; }
        public decimal? LowLimit { get; set; }
        public string LowSybol { get; set; }
        public string Lubrication { get; set; }
        public string Method { get; set; }
        public int Mid { get; set; }
        public string No { get; set; }
        public string OilsName { get; set; }
        public string Opportunity { get; set; }
        public string Optype { get; set; }
        public string PartNo { get; set; }
        public int? Rhpoints { get; set; }
        public string Rhtype { get; set; }
        public string SpecImage { get; set; }
        public string Standard { get; set; }
        public decimal? StandardValue { get; set; }
        public string Unit { get; set; }
        public decimal? UpLimit { get; set; }
        public string UpSybol { get; set; }

        public virtual EqpMaintainSpec MidNavigation { get; set; }
    }
}