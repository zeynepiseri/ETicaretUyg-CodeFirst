using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretUyg_CodeFirst.Entity
{
    public class Siparisler
    {
        [Key]
        public int SiparisId { get; set; }
        public int MusteriId { get; set; }
        public DateTime SiparisTarih { get; set; }
        public decimal SiparisToplamFiyat { get; set; }
        public string SiparisOdemeBilgi { get; set; }

    }
}
