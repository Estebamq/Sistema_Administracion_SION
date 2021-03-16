using Logic;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Logic.Domain;

namespace COMPLETE_FLAT_UI.Presentaciones.instructor
{
    public partial class FormMantInstructor : Form
    {
        private Instructor instructor = new Instructor();
        public bool updateInstructor = false;
        public FormMantInstructor()
        {
            InitializeComponent();
            ListEstadosInstructores();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTituloInstructor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void ListEstadosInstructores()
        {
            Estados estadosI = new Estados();
            cmbEstadoInstructor.DataSource = estadosI.ListingEstadosI("");
            cmbEstadoInstructor.ValueMember = "Id";
            cmbEstadoInstructor.DisplayMember = "EstadoI";
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnGuarda_Click(object sender, EventArgs e)
        {

            FormInformacion frm = new FormInformacion("DESEA GUARDAR LOS CAMBIOS");
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (updateInstructor == false)
                {
                    try
                    {
                        instructor.Nombre = txtNombre.Text;
                        instructor.Apellido = txtApellido.Text;
                        instructor.Dni = Convert.ToInt32(txtDni.Text);
                        instructor.Telefono = Convert.ToInt32(txtTelefono.Text);
                        instructor.Direccion = txtDireccion.Text;
                        instructor.Email = txtEmail.Text;
                        instructor.Estado = Convert.ToInt32(cmbEstadoInstructor.SelectedValue);
                        instructor.Patente = txtPatente.Text;
                        instructor.ModeloAuto = txtModeloAuto.Text;
                        instructor.FechaVencimientoSeguro = dateTimePickerVencimientoSeguro.Value;// ingresa la fecha de nacimiento usando un dateTimePicker
                       
                        instructor.CreatingInstructor(instructor);

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
                       // MessageBox.Show("No se pudo guardar el registro" + ex);
                    }
                }

                if (updateInstructor == true)
                {
                    try
                    {
                        instructor.Id = Convert.ToInt32(txtId.Text);
                        instructor.Nombre = txtNombre.Text;
                        instructor.Apellido = txtApellido.Text;
                        instructor.Dni = Convert.ToInt32(txtDni.Text);
                        instructor.Telefono = Convert.ToInt32(txtTelefono.Text);
                        instructor.Direccion = txtDireccion.Text;
                        instructor.Email = txtEmail.Text;
                        instructor.Estado = Convert.ToInt32(cmbEstadoInstructor.SelectedValue);
                        instructor.Patente = txtPatente.Text;
                        instructor.ModeloAuto = txtModeloAuto.Text;
                        instructor.FechaVencimientoSeguro = dateTimePickerVencimientoSeguro.Value;// ingresa la fecha de nacimiento usando un dateTimePicker

                        instructor.UpdatingInstructor(instructor);

                        FormConfirmacion frmConfirm = new FormConfirmacion("SE GUARDARON CON EXITO");
                        DialogResult resultConfirm = frmConfirm.ShowDialog();

                        if (resultConfirm == DialogResult.OK)
                        {
                            this.Close();
                        }

                        updateInstructor = false;
                    }
                    catch (Exception ex)
                    {
                        /*FormInformacion frmError = new FormInformacion("ERROR: DATOS INCORRECTOS");
                        frmError.ShowDialog();*/
                        MessageBox.Show("No se pudo editar el registro" + ex);
                    }
                }
            }
        
        }

        
    }
}
