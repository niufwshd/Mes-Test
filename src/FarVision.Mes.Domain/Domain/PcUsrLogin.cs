﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class PcUsrLogin
 : Entity<int>    {
        
        public DateTime? LoginTime { get; set; }
        public DateTime? LogoutTime { get; set; }
        public string ShiftNo { get; set; }
        public string StationNo { get; set; }
        public DateTime SysDate { get; set; }
        public DateTime? UpdDate { get; set; }
        public string UpdUsr { get; set; }
        public string UpdUsrName { get; set; }
        public string Usr { get; set; }
        public string UsrLogin { get; set; }
        public string UsrName { get; set; }
        public string UsrNameLogin { get; set; }
        public string WkCenterNo { get; set; }
    }
}