//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP.Api.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NCC_PUR_PHU_TRACH
    {
        public int ID { get; set; }
        public int ID_LIEN_HE { get; set; }
        public string PUR_PHU_TRACH { get; set; }
        public System.DateTime NGAY_BAT_DAU_PHU_TRACH { get; set; }
        public Nullable<System.DateTime> NGAY_KET_THUC_PHU_TRACH { get; set; }
        public Nullable<bool> TRANG_THAI { get; set; }
    
        public virtual CCTC_NHAN_VIEN CCTC_NHAN_VIEN { get; set; }
        public virtual NCC_LIEN_HE NCC_LIEN_HE { get; set; }
    }
}