﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class TfWjS
 : Entity<int>    {
        
        public int Mid { get; set; }
        public string WxjId { get; set; }
        public string WxjNo { get; set; }
        public int Itm { get; set; }
        public string SebNo { get; set; }
        public string SebName { get; set; }
        public string SebPart { get; set; }
        public int? ItmSb { get; set; }
        public string FaType { get; set; }
        public string Fa { get; set; }
        public string FaLevel { get; set; }
        public DateTime? BDdRep { get; set; }
        public DateTime? EDdRep { get; set; }
        public DateTime? WxjDd { get; set; }
        public string RepNo { get; set; }
        public string Rem { get; set; }
        public string ToOth { get; set; }
        public string WxjContent { get; set; }
        public string Lessons { get; set; }
        public string FaAppearance { get; set; }
        public string RsNo { get; set; }
        public string RsDesp { get; set; }

        public virtual MfWjS MidNavigation { get; set; }
    }
}