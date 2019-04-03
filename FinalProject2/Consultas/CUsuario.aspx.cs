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
    public partial class CUsuario : System.Web.UI.Page
    {
        Expression<Func<Usuario, bool>> filtro = x => true;
        RepositorioBase<Usuario> repositorio = new RepositorioBase<Usuario>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Buscar()
        {
            Desde.Text = DateTime.Now.ToString("yyyy-MM-dd");
            Hasta.Text = DateTime.Now.ToString("yyyy-MM-dd");

            DateTime desde = DateTime.Parse(Desde.Text);
            DateTime hasta = DateTime.Parse(Hasta.Text);

            int id;
            switch (FiltroDropDownList.SelectedIndex)
            {
                case 0: //Todo
                    repositorio.GetList(c => true);
                    break;
                case 1://usuarioid
                    id = Utilidades.Utils.ToInt(CriterioTextBox.Text);
                    if (FechaCheckBox.Checked == true)
                    {
                        filtro = c => c.UsuarioId == id && (c.FechaRegistro >= desde && c.FechaRegistro <= hasta);
                        break;
                    }
                    else
                    {
                        filtro = c => c.UsuarioId == id;
                        break;
                    }
                case 2://Nombre
                    if (FechaCheckBox.Checked == true)
                    {
                        filtro = c => c.Nombre.Contains(CriterioTextBox.Text) && (c.FechaRegistro >= desde && c.FechaRegistro <= hasta);
                        break;
                    }
                    else
                    {
                        filtro = c => c.Nombre.Contains(CriterioTextBox.Text);
                        break;
                    }
                case 3: //cedula
                    if (FechaCheckBox.Checked == true)
                    {
                        filtro = c => c.Cedula.Contains(CriterioTextBox.Text) && (c.FechaRegistro >= desde && c.FechaRegistro <= hasta);
                        break;
                    }
                    else
                    {
                        filtro = c => c.Cedula.Contains(CriterioTextBox.Text);
                        break;
                    }
                case 4: //Telefono                    
                    if (FechaCheckBox.Checked == true)
                    {
                        filtro = c => c.Telefono.Contains(CriterioTextBox.Text) && (c.FechaRegistro >= desde && c.FechaRegistro <= hasta);
                        break;
                    }
                    else
                    {
                        filtro = c => c.Telefono.Contains(CriterioTextBox.Text);
                        break;
                    }
                case 5://Nombre de usuario
                    
                    if (FechaCheckBox.Checked == true)
                    {
                        filtro = c => c.UserName.Contains(CriterioTextBox.Text) && (c.FechaRegistro >= desde && c.FechaRegistro <= hasta);
                        break;
                    }
                    else
                    {
                        filtro = c => c.UserName.Contains(CriterioTextBox.Text);
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