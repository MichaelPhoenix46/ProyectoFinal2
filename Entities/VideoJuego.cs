using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    public class VideoJuego
    {
        [Key]
        public int VideoJuegoId { get; set; }
        public string Titulo { get; set; }
        public String Descripcion { get; set; }
        public String Plataforma { get; set; }
        //public DateTime Lanzamiento { get; set; }
        public String Genero { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int CantidadEjemplares { get; set; }


        public VideoJuego()
        {
            VideoJuegoId = 0;
            Titulo = string.Empty;
            Descripcion = string.Empty;
            Plataforma = string.Empty;
            //Lanzamiento = DateTime.Now;
            Genero = string.Empty;
            FechaRegistro = DateTime.Now;
            CantidadEjemplares = 0;
        }

        public VideoJuego(int videoJuegoId, string titulo, string descripcion, string plataforma/*, DateTime lanzamiento*/, string genero, DateTime fchaRegistro, int cantidadEjemplares)
        {
            VideoJuegoId = videoJuegoId;
            Titulo = titulo;
            Descripcion = descripcion;
            Plataforma = plataforma;
            //Lanzamiento = lanzamiento;
            Genero = genero;
            FechaRegistro = fchaRegistro;
            CantidadEjemplares = cantidadEjemplares;
        }
    }
}
