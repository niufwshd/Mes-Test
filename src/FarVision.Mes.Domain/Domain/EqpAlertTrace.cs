﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class EqpAlertTrace
 : Entity<int>    {
        public string AlertContent { get; set; }
        public string Barcode { get; set; }
        public string DevNo { get; set; }
        public DateTime? EndTime { get; set; }
        public string ExcepNo { get; set; }
        
        public string ProdNo { get; set; }
        public DateTime? StartTime { get; set; }
        public string StationNo { get; set; }
        public DateTime SysDate { get; set; }
        public DateTime? UpdDate { get; set; }
        public string UpdUsr { get; set; }
        public string UpdUsrName { get; set; }
        public string Usr { get; set; }
        public string UsrName { get; set; }
        public string WoNo { get; set; }
    }
}