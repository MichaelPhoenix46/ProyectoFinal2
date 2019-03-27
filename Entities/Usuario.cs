using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        public string UserName { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Cedula { get; set; }
        public string Password { get; set; }
        public string Tipo { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Usuario()
        {
            UsuarioId = 0;
            UserName = string.Empty;
            Nombre = string.Empty;
            Telefono = string.Empty;
            Cedula = string.Empty;
            Password = string.Empty;
            Tipo = string.Empty;
            FechaRegistro = DateTime.Now;
        }

        public Usuario(int usuarioId, string userName, string nombre, string telefono, string cedula, string password, string tipo, DateTime fechaRegistro)
        {
            UsuarioId = usuarioId;
            UserName = userName;
            Nombre = nombre;
            Telefono = telefono;
            Cedula = cedula;
            Password = password;
            Tipo = tipo;
            FechaRegistro = fechaRegistro;
        }
    }
}