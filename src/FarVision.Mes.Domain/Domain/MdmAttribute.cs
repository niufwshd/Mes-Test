﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    /// <summary>
    /// 属性配置
    /// </summary>
    public partial class MdmAttribute
 : Entity<int>    {
        
        public string AttributeCode { get; set; }
        public string AttributeDescribtion { get; set; }
        public string AttributeType { get; set; }
        public string AttributeOwnershipHierarchy { get; set; }
        public string CreateUser { get; set; }
        public DateTime? CreateTime { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? Isdelete { get; set; }
        public int? AttributeOrder { get; set; }
        public string BusinessCode { get; set; }
        public string ConfigurationField { get; set; }
        public string DisplayField { get; set; }
    }
}