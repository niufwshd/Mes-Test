﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class TUser
 : Entity<int>    {
        
        public string Userid { get; set; }
        public string Loginpassword { get; set; }
        public int? Isdisable { get; set; }
    }
}