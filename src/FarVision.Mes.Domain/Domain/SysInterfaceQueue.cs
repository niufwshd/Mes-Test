﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class SysInterfaceQueue
 : Entity<int>    {
        
        public string SerialNo { get; set; }
        public string FunctionName { get; set; }
        public string InterfaceCode { get; set; }
        public string RequestBody { get; set; }
        public int? Status { get; set; }
        public Guid? ObjectId { get; set; }
        public int? SendCount { get; set; }
        public string ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public string ResponseBody { get; set; }
        public string CreateUserNo { get; set; }
        public DateTime? CreateTime { get; set; }
        public string UpdateUserNo { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}