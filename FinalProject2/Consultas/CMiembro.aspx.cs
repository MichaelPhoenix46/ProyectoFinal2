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
    public partial class CMiembro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            Expression<Func<Miembro, bool>> filtro = x => true;
            RepositorioBase<Miembro> repositorio = new RepositorioBase<Miembro>();

            int id;
            switch (FiltroDropDownList.SelectedIndex)
            {
                case 0: //Todo
                    repositorio.GetList(c => true);
                    break;
                case 1://MiembroId
                    id = Utilidades.Utils.ToInt(CriterioTextBox.Text);
                    filtro = c => c.MiembroId == id;
                    break;
                case 2://Nombre
                    filtro = c => c.Nombre.Contains(CriterioTextBox.Text);
                    break;
                case 3: //cedula
                    filtro = c => c.Cedula.Contains(CriterioTextBox.Text);
                    break;
                case 4: //Direcccion
                    filtro = c => c.Direccion.Contains(CriterioTextBox.Text);
                    break;
                case 5://telefono
                    filtro = c => c.Telefono.Contains(CriterioTextBox.Text);
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
