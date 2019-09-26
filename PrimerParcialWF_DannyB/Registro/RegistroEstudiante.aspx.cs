using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrimerParcialWF_DannyB.Registro
{
    public partial class RegistroEstudiante : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                RepositorioBase<Estudiante> repositorioBase = new RepositorioBase<Estudiante>();
                ViewState["Estudiante"] = new Estudiante();
            }

        }

        public void BindGrid()
        {
            DetalleGridView.DataSource = ((Estudiante)ViewState["Estudainte"]).Detalle;
            DetalleGridView.DataBind();
        }

        public Estudiante LlenaClase()
        {
            Estudiante e = new Estudiante();
            e = (Estudiante)ViewState["Estudiante"];
            e.EstudianteID = Utilitarios.Utils1.ToInt(IDTextBox.Text);
            e.Fecha = Utilitarios.Utils1.ToDateTime(FechaTextBox.Text);
            e.Nombre = NombreTextBox.Text;
            e.Valor = Utilitarios.Utils1.ToInt(ValorTextBox.Text);
            e.Logrado = Utilitarios.Utils1.ToDecimal(LogradoTextBox.Text);
            e.Total = Utilitarios.Utils1.ToDecimal(TotalTextBox.Text);

            return e;
        }

        public void Llenarcampo(Estudiante e)
        {
            IDTextBox.Text = e.EstudianteID.ToString();
            NombreTextBox.Text = e.Nombre;
            FechaTextBox.Text = e.Fecha.ToLongDateString();
            ValorTextBox.Text = e.Valor.ToString();
            LogradoTextBox.Text = e.ToString();
            TotalTextBox.Text = e.Total.ToString();
            this.BindGrid();
        }

        public void Limpiar()
        {
            IDTextBox.Text = "";
            NombreTextBox.Text = "";
            FechaTextBox.Text = "";
            ValorTextBox.Text = "";
            LogradoTextBox.Text = "";
            TotalTextBox.Text = "";

        }
        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Estudiante estudiante = LlenaClase();
            EstudianteRepositorio repositorio = new EstudianteRepositorio();
            if (Utilitarios.Utils1.ToInt(IDTextBox.Text) == 0)
                paso = true;
            else
                paso = repositorio.Modificar(estudiante);

            if (paso)
            {
                Utilitarios.Utils1.ShowToastr(this, "Exito", "Exito", "sucess");
                Limpiar();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EstudianteRepositorio repositorio = new EstudianteRepositorio();
            var estudiante = repositorio.Buscar(Utilitarios.Utils1.ToInt(IDTextBox.Text);
            if (estudiante != null)
            {
                Llenarcampo(estudiante);
                Utilitarios.Utils1.ShowToastr(this, "Busqueda Exitoxa","Exito","sucess");
            }
            else
            {
                Limpiar();
                Utilitarios.Utils1.ShowToastr(this, "Busqueda Erronea", "erro", "error");

            }
        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante();
            estudiante = (Estudiante)ViewState["Estudiante"];
            estudiante.AgregarDetalle(0, estudiante.EstudianteID);
            ViewState["Estudiante"] = estudiante;
            this.BindGrid();
            TotalTextBox.Text = "";
        }

      
    }
}