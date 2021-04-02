using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Logic.Domain;
using Logic.Cache;
using COMPLETE_FLAT_UI.Presentaciones.UsuariosPrograma;

namespace COMPLETE_FLAT_UI.Presentaciones
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }
        private void FormUsuario_Load(object sender, EventArgs e)
        {
            LoadDataUser();
            InicializarPassControl();
        }

        private void LoadDataUser() 
        {
            //view
            Cargo cargoUsuario = new Cargo();
            cargoUsuario= cargoUsuario.ListingCargosPersonalId(UserLoginCache.cargo);
            lblInputnombreUsuario.Text = UserLoginCache.nombreUsuario;
            lblinputNombre.Text =UserLoginCache.nombre;
            lblInputApellido.Text = UserLoginCache.apellido;
            lblInputCargo.Text = cargoUsuario.NombreCargo;
            lblInputEmail.Text = UserLoginCache.email;


            //Editar Perfil

            txtBoxNombreUsuario.Text = UserLoginCache.nombreUsuario;
            txtBoxNombre.Text = UserLoginCache.nombre;
            txtBoxApellido.Text = UserLoginCache.apellido;
            txtBoxEmail.Text = UserLoginCache.email;
            txtBoxNuevaContraseña.Text = UserLoginCache.password;
            txtBoxConfirmarContraseña.Text = UserLoginCache.password;
            txtBoxContraseñaActual.Text = "";


        }

        private void InicializarPassControl() 
        {
            LinkLabelEditarPass.Text = "Editar";
            txtBoxNuevaContraseña.Enabled = false;
            txtBoxConfirmarContraseña.Enabled = false;
            txtBoxNuevaContraseña.Text = UserLoginCache.password;
            txtBoxConfirmarContraseña.Text = UserLoginCache.password;
        }

        private void Reset() 
        {
            LoadDataUser();
            InicializarPassControl();

        }
        private void LinkLabelEditarPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LinkLabelEditarPass.Text == "Editar")
            {
                LinkLabelEditarPass.Text = "Cancelar";
                txtBoxNuevaContraseña.Enabled = true;
                txtBoxNuevaContraseña.Text = "";
                txtBoxConfirmarContraseña.Enabled = true;
                txtBoxConfirmarContraseña.Text = "";

            }
            else if (LinkLabelEditarPass.Text == "Cancelar")
            {
                InicializarPassControl();
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            bool desea_respaldar = true;
            Usuario usuarioBackup = new Usuario();

            //poner cursor de relojito mintras respalda
            Cursor.Current = Cursors.WaitCursor;

            if (Directory.Exists(@"c:\ Respaldo"))
            {
                if (File.Exists(@"c:\ Respaldo\resp.bak"))
                {
                    FormInformacion frm = new FormInformacion("EXISTE UN BACKUP DESEA REMPLAZARLO");
                    DialogResult result = frm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        File.Delete(@"c:\ Respaldo\resp.bak");
                    }
                    else
                    {
                        desea_respaldar = false;
                    }
                }
            }
            else
            {
                Directory.CreateDirectory(@"c:\ Respaldo");
            }

            if (desea_respaldar)
            {
                if (usuarioBackup.GeneratingBackUp())
                {
                    FormConfirmacion frmConfirm = new FormConfirmacion("BACKUP: SE GENERO CON EXITO");
                    DialogResult resultConfirm = frmConfirm.ShowDialog();
                }

            }
        }
       

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void linkLblEditar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelEditarPerfil.Visible = true;
        }



        //BOTONES CREAR: NUEVO USUARIO, NUEVO METODO DE PAGO

        private void btnCrearNuevoUsuario_Click(object sender, EventArgs e)
        {
            FormNuevoUsuario frm = new FormNuevoUsuario();
            frm.ShowDialog();
        }

       

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (txtBoxNuevaContraseña.TextLength>4)
            {
                if (txtBoxNuevaContraseña.Text == txtBoxConfirmarContraseña.Text)
                 {
                    if (txtBoxContraseñaActual.Text == UserLoginCache.password)
                    {
                        Usuario usuario = new Usuario(
                            userId: UserLoginCache.idUser,
                            nombreUsuario: txtBoxNombreUsuario.Text,
                            contraseña: txtBoxNuevaContraseña.Text,
                            nombre: txtBoxNombre.Text,
                            apellido: txtBoxApellido.Text,
                            email: txtBoxEmail.Text
                            );
                        if (validarTextBoxs()) { 
                            usuario.UpdatingUsuario(usuario);
                            Reset();
                            panelEditarPerfil.Visible = false;
                            FormConfirmacion frmConfirm = new FormConfirmacion("SE ACTUALIZO CON EXITO");
                            DialogResult resultConfirm = frmConfirm.ShowDialog();


                        }
                        else
                        {
                            FormInformacion frmError = new FormInformacion("DEBE LLENAR TODOS LOS CAMPOS");
                           frmError.ShowDialog();
                        }

                     }
                }
                else
                {
                    FormInformacion frmError = new FormInformacion("LAS CONTRASEÑAS NO COINCIDEN");
                    frmError.ShowDialog();
                }
            }
            else
            {
                FormInformacion frmError = new FormInformacion("NUEVA CONTRASEÑA INSEGURA: MIN 5 CARACTERES");
                frmError.ShowDialog();
            }
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelEditarPerfil.Visible = false;
            Reset();
        }

        bool validarTextBoxs()
        {
            foreach (Control item in panelEditarPerfil.Controls)
            {
                try
                {
                    if (item is TextBox)
                    {
                        //Codigo comprobacion  de textbox
                        if (item.Text == "")
                        {
                            item.Focus();
                            return false;
                        }
                    }
                }
                catch { }
            }
            return true;
        }


    }
}
