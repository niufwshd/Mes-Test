﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class TDevicebindlog
 : Entity<int>    {
        public int LogId { get; set; }
        public string RegistrationId { get; set; }
        public string UserNo { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime ModifyTime { get; set; }
        public string DeviceType { get; set; }
    }
}