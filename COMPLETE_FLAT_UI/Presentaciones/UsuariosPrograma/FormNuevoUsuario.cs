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
using System.Runtime.InteropServices;

namespace COMPLETE_FLAT_UI.Presentaciones.UsuariosPrograma
{
    public partial class FormNuevoUsuario : Form
    {
        public FormNuevoUsuario()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormNuevoUsuario_Load(object sender, EventArgs e)
        {
            ListCargoPersonal();
            ShowUsuariosActivos();
        }

        public void ListCargoPersonal()
        {
            Cargo cargoPersonal = new Cargo();
            cmbBoxCargoPersonal.DataSource = cargoPersonal.ListingCargosPersonal("");
            cmbBoxCargoPersonal.ValueMember = "IdCargo";
            cmbBoxCargoPersonal.DisplayMember = "NombreCargo";
        }
        //MOVER VENTANA
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
      
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //////////////////////////////////////////////////////////////////
        
        void ShowUsuariosActivos() 
        {
            Usuario usuario = new Usuario();

            dataGridViewUsuariosActivos.DataSource = usuario.ListingUsuariosActivos();
            dataGridViewUsuariosActivos.Columns[2].Visible = false;
            dataGridViewUsuariosActivos.Columns[7].Visible = false;
        }
    

        //CREAR USUARIOS

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            try
            {
                usuario.NombreUsuario = txtBoxNombreUsuario.Text;
                if (txtBoxContraseña.Text == txtBoxConfirmarContraseña.Text)
                {
                    usuario.Contraseña = txtBoxContraseña.Text;               
                    usuario.Nombre = txtBoxNombre.Text;
                    usuario.Apellido = txtBoxApellido.Text;
                    usuario.Email = txtBoxEmail.Text;
                    usuario.IdCargo = Convert.ToInt32(cmbBoxCargoPersonal.SelectedValue);
                    if (usuario.CreatingUsuario(usuario)) 
                    {
                        FormInformacion frmError = new FormInformacion("EXISTE EL NOMBRE DE USUARIO");
                        frmError.ShowDialog();
                    }
                    else 
                    {
                        FormConfirmacion frmConfirm = new FormConfirmacion("SE CREO CON EXITO");
                        frmConfirm.ShowDialog();
                        ClearDatos();
                        ShowUsuariosActivos();
                    }
                }
                else 
                {
                    FormInformacion frmError = new FormInformacion("CONTRASEÑAS NO COINCIDEN");
                    frmError.ShowDialog();
                }

            }
            catch (Exception)
            {
                FormInformacion frmError = new FormInformacion("ERROR");
                frmError.ShowDialog();

            }
        }

        //Limpia los datos del txtBox
        private void ClearDatos() 
        {
            txtBoxNombreUsuario.Clear();
            txtBoxContraseña.Clear();
            txtBoxConfirmarContraseña.Clear();
            txtBoxNombre.Clear();
            txtBoxApellido.Clear();
            txtBoxEmail.Clear();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Eliminar usuario
        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
