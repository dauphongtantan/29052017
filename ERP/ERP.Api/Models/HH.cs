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
    
    public partial class HH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HH()
        {
            this.BH_CT_BAO_GIA = new HashSet<BH_CT_BAO_GIA>();
            this.BH_CT_DON_BAN_HANG = new HashSet<BH_CT_DON_BAN_HANG>();
            this.BH_CT_DON_HANG_PO = new HashSet<BH_CT_DON_HANG_PO>();
            this.HH_BANG_GIA_BAN = new HashSet<HH_BANG_GIA_BAN>();
            this.HH_COMMENTS = new HashSet<HH_COMMENTS>();
            this.KH_CONG_NO = new HashSet<KH_CONG_NO>();
            this.KHO_GIU_HANG = new HashSet<KHO_GIU_HANG>();
            this.KHO_INIT_TACH_GOP_MA = new HashSet<KHO_INIT_TACH_GOP_MA>();
            this.KHO_INIT_TACH_GOP_MA1 = new HashSet<KHO_INIT_TACH_GOP_MA>();
            this.KHO_INIT_TACH_GOP_MA2 = new HashSet<KHO_INIT_TACH_GOP_MA>();
            this.KHO_INIT_TACH_GOP_MA3 = new HashSet<KHO_INIT_TACH_GOP_MA>();
            this.KHO_INIT_TACH_GOP_MA4 = new HashSet<KHO_INIT_TACH_GOP_MA>();
            this.KHO_INIT_TACH_GOP_MA5 = new HashSet<KHO_INIT_TACH_GOP_MA>();
            this.KHO_INIT_TACH_GOP_MA6 = new HashSet<KHO_INIT_TACH_GOP_MA>();
            this.KHO_INIT_TACH_GOP_MA7 = new HashSet<KHO_INIT_TACH_GOP_MA>();
            this.KHO_INIT_TACH_GOP_MA8 = new HashSet<KHO_INIT_TACH_GOP_MA>();
            this.KHO_INIT_TACH_GOP_MA9 = new HashSet<KHO_INIT_TACH_GOP_MA>();
            this.KHO_INIT_TACH_GOP_MA10 = new HashSet<KHO_INIT_TACH_GOP_MA>();
            this.KHO_INIT_TACH_GOP_MA11 = new HashSet<KHO_INIT_TACH_GOP_MA>();
            this.KHO_INIT_TACH_GOP_MA12 = new HashSet<KHO_INIT_TACH_GOP_MA>();
            this.KHO_INIT_TACH_GOP_MA13 = new HashSet<KHO_INIT_TACH_GOP_MA>();
            this.KHO_INIT_TACH_GOP_MA14 = new HashSet<KHO_INIT_TACH_GOP_MA>();
            this.KHO_INIT_TACH_GOP_MA15 = new HashSet<KHO_INIT_TACH_GOP_MA>();
            this.KHO_INIT_TACH_GOP_MA16 = new HashSet<KHO_INIT_TACH_GOP_MA>();
            this.KHO_INIT_TACH_GOP_MA17 = new HashSet<KHO_INIT_TACH_GOP_MA>();
            this.KHO_INIT_TACH_GOP_MA18 = new HashSet<KHO_INIT_TACH_GOP_MA>();
            this.KHO_INIT_TACH_GOP_MA19 = new HashSet<KHO_INIT_TACH_GOP_MA>();
            this.KHO_INIT_TACH_GOP_MA20 = new HashSet<KHO_INIT_TACH_GOP_MA>();
            this.KHO_INIT_TACH_GOP_MA21 = new HashSet<KHO_INIT_TACH_GOP_MA>();
            this.KHO_INIT_TACH_GOP_MA22 = new HashSet<KHO_INIT_TACH_GOP_MA>();
            this.KHO_INIT_TACH_GOP_MA23 = new HashSet<KHO_INIT_TACH_GOP_MA>();
            this.KHO_INIT_TACH_GOP_MA24 = new HashSet<KHO_INIT_TACH_GOP_MA>();
            this.KHO_INIT_TACH_GOP_MA25 = new HashSet<KHO_INIT_TACH_GOP_MA>();
            this.KHO_INIT_TACH_GOP_MA26 = new HashSet<KHO_INIT_TACH_GOP_MA>();
            this.KHO_INIT_TACH_GOP_MA27 = new HashSet<KHO_INIT_TACH_GOP_MA>();
            this.MH_CT_DE_NGHI_NHAP_KHO = new HashSet<MH_CT_DE_NGHI_NHAP_KHO>();
            this.MH_HANG_CAN_DAT = new HashSet<MH_HANG_CAN_DAT>();
            this.MH_PO_CT_MUA_HANG = new HashSet<MH_PO_CT_MUA_HANG>();
            this.KHO_CT_CHUYEN_KHO = new HashSet<KHO_CT_CHUYEN_KHO>();
            this.KHO_CT_DNXH = new HashSet<KHO_CT_DNXH>();
            this.KHO_HANG_CAN_GIU = new HashSet<KHO_HANG_CAN_GIU>();
            this.KHO_CT_NHAP_KHO = new HashSet<KHO_CT_NHAP_KHO>();
            this.KHO_CT_XUAT_KHO = new HashSet<KHO_CT_XUAT_KHO>();
            this.TONKHO_HOPLONG = new HashSet<TONKHO_HOPLONG>();
            this.TONKHO_TADN = new HashSet<TONKHO_TADN>();
            this.TONKHO_TAHCM = new HashSet<TONKHO_TAHCM>();
            this.TONKHO_TAHP = new HashSet<TONKHO_TAHP>();
        }
    
        public string MA_HANG { get; set; }
        public string MA_CHUAN { get; set; }
        public string ITEM_CODE { get; set; }
        public string THONG_SO { get; set; }
        public string MA_NHAP_HANG { get; set; }
        public string TEN_HANG { get; set; }
        public string MA_NHOM_HANG { get; set; }
        public string DON_VI_TINH { get; set; }
        public Nullable<double> KHOI_LUONG { get; set; }
        public string XUAT_XU { get; set; }
        public Nullable<decimal> GIA_NHAP { get; set; }
        public Nullable<decimal> GIA_LIST { get; set; }
        public Nullable<int> BAO_HANH { get; set; }
        public string THONG_SO_KY_THUAT { get; set; }
        public string QUY_CACH_DONG_GOI { get; set; }
        public Nullable<bool> DISCONTINUE { get; set; }
        public string MA_CHUYEN_DOI { get; set; }
        public string HINH_ANH { get; set; }
        public string GHI_CHU { get; set; }
        public string TK_HACH_TOAN_KHO { get; set; }
        public string TK_DOANH_THU { get; set; }
        public string TK_CHI_PHI { get; set; }
        public string SERIES { get; set; }
        public bool MA_DO_SALE_TAO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BH_CT_BAO_GIA> BH_CT_BAO_GIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BH_CT_DON_BAN_HANG> BH_CT_DON_BAN_HANG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BH_CT_DON_HANG_PO> BH_CT_DON_HANG_PO { get; set; }
        public virtual DM_TAI_KHOAN_HACH_TOAN DM_TAI_KHOAN_HACH_TOAN { get; set; }
        public virtual DM_TAI_KHOAN_HACH_TOAN DM_TAI_KHOAN_HACH_TOAN1 { get; set; }
        public virtual DM_TAI_KHOAN_HACH_TOAN DM_TAI_KHOAN_HACH_TOAN2 { get; set; }
        public virtual HH_NHOM_VTHH HH_NHOM_VTHH { get; set; }
        public virtual HH_NHOM_VTHH HH_NHOM_VTHH1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HH_BANG_GIA_BAN> HH_BANG_GIA_BAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HH_COMMENTS> HH_COMMENTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KH_CONG_NO> KH_CONG_NO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_GIU_HANG> KHO_GIU_HANG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_INIT_TACH_GOP_MA> KHO_INIT_TACH_GOP_MA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_INIT_TACH_GOP_MA> KHO_INIT_TACH_GOP_MA1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_INIT_TACH_GOP_MA> KHO_INIT_TACH_GOP_MA2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_INIT_TACH_GOP_MA> KHO_INIT_TACH_GOP_MA3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_INIT_TACH_GOP_MA> KHO_INIT_TACH_GOP_MA4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_INIT_TACH_GOP_MA> KHO_INIT_TACH_GOP_MA5 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_INIT_TACH_GOP_MA> KHO_INIT_TACH_GOP_MA6 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_INIT_TACH_GOP_MA> KHO_INIT_TACH_GOP_MA7 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_INIT_TACH_GOP_MA> KHO_INIT_TACH_GOP_MA8 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_INIT_TACH_GOP_MA> KHO_INIT_TACH_GOP_MA9 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_INIT_TACH_GOP_MA> KHO_INIT_TACH_GOP_MA10 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_INIT_TACH_GOP_MA> KHO_INIT_TACH_GOP_MA11 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_INIT_TACH_GOP_MA> KHO_INIT_TACH_GOP_MA12 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_INIT_TACH_GOP_MA> KHO_INIT_TACH_GOP_MA13 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_INIT_TACH_GOP_MA> KHO_INIT_TACH_GOP_MA14 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_INIT_TACH_GOP_MA> KHO_INIT_TACH_GOP_MA15 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_INIT_TACH_GOP_MA> KHO_INIT_TACH_GOP_MA16 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_INIT_TACH_GOP_MA> KHO_INIT_TACH_GOP_MA17 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_INIT_TACH_GOP_MA> KHO_INIT_TACH_GOP_MA18 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_INIT_TACH_GOP_MA> KHO_INIT_TACH_GOP_MA19 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_INIT_TACH_GOP_MA> KHO_INIT_TACH_GOP_MA20 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_INIT_TACH_GOP_MA> KHO_INIT_TACH_GOP_MA21 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_INIT_TACH_GOP_MA> KHO_INIT_TACH_GOP_MA22 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_INIT_TACH_GOP_MA> KHO_INIT_TACH_GOP_MA23 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_INIT_TACH_GOP_MA> KHO_INIT_TACH_GOP_MA24 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_INIT_TACH_GOP_MA> KHO_INIT_TACH_GOP_MA25 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_INIT_TACH_GOP_MA> KHO_INIT_TACH_GOP_MA26 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_INIT_TACH_GOP_MA> KHO_INIT_TACH_GOP_MA27 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MH_CT_DE_NGHI_NHAP_KHO> MH_CT_DE_NGHI_NHAP_KHO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MH_HANG_CAN_DAT> MH_HANG_CAN_DAT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MH_PO_CT_MUA_HANG> MH_PO_CT_MUA_HANG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_CT_CHUYEN_KHO> KHO_CT_CHUYEN_KHO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_CT_DNXH> KHO_CT_DNXH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_HANG_CAN_GIU> KHO_HANG_CAN_GIU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_CT_NHAP_KHO> KHO_CT_NHAP_KHO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_CT_XUAT_KHO> KHO_CT_XUAT_KHO { get; set; }
        public virtual TONKHO_HANG TONKHO_HANG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TONKHO_HOPLONG> TONKHO_HOPLONG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TONKHO_TADN> TONKHO_TADN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TONKHO_TAHCM> TONKHO_TAHCM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TONKHO_TAHP> TONKHO_TAHP { get; set; }
    }
}
