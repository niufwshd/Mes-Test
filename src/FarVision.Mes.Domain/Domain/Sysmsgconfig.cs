﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class Sysmsgconfig
 : Entity<int>    {
        
        public string BusiNo { get; set; }
        public string BillType { get; set; }
        public string BillTypeName { get; set; }
        public int BillState { get; set; }
        public string FromUsr { get; set; }
        public string ToUsrs { get; set; }
        public int? ToRole { get; set; }
        public string CaptionFormat { get; set; }
        public string ContentFormat { get; set; }
        public string Rem { get; set; }
        public string Usr { get; set; }
        public DateTime DInputDate { get; set; }
        public string ToMails { get; set; }
    }
}