﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class MfMdInout
 : Entity<int>    {
        public MfMdInout()
        {
            TfMdInout = new HashSet<TfMdInout>();
        }

        
        public string EntryNo { get; set; }
        public int InOut { get; set; }
        public DateTime EntDate { get; set; }
        public string Usr { get; set; }
        public string UsrName { get; set; }
        public DateTime SysDate { get; set; }
        public string BusiNo { get; set; }

        public virtual ICollection<TfMdInout> TfMdInout { get; set; }
    }
}