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

namespace COMPLETE_FLAT_UI.Presentaciones.UsuariosPrograma
{
    public partial class FormMediosDePago : Form
    {
        public FormMediosDePago()
        {
            InitializeComponent();
        }
        private void FormMediosDePago_Load(object sender, EventArgs e)
        {
            ShowMediosDePago();
        }


        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowMediosDePago() 
        {
            MetodosDePago metodosDePago = new MetodosDePago();

            dataGridViewMedioDePago.DataSource = metodosDePago.ListingTodosLosMetodosDePago();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtBoxNuevoMedioDePago.Clear();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarTextBoxs()) 
            {
                MetodosDePago metodosDePago = new MetodosDePago();
                metodosDePago.CreatingMedioDePago(txtBoxNuevoMedioDePago.Text);
                FormConfirmacion frmConfirm = new FormConfirmacion("SE CREO CON EXITO");
                frmConfirm.ShowDialog();
                ShowMediosDePago();

            }
            else 
            {
                FormInformacion frmError = new FormInformacion("INGRESE NUEVO MEDIO DE PAGO");
                frmError.ShowDialog();
            }
            
        }

        //VALIDAR TEXBOX

        bool validarTextBoxs()
        {
            foreach (Control item in this.Controls)
            {
                try
                {
                    if (item is TextBox)
                    {
                        //Codigo comprobacion  de textbox
                        if (String.IsNullOrWhiteSpace(item.Text))
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {

  
            if (dataGridViewMedioDePago.SelectedRows.Count > 0)
            {
                MetodosDePago metodosDePago = new MetodosDePago();
                int idMetodoDePago = Convert.ToInt32(dataGridViewMedioDePago.CurrentRow.Cells[0].Value.ToString());
                FormInformacion frm = new FormInformacion($"DESEA ELIMINAR El MEDIO DE PAGO ");
                DialogResult result = frm.ShowDialog();

                if (idMetodoDePago!= 1)
                {
                    if (result == DialogResult.OK)
                    {

                        metodosDePago.DeletingMedioDePago(idMetodoDePago);
                        FormConfirmacion frmConfirm = new FormConfirmacion("MEDIO DE PAGO  ELIMINADO");
                        frmConfirm.ShowDialog();
                        ShowMediosDePago();
                    }
                }
                else
                {
                    FormInformacion frmError = new FormInformacion("NO PUEDE ELIMINAR ESTE MEDIO DE PAGO");
                    frmError.ShowDialog();
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
