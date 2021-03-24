using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic.Domain;
using Logic;


namespace COMPLETE_FLAT_UI.Presentaciones
{
    public partial class FormDashboard : Form
    {
        private Estados estados = new Estados();
        Clase clase = new Clase();
        private List<Estados> listEstadosAsistencia = new List<Estados>();
        private int renglon = -1;
        private int idClase = -1;
        public FormDashboard()
        {
            InitializeComponent();
            ListEstadosAsistencia();
            ShowClasesDeHoy();
            ShowClasesCertificado();
            ShowInstructoresVencimientoSeguro();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowClasesDeHoy()
        {

            Clase clase = new Clase();
            listEstadosAsistencia = estados.ListingEstadosP("");
            foreach (Estados estado in listEstadosAsistencia)
            {
                if (estado.EstadoP == "Ausente")
                {
                  clase.IdPresente= estado.Id;
                }
            }
            clase.Fecha = DateTime.Today;
            dataGridViewClasesDeHoy.DataSource = clase.ListingClasesDeHoy(clase);
            dataGridViewClasesDeHoy.Columns[0].Visible = false;
            dataGridViewClasesDeHoy.Columns[1].HeaderText = "ID INSTRUCTOR";
            dataGridViewClasesDeHoy.Columns[2].HeaderText = "ID ALUMNO";
            dataGridViewClasesDeHoy.Columns[3].HeaderText = "NOMBRE";
            dataGridViewClasesDeHoy.Columns[4].HeaderText = "APELLIDO";
            dataGridViewClasesDeHoy.Columns[5].HeaderText = "DIRECCION";
            dataGridViewClasesDeHoy.Columns[6].Visible = false;
            dataGridViewClasesDeHoy.Columns[7].HeaderText = "ASISTENCIA";
            dataGridViewClasesDeHoy.Columns[8].HeaderText = "NUM DE CLASE";
            dataGridViewClasesDeHoy.Columns[9].HeaderText = "FECHA";
            dataGridViewClasesDeHoy.Columns[10].HeaderText = "HORA";

        }


        public void ListEstadosAsistencia()
        {
            Estados estadosPresente = new Estados();
            cmbAsistencia.DataSource = estadosPresente.ListingEstadosP("");
            cmbAsistencia.ValueMember = "Id";
            cmbAsistencia.DisplayMember = "EstadoP";
        }

        private void dataGridViewClasesDeHoy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex;
        }

        private void dataGridViewClasesDeHoy_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idClase = Convert.ToInt32(dataGridViewClasesDeHoy.Rows[renglon].Cells[0].Value.ToString());
                btnCambiar.BackColor = Color.Turquoise;
            }catch(Exception ex) 
            {
                FormInformacion frmError = new FormInformacion("ERROR: SELECCIONE UNA FILA");
                frmError.ShowDialog();
            }
        }

        private void btnCambiar_Click_1(object sender, EventArgs e)
        {
            if (idClase != -1)
            {
                FormInformacion frm = new FormInformacion("DESEA GUARDAR LOS CAMBIOS");
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {

                    try
                    {

                        clase.IdPresente = Convert.ToInt32(cmbAsistencia.SelectedValue);
                        clase.Id = idClase;
                        clase.UpdatingAsistenciaClase(clase);
                        FormConfirmacion frmConfirm = new FormConfirmacion("SE ACTUALIZO CON EXITO");
                        DialogResult resultConfirm = frmConfirm.ShowDialog();
                        btnCambiar.BackColor = Color.Crimson;
                        ShowClasesDeHoy();
                    }

                    //SI SURGE UN ERROR EN LA CARGA LO CAPTURAMOS ACA
                    catch (Exception ex)
                    {

                        FormInformacion frmError = new FormInformacion("ERROR: DATOS INCORRECTOS");
                        frmError.ShowDialog();
                        //MessageBox.Show("No se pudo guardar el registro" + ex);

                    }
                    idClase = -1;
                }

            }
            else
            {
                FormInformacion frmError = new FormInformacion("SELECCIONE UNA FILA POR FAVOR");
                frmError.ShowDialog();
            }
        }

        public void ShowClasesCertificado()
        {
            Clase clase = new Clase();
            clase.NumClase = 5;
            clase.Fecha = DateTime.Today;
            dataGridViewCertificados.DataSource = clase.ListingClaseCertificado(clase);
            dataGridViewCertificados.Columns[0].Visible = false;//ID DE CLASE
            dataGridViewCertificados.Columns[1].HeaderText = "ID ALUMNO";
            dataGridViewCertificados.Columns[2].HeaderText = "NOMBRE";
            dataGridViewCertificados.Columns[3].HeaderText = "APELLIDO";
            dataGridViewCertificados.Columns[4].HeaderText = "NUM DE CLASE";
            dataGridViewCertificados.Columns[5].Visible = false;//FECHA
            dataGridViewCertificados.Columns[6].Visible = false;//HORA
            
        }

        public void ShowInstructoresVencimientoSeguro()
        {
                Instructor instructor = new Instructor();
                List<Estados> listEstadosInstructores = new List<Estados>();
                listEstadosInstructores = estados.ListingEstadosI("");
                foreach (Estados estado in listEstadosInstructores)
                {
                    if (estado.EstadoI == "Alta")
                    {
                        instructor.Estado = estado.Id;
                    }
                }
                dataGridViewVencimientoSeguros.DataSource = instructor.ListingInstructorVencimientoSeguro(instructor);
             
                        dataGridViewVencimientoSeguros.Columns[0].Visible = false;
                        dataGridViewVencimientoSeguros.Columns[1].Visible = false;
                        dataGridViewVencimientoSeguros.Columns[2].Visible = false;
                        dataGridViewVencimientoSeguros.Columns[3].Visible = false;
                        dataGridViewVencimientoSeguros.Columns[4].HeaderText = "ID";
                        dataGridViewVencimientoSeguros.Columns[5].HeaderText = "NOMBRE";
                        dataGridViewVencimientoSeguros.Columns[6].HeaderText = "APELLIDO";
                        dataGridViewVencimientoSeguros.Columns[7].Visible = false;
                        dataGridViewVencimientoSeguros.Columns[8].Visible = false;//"ESTADO"
                        dataGridViewVencimientoSeguros.Columns[9].HeaderText = "TELEFONO";
                        dataGridViewVencimientoSeguros.Columns[10].Visible = false;//"PATENTE"
                        dataGridViewVencimientoSeguros.Columns[11].Visible = false; //"VENCIMIENTO SEGURO"
            
           

        }
    }
}

