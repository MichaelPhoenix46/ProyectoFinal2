using BLL;
using Entities;
using FinalProject2.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject2.Consultas
{
    public partial class CMiembro : System.Web.UI.Page
    {
        Expression<Func<Miembro, bool>> filtro = x => true;
        RepositorioBase<Miembro> repositorio = new RepositorioBase<Miembro>();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Desde.ReadOnly = true;
            //Hasta.ReadOnly = true;

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
                case 1://MiembroId
                    id = Utils.ToInt(CriterioTextBox.Text);
                    if (FechaCheckBox.Checked == true)
                    {
                        filtro = c => c.MiembroId == id && (c.FechaRegistro >= desde && c.FechaRegistro <= hasta);
                        break;
                    }
                    else
                    {
                        filtro = c => c.MiembroId == id;
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
                case 4: //Direcccion
                    if (FechaCheckBox.Checked == true)
                    {
                        filtro = c => c.Direccion.Contains(CriterioTextBox.Text) && (c.FechaRegistro >= desde && c.FechaRegistro <= hasta);
                        break;
                    }
                    else
                    {
                        filtro = c => c.Direccion.Contains(CriterioTextBox.Text);
                        break;
                    }
                case 5://telefono
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
                case 6:

                    if (FechaCheckBox.Checked == true)
                    {
                        filtro = c => c.FechaRegistro >= desde && c.FechaRegistro <= hasta;
                        break;
                    }
                    else { break; }
            }

            DatosGridView.DataSource = repositorio.GetList(filtro);
            DatosGridView.DataBind();
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            if (CriterioTextBox.Text == string.Empty && FiltroDropDownList.Text != "Todo")
                Utils.ShowToastr(this.Page, "Debe agregar un criterio", "Error", "error");
            else
            {
                Buscar();
                if (DatosGridView.Rows.Count == 0)
                    Utils.ShowToastr(this.Page, "No se ha efectuado la busqueda", "Error", "error");
                else
                    Utils.ShowToastr(this.Page, "Busqueda completa", "Exito", "success");
            }
        }


    }
}
