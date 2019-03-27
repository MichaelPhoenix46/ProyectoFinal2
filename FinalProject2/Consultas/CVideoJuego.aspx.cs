using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject2.Consultas
{
    public partial class CVideoJuego : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            Expression<Func<VideoJuego, bool>> filtro = x => true;
            RepositorioBase<VideoJuego> repositorio = new RepositorioBase<VideoJuego>();

            int id;
            switch (FiltroDropDownList.SelectedIndex)
            {
                case 0: //Todo
                    repositorio.GetList(c => true);
                    break;
                case 1://VideoJuegoId
                    id = Utilidades.Utils.ToInt(CriterioTextBox.Text);
                    filtro = c => c.VideoJuegoId == id;
                    break;
                case 2://Titulo
                    filtro = c => c.Titulo.Contains(CriterioTextBox.Text);
                    break;
                case 3: ///Descripcion
                    filtro = c => c.Descripcion.Contains(CriterioTextBox.Text);
                    break;
                case 4: //plataforma
                    filtro = c => c.Plataforma.Contains(CriterioTextBox.Text);
                    break;
                case 5://Genero
                    filtro = c => c.Genero.Contains(CriterioTextBox.Text);
                    break;
                case 6://Cantidad
                    filtro = c => c.CantidadEjemplares.Equals(Convert.ToString(CriterioTextBox.Text));
                    break;
            }

            DatosGridView.DataSource = repositorio.GetList(filtro);
            DatosGridView.DataBind();
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
