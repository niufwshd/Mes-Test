﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class WmFrozenStorage
 : Entity<int>    {
        public string BatchNo { get; set; }
        public decimal? FrozenQuantity { get; set; }
        
        public string ProdNo { get; set; }
        public DateTime? ProductionDate { get; set; }
        public string SourceNo { get; set; }
        public DateTime SysDate { get; set; }
        public DateTime? UpdDate { get; set; }
        public string UpdUsr { get; set; }
        public string UpdUsrName { get; set; }
        public string Usr { get; set; }
        public string UsrName { get; set; }
        public string WareHouseNo { get; set; }
    }
}