//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ETicaretUyg_CodeFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class Musterilers
    {
        public int MusteriId { get; set; }
        public string MusteriAd { get; set; }
        public string MusteriSoyad { get; set; }
        public string MusteriEmail { get; set; }
        public string MusteriTelefon { get; set; }
        public int MusteriSifre { get; set; }
        public Nullable<int> Urunler_UrunId { get; set; }
    
        public virtual Urunlers Urunlers { get; set; }
        public virtual Siparislers Siparislers { get; set; }
    }
}