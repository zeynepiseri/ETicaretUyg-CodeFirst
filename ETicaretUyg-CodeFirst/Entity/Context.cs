using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ETicaretUyg_CodeFirst.Entity
{
    class Context : DbContext
    {
        public DbSet<Urunler> Urunlers { get; set; }
        public DbSet<Kategoriler> Kategorilers { get; set; }
        public DbSet<Musteriler> Musterilers { get; set; }
        public DbSet<Siparisler> Siparislers { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
