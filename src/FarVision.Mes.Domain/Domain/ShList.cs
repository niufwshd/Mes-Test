﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class ShList
 : Entity<int>    {
        
        public string BusiNo { get; set; }
        public string BilNo { get; set; }
        public int BilItm { get; set; }
        public int Itm { get; set; }
        public string Yn { get; set; }
        public string ChkMan { get; set; }
        public DateTime? ChkDate { get; set; }
        public string Rem { get; set; }
        public int? ShItm { get; set; }
        public string ChkManMain { get; set; }
        public string Yn1 { get; set; }
        public string PreTag { get; set; }
        public string ChkMan1 { get; set; }
        public string ChkManMain1 { get; set; }
    }
}