﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class TfIj
 : Entity<int>    {
        
        public int Mid { get; set; }
        public string IjId { get; set; }
        public string IjNo { get; set; }
        public int Itm { get; set; }
        public DateTime? IjDd { get; set; }
        public string PrdNo { get; set; }
        public string PrdName { get; set; }
        public string PrdMark { get; set; }
        public string Wh { get; set; }
        public string Unit { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Qty1 { get; set; }
        public decimal? Cst { get; set; }
        public decimal? InPrice { get; set; }
        public string FixCst { get; set; }
        public string BatNo { get; set; }
        public string Rem { get; set; }
        public decimal? CstStd { get; set; }
        public string IdNo { get; set; }
        public decimal? Ijid1 { get; set; }
        public string CnttNo { get; set; }
        public string ComposeIdno { get; set; }
        public string BilId { get; set; }
        public string BilNo { get; set; }
        public int? PreItm { get; set; }
        public int? EstItm { get; set; }
        public string SpcNo { get; set; }
        public string SupPrdNo { get; set; }
        public int? KeyItm { get; set; }
        public int? BoxItm { get; set; }
        public decimal? Up { get; set; }
        public DateTime? ValidDd { get; set; }
        public DateTime? RkDd { get; set; }
        public decimal? Amtn { get; set; }
        public string SqId { get; set; }
        public string SqNo { get; set; }
        public int? SqItm { get; set; }
        public string DepRk { get; set; }
        public int? PwItm { get; set; }
        public string PrdNoSoRes { get; set; }
        public decimal? UpMain { get; set; }
        public string PakUnit { get; set; }
        public decimal? PakExc { get; set; }
        public decimal? PakNwN { get; set; }
        public decimal? PakNw { get; set; }
        public string PakWeightUnit { get; set; }
        public decimal? PakGwN { get; set; }
        public decimal? PakGw { get; set; }
        public decimal? PakMeast { get; set; }
        public string PakMeastUnit { get; set; }
        public string QcFlag { get; set; }
        public decimal? UpStd { get; set; }
        public decimal? CstIfrs { get; set; }
        public decimal? CstStdIfrs { get; set; }
        public decimal? UpMainIfrs { get; set; }
        public decimal? UpStdIfrs { get; set; }
        public string SupPrdMark { get; set; }
        public int? MatrixItm { get; set; }
        public string AddId { get; set; }
        public string ZlLevel { get; set; }
        public DateTime? ScDd { get; set; }
        public string GroupHdlDx { get; set; }
        public int? BilItm { get; set; }

        public virtual MfIj MidNavigation { get; set; }
    }
}