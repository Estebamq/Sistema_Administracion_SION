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

namespace COMPLETE_FLAT_UI.Presentaciones
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLblEditar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelEditarPerfil.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelEditarPerfil.Visible = false;
        }
    }
}
