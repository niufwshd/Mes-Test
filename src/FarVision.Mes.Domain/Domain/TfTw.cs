﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class TfTw
 : Entity<int>    {
        
        public int Mid { get; set; }
        public string TwNo { get; set; }
        public int Itm { get; set; }
        public string PrdNo { get; set; }
        public string PrdName { get; set; }
        public string PrdMark { get; set; }
        public string Wh { get; set; }
        public string Unit { get; set; }
        public decimal? Qty { get; set; }
        public decimal? QtyRtn { get; set; }
        public decimal? QtyRtnUnsh { get; set; }
        public string BatNo { get; set; }
        public string UseinNo { get; set; }
        public string CpySw { get; set; }
        public string Rem { get; set; }
        public string PrdNoChg { get; set; }
        public decimal? Qty1 { get; set; }
        public string IdNo { get; set; }
        public decimal? Cst { get; set; }
        public string WtNo { get; set; }
        public decimal? QtyTs { get; set; }
        public decimal? QtyTsUnsh { get; set; }
        public int? TsItm { get; set; }
        public string CnttNo { get; set; }
        public string ComposeIdno { get; set; }
        public int? EstItm { get; set; }
        public int? PreItm { get; set; }
        public decimal? LosRto { get; set; }
        public decimal? QtyStd { get; set; }
        public string ZcPrd { get; set; }
        public decimal? QtyRsv { get; set; }
        public decimal? QtyLost { get; set; }
        public string ChgRto { get; set; }
        public decimal? CstStd { get; set; }
        public int? ChgItm { get; set; }
        public decimal? QtyChgRto { get; set; }
        public decimal? QtyQl { get; set; }
        public decimal? QtyQlUnsh { get; set; }
        public decimal? Qty1Ql { get; set; }
        public decimal? Qty1QlUnsh { get; set; }
        public decimal? QtyDm { get; set; }
        public decimal? QtyDmUnsh { get; set; }
        public decimal? Qty1Dm { get; set; }
        public decimal? Qty1DmUnsh { get; set; }
        public decimal? QtyBl { get; set; }
        public decimal? QtyBlUnsh { get; set; }
        public decimal? QtyQlYl { get; set; }
        public decimal? QtyQlYlUnsh { get; set; }
        public decimal? UpStd { get; set; }
        public decimal? UpStdIfrs { get; set; }
        public string PakUnit { get; set; }
        public decimal? PakExc { get; set; }
        public decimal? PakNwN { get; set; }
        public decimal? PakNw { get; set; }
        public string PakWeightUnit { get; set; }
        public decimal? PakGwN { get; set; }
        public decimal? PakGw { get; set; }
        public decimal? PakMeast { get; set; }
        public string PakMeastUnit { get; set; }
        public string CqFlg { get; set; }

        public virtual MfTw MidNavigation { get; set; }
    }
}