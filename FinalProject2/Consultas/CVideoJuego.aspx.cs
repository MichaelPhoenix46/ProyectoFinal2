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
        Expression<Func<VideoJuego, bool>> filtro = x => true;
        RepositorioBase<VideoJuego> repositorio = new RepositorioBase<VideoJuego>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Desde.Text = DateTime.Now.ToString("yyyy-MM-dd");
            Hasta.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void Buscar()
        {
            DateTime desde = DateTime.Parse(Desde.Text);
            DateTime hasta = DateTime.Parse(Hasta.Text);

            int id;
            switch (FiltroDropDownList.SelectedIndex)
            {
                case 0: //Todo
                    repositorio.GetList(c => true);
                    break;
                case 1://VideoJuegoId
                    id = Utilidades.Utils.ToInt(CriterioTextBox.Text);
                    filtro = c => c.VideoJuegoId == id;
                    if (FechaCheckBox.Checked == true)
                    {
                        filtro = c => c.VideoJuegoId == id && (c.FechaRegistro >= desde && c.FechaRegistro <= hasta);
                        break;
                    }
                    else
                    {
                        filtro = c => c.VideoJuegoId == id;
                        break;
                    }
                case 2://Titulo
                    if (FechaCheckBox.Checked == true)
                    {
                        filtro = c => c.Titulo.Contains(CriterioTextBox.Text) && (c.FechaRegistro >= desde && c.FechaRegistro <= hasta);
                        break;
                    }
                    else
                    {
                        filtro = c => c.Titulo.Contains(CriterioTextBox.Text);
                        break;
                    }
                case 3: ///Descripcion
                    if (FechaCheckBox.Checked == true)
                    {
                        filtro = c => c.Descripcion.Contains(CriterioTextBox.Text) && (c.FechaRegistro >= desde && c.FechaRegistro <= hasta);
                        break;
                    }
                    else
                    {
                        filtro = c => c.Descripcion.Contains(CriterioTextBox.Text);
                        break;
                    }
                case 4: //plataforma
                    if (FechaCheckBox.Checked == true)
                    {
                        filtro = c => c.Plataforma.Contains(CriterioTextBox.Text) && (c.FechaRegistro >= desde && c.FechaRegistro <= hasta);
                        break;
                    }
                    else
                    {
                        filtro = c => c.Plataforma.Contains(CriterioTextBox.Text);
                        break;
                    }
                case 5://Genero
                    if (FechaCheckBox.Checked == true)
                    {
                        filtro = c => c.Genero.Contains(CriterioTextBox.Text) && (c.FechaRegistro >= desde && c.FechaRegistro <= hasta);
                        break;
                    }
                    else
                    {
                        filtro = c => c.Genero.Contains(CriterioTextBox.Text);
                        break;
                    }
                case 6://Cantidad
                    if (FechaCheckBox.Checked == true)
                    {
                        filtro = c => c.CantidadEjemplares.Equals(Convert.ToString(CriterioTextBox.Text)) && (c.FechaRegistro >= desde && c.FechaRegistro <= hasta);
                        break;
                    }
                    else
                    {
                        filtro = c => c.CantidadEjemplares.Equals(Convert.ToString(CriterioTextBox.Text));
                        break;
                    }
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
