﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class GxOtherMain
 : Entity<int>    {
        public GxOtherMain()
        {
            GxOtherItems = new HashSet<GxOtherItems>();
        }

        public DateTime? BillDate { get; set; }
        public string BilType { get; set; }
        public string BilTypeName { get; set; }
        public string BusiNo { get; set; }
        public DateTime? ChkDate { get; set; }
        public string ChkMan { get; set; }
        public string ChkManName { get; set; }
        public string ChkMob { get; set; }
        public DateTime? ClsDate { get; set; }
        public string ClsUsr { get; set; }
        public string ClsUsrName { get; set; }
        public string GxOtherName { get; set; }
        
        public bool? IsClose { get; set; }
        public bool? IsPrint { get; set; }
        public string No { get; set; }
        public string Rem { get; set; }
        public DateTime SysDate { get; set; }
        public DateTime? UpdDate { get; set; }
        public string UpdUsr { get; set; }
        public string UpdUsrName { get; set; }
        public string Usr { get; set; }
        public string UsrName { get; set; }

        public virtual ICollection<GxOtherItems> GxOtherItems { get; set; }
    }
}