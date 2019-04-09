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
    public partial class RRenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                RepositorioBase<Miembro> repositorioBase = new RepositorioBase<Miembro>();
                RepositorioBase<VideoJuego> repositorioBasev = new RepositorioBase<VideoJuego>();

                MiembroDropDownList.DataSource = repositorioBase.GetList(t => true);
                MiembroDropDownList.DataValueField = "MiembroId";
                MiembroDropDownList.DataTextField = "Nombre";
                MiembroDropDownList.DataBind();

                JuegoDropDownList.DataSource = repositorioBasev.GetList(t => true);
                JuegoDropDownList.DataValueField = "VideoJuegoId";
                JuegoDropDownList.DataTextField = "Titulo";
                JuegoDropDownList.DataBind();

                ViewState["Renta"] = new Renta();


            }
        }

        protected void BindGrid()
        {
            DetalleGridView.DataSource = ((Renta)ViewState["Renta"]).Detalles;
            DetalleGridView.DataBind();
        }

        public Renta LlenarClase()
        {
            Renta renta = new Renta();

            renta = (Renta)ViewState["Renta"];

            renta.Pago = Convert.ToDecimal(PagoTextBox.Text);
            renta.Devuelta = Convert.ToDecimal(PagoTextBox.Text);
            renta.FechaRegistro = Utils.ToDate(FechaTextBox.Text);
            renta.FechaDevuelta = Utils.ToDate(FechaDevueltaTextBox.Text);
            renta.MiembroId = Convert.ToInt32(MiembroDropDownList.SelectedValue);
            renta.RentaId = Convert.ToInt32(RentaIdTextBox.Text);
            renta.Importe = Convert.ToDecimal(PagoTextBox.Text);


            return renta;
        }

        private void Limpiar()
        {

            RentaIdTextBox.Text = "";
            FechaTextBox.Text = Convert.ToString(DateTime.Now);
            MiembroDropDownList.Text = string.Empty;
            DevueltaTextBox.Text = Convert.ToString(DateTime.Today.AddDays(7));
            ImporteTextBox.Text = "";
            PagoTextBox.Text = "0";
            ViewState["Renta"] = new Renta();
            this.BindGrid();

        }

        public void LlenarCampos(Renta renta)
        {

            RentaIdTextBox.Text = Convert.ToString(renta.RentaId);
            PagoTextBox.Text = Convert.ToString(renta.Pago);
            DevueltaTextBox.Text = Convert.ToString(renta.Devuelta);
            FechaTextBox.Text = Convert.ToString(renta.FechaRegistro);
            FechaDevueltaTextBox.Text = Convert.ToString(renta.FechaDevuelta);
            ImporteTextBox.Text = Convert.ToString(renta.Importe);
            MiembroDropDownList.Text = Convert.ToString(renta.MiembroId);

            this.BindGrid();
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            RentaRepositorio repositorio = new RentaRepositorio();

            var renta = repositorio.Buscar(
                Utils.ToInt(RentaIdTextBox.Text));
            if (renta != null)
            {
                LlenarCampos(renta);
                Utils.ShowToastr(this, "Busqueda exitosa", "Exito");
            }
            else
            {
                Limpiar();
                Utils.ShowToastr(this,
                    "No se pudo encontrar la renta especificada",
                    "Error", "error");
            }
        }

            protected void GuardarButton_Click(object sender, EventArgs e)
            {
                bool paso = false;
                RentaRepositorio repositorio = new RentaRepositorio();
                //todo: agregar demas validaciones
                Renta renta = LlenarClase();

                if (Utils.ToInt(RentaIdTextBox.Text) == 0)
                    paso = repositorio.Guardar(renta);

                else
                    paso = repositorio.Modificar(renta);

                if (paso)
                {
                    Utils.ShowToastr(this, "Guardado con exito!!", "Guardado", "success");
                    Limpiar();
                }
            }
        

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            Renta renta = new Renta();
            RentaRepositorio repositorio = new RentaRepositorio();

            if (repositorio.Eliminar(Convert.ToInt32(RentaIdTextBox.Text)))
            {

                Utils.ShowToastr(this, "Eliminado con exito!!", "Exito", "success");
                Limpiar();
            }
            else
                Utils.ShowToastr(this, "Fallo al Eliminar", "Exito", "success");
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void AgregarButton_Click(object sender, EventArgs e)
        {
            Renta renta = new Renta();

            renta = (Renta)ViewState["Renta"];
            renta.AgregarDetalle(0, renta.RentaId,
                    JuegoDropDownList.SelectedIndex, JuegoDropDownList.Text);

            ViewState["Renta"] = renta;

            this.BindGrid();
        }
    }
}