﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class BfDataHistory
 : Entity<int>    {
        public long Id { get; set; }
        public string TableName { get; set; }
        public int ObjectId { get; set; }
        public int OperKind { get; set; }
        public string Remark { get; set; }
        public int UserId { get; set; }
        public DateTime DTime { get; set; }
    }
}