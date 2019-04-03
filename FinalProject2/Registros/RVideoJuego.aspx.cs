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
    public partial class RVideoJuego : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            VideoJuegoIdTextBox.Text = "0";
            TituloTextBox.Text = string.Empty;
            descripcionTextBox.Text = string.Empty;
            PlataformaTextBox.Text = string.Empty;
            GeneroTextBox.Text = string.Empty;
            CantidadEjemplaresTextBox.Text = "0";
            FechaTextBox.Text = Convert.ToString(DateTime.Now);

        }

        public void LlenaCampos(VideoJuego videoJuego)
        {
            TituloTextBox.Text = videoJuego.Titulo;
            FechaTextBox.Text = Convert.ToString(videoJuego.FechaRegistro);
            PlataformaTextBox.Text = videoJuego.Plataforma;
            descripcionTextBox.Text = videoJuego.Descripcion;
            GeneroTextBox.Text = videoJuego.Genero;
            CantidadEjemplaresTextBox.Text = Convert.ToString(videoJuego.CantidadEjemplares);
        }
        private VideoJuego LlenaClase(VideoJuego videoJuego)
        {
            videoJuego.VideoJuegoId = Utils.ToInt(VideoJuegoIdTextBox.Text);
            videoJuego.Titulo = TituloTextBox.Text;
            videoJuego.FechaRegistro = DateTime.Now;
            videoJuego.Descripcion = descripcionTextBox.Text;
            videoJuego.Genero = GeneroTextBox.Text;
            videoJuego.Plataforma = PlataformaTextBox.Text;
            videoJuego.CantidadEjemplares = Convert.ToInt32(CantidadEjemplaresTextBox.Text);
            return videoJuego;
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<VideoJuego> repositorioBase = new RepositorioBase<VideoJuego>();
            VideoJuego videoJuego = new VideoJuego();
            bool paso = false;

            if (IsValid == false)
            {
                Utils.ShowToastr(this.Page, "Revisar todos los campos", "Error", "error");
                return;
            }

            videoJuego = LlenaClase(videoJuego);
            if (videoJuego.VideoJuegoId == 0)
                paso = repositorioBase.Guardar(videoJuego);
            else
                paso = repositorioBase.Modificar(videoJuego);
            if (paso)
            {
                Utils.ShowToastr(this.Page, "Guardado con exito!!", "Guardado", "success");
            }
        }
        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(VideoJuegoIdTextBox.Text);
            RepositorioBase<VideoJuego> repositorio = new RepositorioBase<VideoJuego>();
            if (repositorio.Eliminar(id))
            {
                Utils.ShowToastr(this.Page, "Eliminado con exito!!", "Eliminado", "info");
            }
            else
                Utils.ShowToastr(this.Page, "Fallo al Eliminar", "Error", "error");
            Limpiar();
        }
        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<VideoJuego> repositorio = new RepositorioBase<VideoJuego>();
            var videoJuego = repositorio.Buscar(Utils.ToInt(VideoJuegoIdTextBox.Text));

            if (videoJuego != null)
            {
                Limpiar();
                LlenaCampos(videoJuego);

                Utils.ShowToastr(this, "Busqueda exitosa", "Exito", "success");
            }
            else
                Utils.ShowToastr(this.Page, "El VideoJuego que intenta buscar no existe", "Error", "error");
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}