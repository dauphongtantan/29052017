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
    
    public partial class BH_PHUONG_AN_KINH_DOANH
    {
        public string MA_SO_PAKD { get; set; }
        public string PHIEU_BAO_GIA { get; set; }
        public string MA_KHACH_HANG { get; set; }
        public string NOI_DUNG_PAKD { get; set; }
        public decimal TONG_GIA_TRI_VTHH_DAU_VAO { get; set; }
        public decimal CHI_PHI_KHAC { get; set; }
        public decimal TONG_GIA_TRI_DON_HANG_THUC_TE { get; set; }
        public decimal TONG_GIA_TRI_DON_HANG_THEO_PHIEU_XUAT_HOP_DONG { get; set; }
        public decimal GIA_TRI_CHENH_LECH { get; set; }
        public decimal CHI_PHI_HOA_DON { get; set; }
        public decimal TIEN_CHI_PHI_HOA_DON { get; set; }
        public decimal THUE_VAT { get; set; }
        public decimal TIEN_THUE_VAT { get; set; }
        public decimal TONG_GIA_TRI_THU_CUA_KHACH { get; set; }
        public decimal LOI_NHUAN_THUAN { get; set; }
        public decimal CHIET_KHAU_CHO_KHACH { get; set; }
        public decimal THANH_TOAN_KHI_DAT_HANG { get; set; }
        public decimal THANH_TOAN_SAU_GIAO_HANG { get; set; }
        public string HINH_THUC_THANH_TOAN { get; set; }
        public string HOA_DON_CHUNG_TU { get; set; }
        public string CONG_NO { get; set; }
        public string TRUC_THUOC { get; set; }
        public string NHAN_VIEN_QUAN_LY { get; set; }
        public string MA_SO_PO { get; set; }
    
        public virtual BH_BAO_GIA BH_BAO_GIA { get; set; }
        public virtual BH_DON_HANG_PO BH_DON_HANG_PO { get; set; }
        public virtual KH KH { get; set; }
        public virtual HT_NGUOI_DUNG HT_NGUOI_DUNG { get; set; }
        public virtual CCTC_CONG_TY CCTC_CONG_TY { get; set; }
    }
}
