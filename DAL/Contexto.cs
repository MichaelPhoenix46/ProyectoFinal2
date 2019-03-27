using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuario> usuario { get; set; }
        public DbSet<Miembro> miembro { get; set; }
        public DbSet<Renta> renta { get; set; }
        public DbSet<RentaDetalle> rentaDetalles { get; set; }
        public DbSet<VideoJuego> videoJuego { get; set; }

        public Contexto() : base("ConStr")
        { }
    }
}