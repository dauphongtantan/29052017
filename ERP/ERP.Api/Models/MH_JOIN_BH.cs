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
    
    public partial class MH_JOIN_BH
    {
        public int ID { get; set; }
        public int ID_PO_BAN_HANG { get; set; }
        public int ID_PO_MUA_HANG { get; set; }
    
        public virtual BH_CT_DON_HANG_PO BH_CT_DON_HANG_PO { get; set; }
        public virtual MH_PO_CT_MUA_HANG MH_PO_CT_MUA_HANG { get; set; }
    }
}
