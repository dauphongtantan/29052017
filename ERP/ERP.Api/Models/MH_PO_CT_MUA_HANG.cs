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
    
    public partial class MH_PO_CT_MUA_HANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MH_PO_CT_MUA_HANG()
        {
            this.MH_DE_NGHI_JOIN_PO_MH = new HashSet<MH_DE_NGHI_JOIN_PO_MH>();
            this.MH_JOIN_BH = new HashSet<MH_JOIN_BH>();
        }
    
        public int ID { get; set; }
        public string MA_SO_PO { get; set; }
        public string MA_HANG { get; set; }
        public int SL { get; set; }
        public decimal DON_GIA_CHUA_VAT { get; set; }
        public decimal THANH_TIEN_CHUA_VAT { get; set; }
        public string THOI_GIAN_GIAO_HANG { get; set; }
        public string GHI_CHU { get; set; }
        public decimal GIA_BAN_RA { get; set; }
        public int SL_DA_VE { get; set; }
    
        public virtual HH HH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MH_DE_NGHI_JOIN_PO_MH> MH_DE_NGHI_JOIN_PO_MH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MH_JOIN_BH> MH_JOIN_BH { get; set; }
        public virtual MH_PO_MUA_HANG MH_PO_MUA_HANG { get; set; }
    }
}