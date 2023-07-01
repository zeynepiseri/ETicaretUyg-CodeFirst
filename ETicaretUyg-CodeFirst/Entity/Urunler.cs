using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretUyg_CodeFirst.Entity
{
    public class Urunler
    {
        public static IEnumerable<object> Urunlers { get; internal set; }
        [Key]
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public string UrunMarka { get; set;}
        public int UrunStok { get; set; }
        public string UrunKategori { get; set; }

        public decimal UrunFiyat { get; set; }
        public Kategoriler Kategori { get; set; } // Kategoriler sınıfından ismi Kategori olan bir değer türet. Sadece 1 kez 
        public ICollection<Siparisler> Siparislers { get; set; }  // Bir Ürün birden fazla siparişte yer alabilir
        public ICollection<Musteriler> Musterilers { get; set; }  // Bir ürün birden fazla müşteride yer alabilir


    }
}
