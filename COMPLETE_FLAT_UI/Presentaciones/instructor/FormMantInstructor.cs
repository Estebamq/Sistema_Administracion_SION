using Logic;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Logic.Domain;
using System.Text.RegularExpressions;

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

                        if (validarTextBoxs())
                        {
                            if (ValidarEmail(instructor.Email))
                            {
                                instructor.CreatingInstructor(instructor);

                                FormConfirmacion frmConfirm = new FormConfirmacion("SE GUARDARON CON EXITO");
                                DialogResult resultConfirm = frmConfirm.ShowDialog();

                                if (resultConfirm == DialogResult.OK)
                                {
                                    this.Close();
                                }
                            }
                            else
                            {
                                FormInformacion frmError = new FormInformacion("EMAIL INCORRECTO");
                                frmError.ShowDialog();
                            }

                        }
                        else
                        {
                            FormInformacion frmError = new FormInformacion("DEBE LLENAR TODOS LOS CAMPOS");
                            frmError.ShowDialog();
                        }

                    }
                    catch (Exception)
                    {
                        FormInformacion frmError = new FormInformacion("ERROR: DATOS INCORRECTOS");
                        frmError.ShowDialog(); 
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

                        if (validarTextBoxs())
                        {
                            if (ValidarEmail(instructor.Email))
                            {
                                instructor.UpdatingInstructor(instructor);

                                FormConfirmacion frmConfirm = new FormConfirmacion("SE GUARDARON CON EXITO");
                                DialogResult resultConfirm = frmConfirm.ShowDialog();

                                if (resultConfirm == DialogResult.OK)
                                {
                                    this.Close();
                                }

                                updateInstructor = false;
                            }
                            else
                            {
                                FormInformacion frmError = new FormInformacion("EMAIL INCORRECTO");
                                frmError.ShowDialog();
                            }
                        }
                        else
                        {
                            FormInformacion frmError = new FormInformacion("DEBE LLENAR TODOS LOS CAMPOS");
                            frmError.ShowDialog();
                        }

                    }
                    catch (Exception)
                    {
                        FormInformacion frmError = new FormInformacion("ERROR: DATOS INCORRECTOS");
                        frmError.ShowDialog();

                    }
                }
            }
        
        }
        //VALIDAR TEXTBOX
        bool validarTextBoxs()
        {
            foreach (Control item in this.Controls)
            {
                try
                {
                    if (item is TextBox)
                    {
                        if (item.Enabled == true)
                        {
                            //Codigo comprobacion  de textbox
                            if (String.IsNullOrWhiteSpace(item.Text))
                            {
                                item.Focus();
                                return false;
                            }
                        }
                    }
                }
                catch { }
            }
            return true;
        }

        //validar email
        private Boolean ValidarEmail(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}
