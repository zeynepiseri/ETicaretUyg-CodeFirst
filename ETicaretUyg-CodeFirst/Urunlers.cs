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
    
    public partial class Urunlers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Urunlers()
        {
            this.Musterilers = new HashSet<Musterilers>();
            this.Siparislers = new HashSet<Siparislers>();
        }
    
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public string UrunMarka { get; set; }
        public int UrunStok { get; set; }
        public string UrunKategori { get; set; }
        public decimal UrunFiyat { get; set; }
        public Nullable<int> Kategori_KategoriId { get; set; }
    
        public virtual Kategorilers Kategorilers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Musterilers> Musterilers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Siparislers> Siparislers { get; set; }
        public virtual Siparislers Siparislers1 { get; set; }
    }
}
