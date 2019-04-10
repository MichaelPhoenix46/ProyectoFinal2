using BLL;
using Entities;
using FinalProject2.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject2
{
    public partial class LogIn : System.Web.UI.Page
    {
        private Usuario usuario = new Usuario();
        private RepositorioBase<Usuario> repositorio = new RepositorioBase<Usuario>();
        List<Usuario> userList = new List<Usuario>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LogInButton_Click(object sender, EventArgs e)
        {
            userList = repositorio.GetList(u => u.UserName.Equals(UsuarioTextBox.Text) && u.Password.Equals(PasswordTextBox.Text));
            usuario = (userList != null && userList.Count > 0) ? userList[0] : null;
            if (usuario != null)
            {

                FormsAuthentication.RedirectFromLoginPage(usuario.Nombre, true);
            }
            else
            {
                Utils.ShowToastr(this.Page, "Usuario o contraseña incorrectos", "Error", "error");
            }
        }
    }
}