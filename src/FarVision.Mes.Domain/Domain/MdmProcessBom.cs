﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class MdmProcessBom
 : Entity<int>    {
        public DateTime? EffectDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        
        public int? Mid { get; set; }
        public string PickingMode { get; set; }
        public string ProcVerNo { get; set; }
        public string ProcessNo { get; set; }
        public string ProdAlternate { get; set; }
        public string ProdNo { get; set; }
        public decimal? Qty { get; set; }
        public decimal? WastageRate { get; set; }
        public decimal? QtyBase { get; set; }
        public decimal? WastageQty { get; set; }
        public string MateialType { get; set; }
        public string AccuracyTrace { get; set; }
        public bool? IsGenerateTraceBarcode { get; set; }

        public virtual TfBom MidNavigation { get; set; }
    }
}