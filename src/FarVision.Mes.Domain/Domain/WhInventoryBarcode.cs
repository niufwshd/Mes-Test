﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class WhInventoryBarcode
 : Entity<int>    {
        public string InventoryBarcodeId { get; set; }
        public string BarcodeNo { get; set; }
        public string Whno { get; set; }
        public DateTime? InventoryTime { get; set; }
        public string StorageNo { get; set; }
        public string PrdNo { get; set; }
        public string PrdName { get; set; }
        public string PrdSpc { get; set; }
        public string BatNo { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Qty1 { get; set; }
        public string Unit { get; set; }
    }
}