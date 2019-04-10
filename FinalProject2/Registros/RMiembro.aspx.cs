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
    public partial class RMiembro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!Page.IsPostBack)
            //{
            //    int id = Utils.ToInt(Request.QueryString["id"]);
            //    if (id > 0)
            //    {
            //        RepositorioBase<Miembro> repositorio = new RepositorioBase<Miembro>();
            //        var registro = repositorio.Buscar(id);
            //        LlenaCampos(registro);

            //    }
            //}
        }

        private void Limpiar()
        {
            MiembroIdTextBox.Text = "0";
            NombreTextBox.Text = string.Empty;
            CedulaTextBox.Text = string.Empty;
            DireccionTextBox.Text = string.Empty;
            TelefonoTextBox.Text = string.Empty;
            FechaTextBox.Text = Convert.ToString(DateTime.Now);
        }

        private Miembro LlenaClase(Miembro miembro)
        {
            miembro.MiembroId = Utils.ToInt(MiembroIdTextBox.Text);
            miembro.Nombre = NombreTextBox.Text;
            miembro.FechaRegistro = DateTime.Now;
            miembro.Telefono = TelefonoTextBox.Text;
            miembro.Direccion = DireccionTextBox.Text;
            miembro.Cedula = CedulaTextBox.Text;
            return miembro;
        }

        private void LlenaCampos(Miembro miembro)
        {
            Limpiar();
            MiembroIdTextBox.Text = Convert.ToString(miembro.MiembroId);
            NombreTextBox.Text = miembro.Nombre;
            FechaTextBox.Text = Convert.ToString(miembro.FechaRegistro);
            TelefonoTextBox.Text = miembro.Telefono;
            DireccionTextBox.Text = miembro.Direccion;
            CedulaTextBox.Text = miembro.Cedula;
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Miembro> repositorioBase = new RepositorioBase<Miembro>();
            Miembro miembro = new Miembro();
            bool paso = false;

            if (IsValid == false)
            {
                Utils.ShowToastr(this.Page, "Revisar todos los campo", "Error", "error");
                return;
            }

            LlenaClase(miembro);
            if (miembro.MiembroId == 0)
                paso = repositorioBase.Guardar(miembro);
            else
                paso = repositorioBase.Modificar(miembro);
            if (paso)
            {
                Utils.ShowToastr(this.Page, "Guardado con exito", "Guardado", "success");
            }else
            {
                Utils.ShowToastr(this.Page, "No se ha podido Guardar o modificiar", "Error", "error");
            }
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            if (MiembroIdTextBox.Text == string.Empty)
                Utils.ShowToastr(this.Page, "El Campo Id esta vacio", "Error", "error");
            int id = Convert.ToInt32(MiembroIdTextBox.Text);
            RepositorioBase<Miembro> repositorio = new RepositorioBase<Miembro>();
            if (repositorio.Eliminar(id))
            {
                Utils.ShowToastr(this.Page, "Eliminado con exito!!", "Eliminado", "info");
            }
            else
                Utils.ShowToastr(this.Page, "Fallo al Eliminar ", "Error", "error");
            Limpiar();
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            if (MiembroIdTextBox.Text == string.Empty)
                Utils.ShowToastr(this.Page, "El Campo Id esta vacio", "Error", "error");
            RepositorioBase<Miembro> repositorio = new RepositorioBase<Miembro>();
            var miembro = repositorio.Buscar(Utils.ToInt(MiembroIdTextBox.Text));

            if (miembro != null)
            {
                Limpiar();
                LlenaCampos(miembro);

                Utils.ShowToastr(this, "Busqueda exitosa", "Exito", "success");
            }
            else
                Utils.ShowToastr(this.Page, "El Miembro que intenta buscar no existe", "Error", "error");
        }
    }
}
