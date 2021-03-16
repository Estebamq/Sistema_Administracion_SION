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


namespace COMPLETE_FLAT_UI.Presentaciones
{
    public partial class FormBuscarClases : Form
    {
        Clase clase = new Clase();
        public FormBuscarClases()
        {
            InitializeComponent();
            
            
        }

        private void FormBuscarClases_Load(object sender, EventArgs e)
        {
            Task task = new Task(() =>
            {
                Thread.Sleep(0060);
                chWebBrowser.Load("web.whatsapp.com");
            });
            task.Start();
        }

        public void ShowClasPorIdAlumno()
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
                    ShowClasPorIdAlumno();
                    lblInformacion.Text = "Datos de los Instructores y clases";
                    
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

        
    }
}
