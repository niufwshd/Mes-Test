﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class SysMenuLocalSet
 : Entity<int>    {
        
        public string MenuNo { get; set; }
        public bool Disable { get; set; }
        public int? SortIndex { get; set; }
        public DateTime? SysDate { get; set; }
        public DateTime? UpdDate { get; set; }
        public string UpdUsr { get; set; }
        public string UpdUsrName { get; set; }
        public string Usr { get; set; }
        public string UsrName { get; set; }
    }
}