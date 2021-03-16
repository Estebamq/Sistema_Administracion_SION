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

namespace COMPLETE_FLAT_UI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        //EVENTOS PARA CREAR UN PLACEHOLDER EN EL FORMULARIO DE LOGIN
        
        //cambia el usuario en vacio cuando aparece el cursor
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
            }
        }

        //Vuelve a la normalidad el cuadro de texto, si esta vacio escribe USUARIO
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
            }
        }

        //Oculta la contraseña, si el cursor esta en el cuadro de texto lo cambia a vacio
        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                //ocultar contraseña
                txtPass.PasswordChar = '●';
            }

        }

        //Vuelve la Palabra CONTRASEÑA al cuadro de texto
        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                // volver el texto a la normalidada
                txtPass.PasswordChar = '\0';
            }
        }



        //Cierra el cuadro de Login
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Boton de Login, verifica que se ingreso datos y valida el nombre de usuario y contraseña
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "USUARIO") 
            {
                if(txtPass.Text != "CONTRASEÑA") 
                {
                    //instaciamos usuario y verificamos si el login es valido
                    Usuario usuario = new Usuario();
                    bool loginValido = usuario.LoginUsuario(txtUsuario.Text,txtPass.Text);
                    if (loginValido == true) 
                    {
                        FormMenuPrincipal menuPrincipal = new FormMenuPrincipal();
                        menuPrincipal.Show();
                        this.Hide();
                    }
                    else 
                    {
                        MsjError("Nombre de Usuario o Contraseña incorrecto. \n Intentelo nuevamente");
                        txtPass.Clear();
                        txtUsuario.Focus();
                    }
                        
                }
                else 
                {
                    MsjError("Por Favor, ingrese su contraseña.");
                }

            }
            else 
            {
                MsjError("Por favor, ingrese su nombre de usuario.");
            }
        }

        //crea un mensaje de error
        private void MsjError(string mensajeError) 
        {
            lblErrorMensaje.Text = mensajeError;
            lblErrorMensaje.Visible = true;
        }

       
    }
}
