﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class SbMtorderInfo
 : Entity<int>    {
        
        public int Mid { get; set; }
        public int Itm { get; set; }
        public string PartNo { get; set; }
        public string OilsName { get; set; }
        public string Content { get; set; }
        public string Standard { get; set; }
        public string Method { get; set; }
        public byte[] SpecImage { get; set; }
        public string Result { get; set; }
        public string Rem { get; set; }
        public string ExcStatus { get; set; }
        public string StandardAddAmount { get; set; }
        public string ActualAddAmount { get; set; }
        public string SparePartsNo { get; set; }
        public string Unit { get; set; }
        public string SpecNo { get; set; }
        public string Recorder { get; set; }

        public virtual SbMtOrder MidNavigation { get; set; }
    }
}