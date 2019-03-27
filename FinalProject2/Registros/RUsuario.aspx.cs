using BLL;
using Entities;
using FinalProject2.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject2.Registros
{
    public partial class RUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void Limpiar()
        {
            UsuarioIdTextBox.Text = "0";
            NombreTextBox.Text = string.Empty;
            CedulaTextBox.Text = string.Empty;
            NombreUsuarioTextBox.Text = string.Empty;
            PasswordTextBox.Text = string.Empty;
            TelefonoTextBox.Text = string.Empty;
            FechaTextBox.Text = Convert.ToString(DateTime.Now);
        }

        public void LlenaCampos(Usuario usuario)
        {
            Limpiar();
            UsuarioIdTextBox.Text = Convert.ToString(usuario.UsuarioId);
            NombreTextBox.Text = usuario.Nombre;
            FechaTextBox.Text = Convert.ToString(usuario.FechaRegistro);
            TelefonoTextBox.Text = usuario.Telefono;
            NombreUsuarioTextBox.Text = usuario.UserName;
            CedulaTextBox.Text = usuario.Cedula;
            PasswordTextBox.Text = usuario.Password;

        }
        private Usuario LlenaClase(Usuario usuario)
        {
            usuario.UsuarioId = Convert.ToInt32(UsuarioIdTextBox.Text);
            usuario.Nombre = NombreTextBox.Text;
            usuario.FechaRegistro = Convert.ToDateTime(FechaTextBox.Text);
            usuario.Telefono = TelefonoTextBox.Text;
            usuario.UserName = NombreUsuarioTextBox.Text;
            usuario.Cedula = CedulaTextBox.Text;
            usuario.Password = PasswordTextBox.Text;
            return usuario;
        }
        protected void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuario> repositorioBase = new RepositorioBase<Usuario>();
            Usuario usuario = new Usuario();
            bool paso = false;

            if (IsValid == false)
            {
                Utils.ShowToastr(this.Page, "Revisar todos los campo", "Error", "error");
                return;
            }

            usuario = LlenaClase(usuario);
            if (usuario.UsuarioId == 0)
                paso = repositorioBase.Guardar(usuario);
            else
                paso = repositorioBase.Modificar(usuario);
            if (paso)
            {
                Utils.ShowToastr(this.Page, "Guardado con exito!!", "Guardado", "success");
            }
        }
        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(UsuarioIdTextBox.Text);
            RepositorioBase<Usuario> repositorio = new RepositorioBase<Usuario>();
            if (repositorio.Eliminar(id))
            {
                Utils.ShowToastr(this.Page, "Eliminado con exito!!", "Eliminado", "info");
            }
            else
                Utils.ShowToastr(this.Page, "Fallo al Eliminar :(", "Error", "error");
            Limpiar();
        }
        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuario> repositorio = new RepositorioBase<Usuario>();
            var usuario = repositorio.Buscar(Utils.ToInt(UsuarioIdTextBox.Text));

            if (usuario != null)
            {
                Limpiar();
                LlenaCampos(usuario);

                Utils.ShowToastr(this, "Busqueda exitosa", "Exito", "success");
            }
            else
                Utils.ShowToastr(this.Page, "El usuario que intenta buscar no existe", "Error", "error");
        }
    }
}