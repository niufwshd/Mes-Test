﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class SysFormnoInfo
 : Entity<int>    {
        public string FormNo { get; set; }
        public string PrefixNo { get; set; }
        public string Dtformat { get; set; }
        public string DateValue { get; set; }
        public string PostfixNo { get; set; }
        public int? Snlength { get; set; }
        public int? MaxSn { get; set; }
        public string MaxFormNo { get; set; }
        public string Remark { get; set; }
    }
}