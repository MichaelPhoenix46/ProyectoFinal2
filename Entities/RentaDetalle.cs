using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RentaDetalle
    {
        [Key]
        public int RentaId { get; set; }
        public int VideoJuegoId { get; set; }
        public string Titulo { get; set; }

        [ForeignKey("VideoJuegoId")]
        public virtual VideoJuego VideoJuego { get; set; }

        public RentaDetalle(int rentaId, int videoJuegoId, string titulo)
        {
            RentaId = rentaId;
            VideoJuegoId = videoJuegoId;
            Titulo = titulo;

        }
        public RentaDetalle()
        {
            RentaId = 0;
        }
    }
}