﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class StTdcodeTemp
 : Entity<int>    {
        
        public string Entryid { get; set; }
        public string Barcode { get; set; }
        public string TzNo { get; set; }
        public string Usrno { get; set; }
        public string CodeStatus { get; set; }
        public string SpcNo { get; set; }
        public DateTime? ScanTime { get; set; }
        public string SebNo { get; set; }
        public bool? IsBatTray { get; set; }
        public string ZcNo { get; set; }
        public string BanNo { get; set; }
        public string MoNo { get; set; }
        public string StationNo { get; set; }
    }
}