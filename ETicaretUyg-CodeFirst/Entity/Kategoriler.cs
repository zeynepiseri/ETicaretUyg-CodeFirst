using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretUyg_CodeFirst.Entity
{
    public class Kategoriler
    {
        [Key]
        public int KategoriId { get; set; }
        public string KategoriAd { get; set; }
        public ICollection<Urunler> Urunlers { get; set; }  // Bir kategori birden fazla üründe yer alabilir

    }
}
