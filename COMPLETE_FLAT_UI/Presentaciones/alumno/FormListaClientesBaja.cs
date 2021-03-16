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

namespace COMPLETE_FLAT_UI.Presentaciones.alumno
{
    public partial class FormListaClientesBaja : Form
    {
        private List<Estados> listEstadosA = new List<Estados>();
        private Estados estados = new Estados();
        private Alumno alumno = new Alumno();
        public FormListaClientesBaja()
        {
            InitializeComponent();
            
            ShowAlumnosBaja();
            HideWidthColumns();

        }
        public void HideWidthColumns()
        {
            dataGridViewAlumnosBaja.Columns[7].Visible = false;
        }
        public void ShowAlumnosBaja()
        {
                    
                    listEstadosA = estados.ListingEstadosA("");
                    foreach (Estados estado in listEstadosA)
                    {
                        if (estado.EstadoA == "Baja")
                        {
                            alumno.Estado = estado.Id;
                        }
                    }

                    dataGridViewAlumnosBaja.DataSource = alumno.ListingAlumnosPorEstado(alumno);
                    dataGridViewAlumnosBaja.Columns[0].HeaderText = "ID";
                    dataGridViewAlumnosBaja.Columns[1].HeaderText = "NOMBRE";
                    dataGridViewAlumnosBaja.Columns[2].HeaderText = "APELLIDO";
                    dataGridViewAlumnosBaja.Columns[3].HeaderText = "DNI";
                    dataGridViewAlumnosBaja.Columns[4].HeaderText = "TELEFONO";
                    dataGridViewAlumnosBaja.Columns[5].HeaderText = "DIRECCION";
                    dataGridViewAlumnosBaja.Columns[6].HeaderText = "EMAIL";
                    dataGridViewAlumnosBaja.Columns[8].HeaderText = "ESTADO";
                    dataGridViewAlumnosBaja.Columns[9].HeaderText = "FECHA DE NACIMIENTO";
                    dataGridViewAlumnosBaja.Columns[10].HeaderText = "OBSERVACIONES";
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           
                FormMantCliente frm = new FormMantCliente();
                frm.update = true;
                if (dataGridViewAlumnosBaja.SelectedRows.Count > 0)
                {
                    frm.txtId.Text = dataGridViewAlumnosBaja.CurrentRow.Cells[0].Value.ToString();
                    frm.txtNombre.Text = dataGridViewAlumnosBaja.CurrentRow.Cells[1].Value.ToString();
                    frm.txtApellido.Text = dataGridViewAlumnosBaja.CurrentRow.Cells[2].Value.ToString();
                    frm.txtDni.Text = dataGridViewAlumnosBaja.CurrentRow.Cells[3].Value.ToString();
                    frm.txtTelefono.Text = dataGridViewAlumnosBaja.CurrentRow.Cells[4].Value.ToString();
                    frm.txtDireccion.Text = dataGridViewAlumnosBaja.CurrentRow.Cells[5].Value.ToString();
                    frm.txtEmail.Text = dataGridViewAlumnosBaja.CurrentRow.Cells[6].Value.ToString();
                    frm.cmbEstadosAlumnos.Text = dataGridViewAlumnosBaja.CurrentRow.Cells[8].Value.ToString();
                    frm.dateTimePickerAlumnos.Text = dataGridViewAlumnosBaja.CurrentRow.Cells[9].Value.ToString();
                    frm.txtObservaciones.Text = dataGridViewAlumnosBaja.CurrentRow.Cells[10].Value.ToString();
                    frm.ShowDialog();
                    ShowAlumnosBaja();
                }
                else
                {
                    FormInformacion frmError = new FormInformacion("SELECCIONE UNA FILA POR FAVOR");
                    frmError.ShowDialog();
                    // MessageBox.Show("seleccione una fila por favor");
                }
          
        }

        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {

            if (dataGridViewAlumnosBaja.SelectedRows.Count > 0)
            {
                FormInformacion frm = new FormInformacion("DESEA ELIMINAR EL ALUMNO");
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    alumno.Id = Convert.ToInt32(dataGridViewAlumnosBaja.CurrentRow.Cells[0].Value.ToString());
                    alumno.DeletingAlumno(alumno);
                    ShowAlumnosBaja();
                }
            }
            else
            {
                FormInformacion frmError = new FormInformacion("SELECCIONE UNA FILA POR FAVOR");
                frmError.ShowDialog();
                // MessageBox.Show("seleccione una fila por favor");
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
