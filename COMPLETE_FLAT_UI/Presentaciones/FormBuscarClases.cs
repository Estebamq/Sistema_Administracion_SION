using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Logic.Domain;



namespace COMPLETE_FLAT_UI.Presentaciones
{
    public partial class FormBuscarClases : Form
    {
        Clase clase = new Clase();
        ReporteClase reporteClase = new ReporteClase();
        public FormBuscarClases()
        {
            InitializeComponent();   
        }

        private void FormBuscarClases_Load(object sender, EventArgs e)
        {

            Task task = new Task(() =>
            {
                Thread.Sleep(1000);
                chWebBrowser.Load("web.whatsapp.com");
            });
            task.Start();
        }

        public void ShowClasePorIdAlumno()
        {
            clase.IdAlumno = Convert.ToInt32(txtSearchPersonaId.Text);
            dataGridViewPersonas.DataSource = clase.ListingClasesPorIdAlumno(clase);
            dataGridViewPersonas.Columns[0].Visible = false;
            dataGridViewPersonas.Columns[1].HeaderText = "ID";
            dataGridViewPersonas.Columns[2].HeaderText = "NOMBRE";
            dataGridViewPersonas.Columns[3].HeaderText = "APELLIDO";
            dataGridViewPersonas.Columns[4].HeaderText = "Nº CLASE";
            dataGridViewPersonas.Columns[5].HeaderText = "FECHA";
            dataGridViewPersonas.Columns[6].HeaderText = "HORA";
            dataGridViewPersonas.Columns[7].HeaderText = "DIRECCION";
            dataGridViewPersonas.Columns[8].HeaderText = "METODO DE PAGO";
            dataGridViewPersonas.Columns[9].HeaderText = "DESCRIPCION";

        }

        public void ShowClasePorIdInstructor()
        {

            clase.IdInstructor = Convert.ToInt32(txtSearchPersonaId.Text);
            clase.Fecha = DateTime.Today;
            dataGridViewPersonas.DataSource = reporteClase.ListiingInstructorIdPlanilla(clase);
            dataGridViewPersonas.Columns[0].HeaderText = "NOMBRE";
            dataGridViewPersonas.Columns[1].HeaderText = "APELLIDO";
            dataGridViewPersonas.Columns[2].HeaderText = "DIRECCION";
            dataGridViewPersonas.Columns[3].HeaderText = "Nº CLASE";
            dataGridViewPersonas.Columns[4].HeaderText = "FECHA";
            dataGridViewPersonas.Columns[5].HeaderText = "HORA";
            dataGridViewPersonas.Columns[6].HeaderText = "DESCRIPCION";

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWhatsapp_Click(object sender, EventArgs e)
        {
            chWebBrowser.Load("web.whatsapp.com");
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            chWebBrowser.Load("www.facebook.com");
        }

        private void btnInstagram_Click(object sender, EventArgs e)
        {
            chWebBrowser.Load("www.instagram.com");
        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchPersonaId.Text != "")
                {
                    Alumno alumno = new Alumno();
                    dataGridViewInformacionDato.DataSource=alumno.SearchingAlumnoId(txtSearchPersonaId.Text);
                    //Oculta las columnas en informacion de datos de persona
                    dataGridViewInformacionDato.Columns[0].Visible = false;
                    dataGridViewInformacionDato.Columns[5].Visible = false;
                    dataGridViewInformacionDato.Columns[6].Visible = false;
                    dataGridViewInformacionDato.Columns[7].Visible = false;
                    dataGridViewInformacionDato.Columns[8].Visible = false;
                    dataGridViewInformacionDato.Columns[9].Visible = false;
                    dataGridViewInformacionDato.Columns[10].Visible = false;
                   
                    
                    ShowClasePorIdAlumno();
                    
                    lblInformacionDatos.Text = "Datos del Alumno";
                    lblInformacion.Text = "Instructores y  clases";
                    
                }
                else
                {
                    FormInformacion frmError = new FormInformacion("INGRESE ID");
                    frmError.ShowDialog();
                }
            }
            catch(Exception ex) 
            {
                FormInformacion frmError = new FormInformacion("ERROR DE BUSQUEDA");
                frmError.ShowDialog();

            }

        }

        private void btnBuscarInstructor_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchPersonaId.Text != "")
                {
                    
                    Instructor instructor = new Instructor();
                    dataGridViewInformacionDato.DataSource = instructor.SearchingInstructorIdPlanilla(txtSearchPersonaId.Text);
                    dataGridViewInformacionDato.Columns[0].Visible = false;
                    dataGridViewInformacionDato.Columns[1].Visible = false;
                    dataGridViewInformacionDato.Columns[2].Visible = false;
                    dataGridViewInformacionDato.Columns[3].Visible = false;
                    dataGridViewInformacionDato.Columns[7].Visible = false;
                    dataGridViewInformacionDato.Columns[8].Visible = false;
                    dataGridViewInformacionDato.Columns[10].Visible = false;
                    dataGridViewInformacionDato.Columns[11].Visible = false;
                    lblInformacionDatos.Text = "Datos del Instructor";
                    lblInformacion.Text = "Alumnos y clases";
                    ShowClasePorIdInstructor();
                }
                else
                {
                    FormInformacion frmError = new FormInformacion("INGRESE ID");
                    frmError.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                FormInformacion frmError = new FormInformacion("ERROR DE BUSQUEDA");
                frmError.ShowDialog();

            }
        }
    }
}
