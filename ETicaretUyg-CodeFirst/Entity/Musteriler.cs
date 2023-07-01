using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretUyg_CodeFirst.Entity
{
    public class Musteriler
    {
        [Key]
        public int MusteriId { get; set; }
        public string MusteriAd { get; set; }
        public string MusteriSoyad { get; set; }
        public string MusteriEmail { get; set; }
        public string MusteriTelefon { get; set; }
        public string MusretiSehir { get; set; }
        public int MusteriSifre { get; set; }

    }
}
