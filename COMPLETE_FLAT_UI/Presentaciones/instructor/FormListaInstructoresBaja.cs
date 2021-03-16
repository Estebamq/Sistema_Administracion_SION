using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Logic.Domain;

namespace COMPLETE_FLAT_UI.Presentaciones.instructor
{
    public partial class FormListaInstructoresBaja : Form
    {
        private List<Estados> listEstadosI = new List<Estados>();
        private Estados estados = new Estados();
        Instructor instructor = new Instructor();
        public FormListaInstructoresBaja()
        {
            InitializeComponent();
            ShowInstructoresBaja();
            HideWidthColumns();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void HideWidthColumns()
        {
            dataGridViewInstructoresBaja.Columns[7].Visible = false;
          
        }
        public void ShowInstructoresBaja()
        {
            listEstadosI = estados.ListingEstadosI("");
            foreach (Estados estado in listEstadosI)
            {
                if (estado.EstadoI == "Baja")
                {
                    instructor.Estado = estado.Id;
                }
            }

            dataGridViewInstructoresBaja.DataSource = instructor.ListingInstructoresPorEstado(instructor);
            dataGridViewInstructoresBaja.Columns[0].HeaderText = "ID";
            dataGridViewInstructoresBaja.Columns[1].HeaderText = "NOMBRE";
            dataGridViewInstructoresBaja.Columns[2].HeaderText = "APELLIDO";
            dataGridViewInstructoresBaja.Columns[3].HeaderText = "DNI";
            dataGridViewInstructoresBaja.Columns[4].HeaderText = "TELEFONO";
            dataGridViewInstructoresBaja.Columns[5].HeaderText = "DIRECCION";
            dataGridViewInstructoresBaja.Columns[6].HeaderText = "EMAIL";
            dataGridViewInstructoresBaja.Columns[8].HeaderText = "ESTADO";
            dataGridViewInstructoresBaja.Columns[9].HeaderText = "MODELO DE AUTO";
            dataGridViewInstructoresBaja.Columns[10].HeaderText = "PATENTE";
            dataGridViewInstructoresBaja.Columns[11].HeaderText = "VENCIMIENTO SEGURO";

        }

        private void btnEditarInstructor_Click(object sender, EventArgs e)
        {
            FormMantInstructor frm = new FormMantInstructor();
            frm.updateInstructor = true;
            if (dataGridViewInstructoresBaja.SelectedRows.Count > 0)
            {
                frm.txtId.Text = dataGridViewInstructoresBaja.CurrentRow.Cells[0].Value.ToString();
                frm.txtNombre.Text = dataGridViewInstructoresBaja.CurrentRow.Cells[1].Value.ToString();
                frm.txtApellido.Text = dataGridViewInstructoresBaja.CurrentRow.Cells[2].Value.ToString();
                frm.txtDni.Text = dataGridViewInstructoresBaja.CurrentRow.Cells[3].Value.ToString();
                frm.txtTelefono.Text = dataGridViewInstructoresBaja.CurrentRow.Cells[4].Value.ToString();
                frm.txtDireccion.Text = dataGridViewInstructoresBaja.CurrentRow.Cells[5].Value.ToString();
                frm.txtEmail.Text = dataGridViewInstructoresBaja.CurrentRow.Cells[6].Value.ToString();
                frm.cmbEstadoInstructor.Text = dataGridViewInstructoresBaja.CurrentRow.Cells[8].Value.ToString();
                frm.txtModeloAuto.Text = dataGridViewInstructoresBaja.CurrentRow.Cells[9].Value.ToString();
                frm.txtPatente.Text = dataGridViewInstructoresBaja.CurrentRow.Cells[10].Value.ToString();
                frm.dateTimePickerVencimientoSeguro.Text = dataGridViewInstructoresBaja.CurrentRow.Cells[11].Value.ToString();
                frm.ShowDialog();
                ShowInstructoresBaja();
            }
            else
            {
                FormInformacion frmError = new FormInformacion("SELECCIONE UNA FILA POR FAVOR");
                frmError.ShowDialog();
                // MessageBox.Show("seleccione una fila por favor");
            }
        }

        private void btnEliminarInstructor_Click(object sender, EventArgs e)
        {

            if (dataGridViewInstructoresBaja.SelectedRows.Count > 0)
            {
                FormInformacion frm = new FormInformacion("DESEA ELIMINAR EL ALUMNO");
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    instructor.Id = Convert.ToInt32(dataGridViewInstructoresBaja.CurrentRow.Cells[0].Value.ToString());
                    instructor.DeletingInstructor(instructor);
                    ShowInstructoresBaja();
                }
            }
            else
            {
                FormInformacion frmError = new FormInformacion("SELECCIONE UNA FILA POR FAVOR");
                frmError.ShowDialog();
                // MessageBox.Show("seleccione una fila por favor");
            }
        }
    }
}
