﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class PdHandover
 : Entity<int>    {
        
        public string BanNo { get; set; }
        public string Usr { get; set; }
        public string UsrName { get; set; }
        public DateTime? Sysdate { get; set; }
        public string Handover { get; set; }
        public string ZcNo { get; set; }
        public string Dep { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? UpdDate { get; set; }
        public string UpdUsr { get; set; }
        public string UpdUsrName { get; set; }
    }
}