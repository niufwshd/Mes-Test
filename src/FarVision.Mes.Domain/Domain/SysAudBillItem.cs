﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class SysAudBillItem
 : Entity<int>    {
        
        public int Mid { get; set; }
        public int? Item { get; set; }
        public string UsrAud { get; set; }
        public string Result { get; set; }
        public DateTime? AudDate { get; set; }
        public string UsrMain { get; set; }
        public string Rem { get; set; }

        public virtual SysAudBillInfo MidNavigation { get; set; }
    }
}