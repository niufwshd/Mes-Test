﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class TbTransferinout
 : Entity<int>    {
        
        public DateTime? Inputdate { get; set; }
        public string Datatype { get; set; }
        public string Producestatus { get; set; }
        public string DepNo { get; set; }
        public string DepName { get; set; }
        public string PrdNo { get; set; }
        public string PrdName { get; set; }
        public string PrdSnm { get; set; }
        public string PrdSpc { get; set; }
        public string Datasource { get; set; }
        public int? Num { get; set; }
    }
}