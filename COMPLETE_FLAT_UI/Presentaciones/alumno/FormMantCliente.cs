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
using System.Text.RegularExpressions;


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
            // estadosA son los estados que el alumno toma (alta/Baja)
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
                        
                        if (validarTextBoxs())
                        {
                            if (ValidarEmail(alumno.Email)) { 
                                alumno.CreatingAlumno(alumno);

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
                        if (validarTextBoxs())
                        {
                            if (ValidarEmail(alumno.Email))
                            {
                                    alumno.UpdatingAlumno(alumno);


                                FormConfirmacion frmConfirm = new FormConfirmacion("SE GUARDARON CON EXITO");
                                DialogResult resultConfirm = frmConfirm.ShowDialog();

                                if (resultConfirm == DialogResult.OK)
                                {
                                    this.Close();
                                }

                                 update = false;

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

        //Validar texbox
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
