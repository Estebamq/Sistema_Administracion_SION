using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Logic.Domain;
using COMPLETE_FLAT_UI.Presentaciones;


namespace COMPLETE_FLAT_UI
{
    public partial class FormMantCliente : Form
    {
        Alumno alumno = new Alumno();
       
        public bool update = false;
        public FormMantCliente()
        {
            InitializeComponent();
            ListEstadosAlumnos();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void ListEstadosAlumnos()
        {
            Estados estadosA = new Estados();
            cmbEstadosAlumnos.DataSource = estadosA.ListingEstadosA("");
            cmbEstadosAlumnos.ValueMember = "Id";
            cmbEstadosAlumnos.DisplayMember = "EstadoA";
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMantCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnGuarda_Click(object sender, EventArgs e)
        {
            FormInformacion frm = new FormInformacion("DESEA GUARDAR LOS CAMBIOS");
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (update == false)
                {
                    try
                    {
                        alumno.Nombre = txtNombre.Text;
                        alumno.Apellido = txtApellido.Text;
                        alumno.Dni = Convert.ToInt32(txtDni.Text);
                        alumno.Telefono = Convert.ToInt32(txtTelefono.Text);
                        alumno.Direccion = txtDireccion.Text;
                        alumno.Email = txtEmail.Text;
                        alumno.Estado = Convert.ToInt32(cmbEstadosAlumnos.SelectedValue);
                        alumno.FechaDeNacimiento = dateTimePickerAlumnos.Value;// ingresa la fecha de nacimiento usando un dateTimePicker
                        alumno.Observaciones = txtObservaciones.Text;
                        alumno.CreatingAlumno(alumno);

                        FormConfirmacion frmConfirm = new FormConfirmacion("SE GUARDARON CON EXITO");
                        DialogResult resultConfirm = frmConfirm.ShowDialog();

                        if (resultConfirm == DialogResult.OK)
                        {
                            this.Close();
                        }

                    }
                    catch (Exception ex)
                    {
                        FormInformacion frmError = new FormInformacion("ERROR: DATOS INCORRECTOS");
                        frmError.ShowDialog();
                        //MessageBox.Show("No se pudo guardar el registro" + ex);
                    }
                }

                if (update == true)
                {
                    try
                    {
                        alumno.Id = Convert.ToInt32(txtId.Text);
                        alumno.Nombre = txtNombre.Text;
                        alumno.Apellido = txtApellido.Text;
                        alumno.Dni = Convert.ToInt32(txtDni.Text);
                        alumno.Telefono = Convert.ToInt32(txtTelefono.Text);
                        alumno.Direccion = txtDireccion.Text;
                        alumno.Email = txtEmail.Text;
                        alumno.Estado = Convert.ToInt32(cmbEstadosAlumnos.SelectedValue);
                        alumno.FechaDeNacimiento = dateTimePickerAlumnos.Value;
                        alumno.Observaciones = txtObservaciones.Text;

                        alumno.UpdatingAlumno(alumno);


                        FormConfirmacion frmConfirm = new FormConfirmacion("SE GUARDARON CON EXITO");
                        DialogResult resultConfirm = frmConfirm.ShowDialog();

                        if (resultConfirm == DialogResult.OK)
                        {
                            this.Close();
                        }

                        update = false;
                    }
                    catch (Exception ex)
                    {
                        FormInformacion frmError = new FormInformacion("ERROR: DATOS INCORRECTOS");
                        frmError.ShowDialog();
                        //MessageBox.Show("No se pudo editar el registro" + ex);
                    }
                }
            }
        }

        
    }
}
