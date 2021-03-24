using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Logic.Domain;
using Logic;

namespace COMPLETE_FLAT_UI.Presentaciones.alumno
{
    public partial class FormAsistencia : Form
    {

        Clase clase = new Clase();
        private int renglon = -1;
        private int idClase=-1;
        public FormAsistencia()
        {
            InitializeComponent();
            ListEstadosAsistencia();

        }

        private void FormAsistencia_Load(object sender, EventArgs e)
        {
            ShowClasesDeAlumno();
        }

        //-------Movimiento de ventana---------------

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //-------------------------------------------

        /// <summary>
        /// lista los estados de Asistencia del alumno(Ausente,Presente,Completo,imcompleto)
        /// </summary>
        public void ListEstadosAsistencia()
        {
            Estados estadosPresente = new Estados();
            cmbAsistencia.DataSource = estadosPresente.ListingEstadosP("");
            cmbAsistencia.ValueMember = "Id";
            cmbAsistencia.DisplayMember = "EstadoP";
        }


        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowClasesDeAlumno()
        {


            clase.IdAlumno = Convert.ToInt32(txtIdAlumno.Text);
            dataGridViewClasesAsistencia.DataSource = clase.ListingClasesPorIdAlumno(clase);
            dataGridViewClasesAsistencia.Columns[0].Visible = false;
            dataGridViewClasesAsistencia.Columns[7].Visible = false;
            dataGridViewClasesAsistencia.Columns[8].Visible = false;
            dataGridViewClasesAsistencia.Columns[9].Visible = false;
            dataGridViewClasesAsistencia.Columns[1].HeaderText = "ID";
            dataGridViewClasesAsistencia.Columns[2].HeaderText = "NOMBRE";
            dataGridViewClasesAsistencia.Columns[3].HeaderText = "APELLIDO";
            dataGridViewClasesAsistencia.Columns[4].HeaderText = "Nº CLASE";
            dataGridViewClasesAsistencia.Columns[5].HeaderText = "FECHA";
            dataGridViewClasesAsistencia.Columns[6].HeaderText = "HORA";
            dataGridViewClasesAsistencia.Columns[10].HeaderText = "ASISTENCIA";


        }
        private void dataGridViewClasesAsistencia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex;
            
        }

        private void dataGridViewClasesAsistencia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idClase = Convert.ToInt32(dataGridViewClasesAsistencia.Rows[renglon].Cells[0].Value.ToString());
                btnCambiar.BackColor = Color.Turquoise;
            }
            catch (Exception ex)
            {

                FormInformacion frmError = new FormInformacion("ERROR: SELECCIONE UNA FILA");
                frmError.ShowDialog();
                //MessageBox.Show("No se pudo guardar el registro" + ex);

            }
        }

        private void btnCambiar_Click(object sender, EventArgs e)
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
                        ShowClasesDeAlumno();
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
     }

       
 }
