﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class Qciteminterface
 : Entity<int>    {
        public DateTime? ChkDate { get; set; }
        public int? ChkTemplate { get; set; }
        public string ChkUser { get; set; }
        public DateTime? DInputDate { get; set; }
        
        public byte? IFlag { get; set; }
        public byte? IsPrint { get; set; }
        public string LockUser { get; set; }
        public DateTime? PrintDate { get; set; }
        public string PrintUser { get; set; }
        public string QcItemInterfaceName { get; set; }
        public string QcItemInterfaceNo { get; set; }
        public string Rem { get; set; }
        public string SUserId { get; set; }
    }
}