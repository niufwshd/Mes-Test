﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class BfBusiFieldC
 : Entity<int>    {
        
        public string MBusiNo { get; set; }
        public string MName { get; set; }
        public int MValueControl { get; set; }
        public string MValueDefault { get; set; }
        public bool MHistory { get; set; }
        public int GcVisible { get; set; }
        public string GcFormat { get; set; }
        public bool EditAble { get; set; }
        public string Usr { get; set; }
        public string UsrName { get; set; }
        public DateTime? SysDate { get; set; }
        public string UpdUsr { get; set; }
        public string UpdUsrName { get; set; }
        public DateTime? UpdDate { get; set; }
        public int? EditType { get; set; }
        public bool? FilterAble { get; set; }
    }
}