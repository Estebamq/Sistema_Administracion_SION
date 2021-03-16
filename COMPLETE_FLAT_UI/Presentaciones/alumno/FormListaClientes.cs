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
using COMPLETE_FLAT_UI.Presentaciones;

namespace COMPLETE_FLAT_UI
{
    public partial class FormListaAlumnos : Form
    {
        private Estados estados = new Estados();
        private List<Estados> listEstadosAlumnos = new List<Estados>();
        public FormListaAlumnos()
        {
            InitializeComponent();
            ShowAlumnos();
            HideWidthColumns();
        }


        public void HideWidthColumns()
        {
            dataGridViewAlumnos.Columns[7].Visible = false;
        }
        public void ShowAlumnos()
        {

            Alumno alumno = new Alumno();
            listEstadosAlumnos = estados.ListingEstadosA("");
            foreach (Estados estado in listEstadosAlumnos)
            {
                if (estado.EstadoA == "Alta")
                {
                    alumno.Estado = estado.Id;
                }
            }
            dataGridViewAlumnos.DataSource = alumno.ListingAlumnosPorEstado(alumno);
            dataGridViewAlumnos.Columns[0].HeaderText = "ID";
            dataGridViewAlumnos.Columns[1].HeaderText = "NOMBRE";
            dataGridViewAlumnos.Columns[2].HeaderText = "APELLIDO";
            dataGridViewAlumnos.Columns[3].HeaderText = "DNI";
            dataGridViewAlumnos.Columns[4].HeaderText = "TELEFONO";
            dataGridViewAlumnos.Columns[5].HeaderText = "DIRECCION";
            dataGridViewAlumnos.Columns[6].HeaderText = "EMAIL";
            dataGridViewAlumnos.Columns[8].HeaderText = "ESTADO";
            dataGridViewAlumnos.Columns[9].HeaderText = "FECHA DE NACIMIENTO";
            dataGridViewAlumnos.Columns[10].HeaderText = "OBSERVACIONES";

        }




        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormMantCliente frm = new FormMantCliente();
            frm.update = true;
            if (dataGridViewAlumnos.SelectedRows.Count > 0)
            {
                frm.txtId.Text = dataGridViewAlumnos.CurrentRow.Cells[0].Value.ToString();
                frm.txtNombre.Text = dataGridViewAlumnos.CurrentRow.Cells[1].Value.ToString();
                frm.txtApellido.Text = dataGridViewAlumnos.CurrentRow.Cells[2].Value.ToString();
                frm.txtDni.Text = dataGridViewAlumnos.CurrentRow.Cells[3].Value.ToString();
                frm.txtTelefono.Text = dataGridViewAlumnos.CurrentRow.Cells[4].Value.ToString();
                frm.txtDireccion.Text = dataGridViewAlumnos.CurrentRow.Cells[5].Value.ToString();
                frm.txtEmail.Text = dataGridViewAlumnos.CurrentRow.Cells[6].Value.ToString();
                frm.cmbEstadosAlumnos.Text = dataGridViewAlumnos.CurrentRow.Cells[8].Value.ToString();
                frm.dateTimePickerAlumnos.Text = dataGridViewAlumnos.CurrentRow.Cells[9].Value.ToString();
                frm.txtObservaciones.Text = dataGridViewAlumnos.CurrentRow.Cells[10].Value.ToString();
                frm.ShowDialog();
                ShowAlumnos();
            }
            else
            {
                FormInformacion frmError = new FormInformacion("SELECCIONE UNA FILA POR FAVOR");
                frmError.ShowDialog();
               // MessageBox.Show("seleccione una fila por favor");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormMantCliente frm = new FormMantCliente();
            frm.update = false;
            frm.ShowDialog();
            ShowAlumnos();
        }

        private void btnBajaAlumno_Click(object sender, EventArgs e)
        {
            FormInformacion frm = new FormInformacion("DESEA DAR DE BAJA");
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Alumno alumno = new Alumno();
                if (dataGridViewAlumnos.SelectedRows.Count > 0)
                {
                    alumno.Id = Convert.ToInt32(dataGridViewAlumnos.CurrentRow.Cells[0].Value.ToString());
                    //Busca el estado Baja y lo remplaza por su ID
                    listEstadosAlumnos = estados.ListingEstadosA("");
                    foreach (Estados estado in listEstadosAlumnos) {
                        if (estado.EstadoA == "Baja")
                        {
                            alumno.Estado = estado.Id;
                        }
                    }

                    alumno.UpdatingBajaAlumno(alumno);
                    ShowAlumnos();
                }
                else
                {
                    FormInformacion frmError = new FormInformacion("SELECCIONE UNA FILA POR FAVOR");
                    frmError.ShowDialog();
                    //MessageBox.Show("seleccione una fila por favor");
                }
            }
        }

        private void btnCargarClase_Click(object sender, EventArgs e)
        {
            FormInscripcionClases frm = new FormInscripcionClases();
            
            if (dataGridViewAlumnos.SelectedRows.Count > 0)
            {
                frm.txtIdAlumno.Text = dataGridViewAlumnos.CurrentRow.Cells[0].Value.ToString();
                frm.txtNombreAlumno.Text = dataGridViewAlumnos.CurrentRow.Cells[1].Value.ToString();
                frm.txtApellidoAlumno.Text = dataGridViewAlumnos.CurrentRow.Cells[2].Value.ToString();
                frm.txtDireccionAlumno.Text = dataGridViewAlumnos.CurrentRow.Cells[5].Value.ToString();
                frm.ShowDialog();
                ShowAlumnos();
            }
            else
            {
                FormInformacion frmError = new FormInformacion("SELECCIONE UNA FILA POR FAVOR");
                frmError.ShowDialog();
                // MessageBox.Show("seleccione una fila por favor");
            }
        }

        //BUSCAR ALUMNO 
        //POR NOMBRE
        public void SearchAlumnoNombre(string search)
        {
            Alumno alumno = new Alumno();
            dataGridViewAlumnos.DataSource = alumno.SearchingAlumnoNombre(search);
        }

        private void txtSearchAlumnoNombre_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                SearchAlumnoNombre(txtSearchAlumnoNombre.Text);
            }
            catch (Exception ex)
            {
                FormInformacion frmError = new FormInformacion("ERROR: DATO INCORRECTO");
                frmError.ShowDialog();
                //MessageBox.Show("No se pudo BUSCAR el registro, no es un valor valido" + ex);
            }
        }
        //POR APELLIDO
        public void SearchAlumnoApellido(string search)
        {
            Alumno alumno = new Alumno();
            dataGridViewAlumnos.DataSource = alumno.SearchingAlumnoApellido(search);
        }
        private void txtSearchAlumnoApellido_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                SearchAlumnoApellido(txtSearchAlumnoApellido.Text);
            }
            catch (Exception ex)
            {
                FormInformacion frmError = new FormInformacion("ERROR: DATO INCORRECTO");
                frmError.ShowDialog();
                //MessageBox.Show("No se pudo BUSCAR el registro, no es un valor valido" + ex);
            }

        }

        //POR ID

        public void SearchAlumnoId(string search)
        {
            Alumno alumno = new Alumno();
            dataGridViewAlumnos.DataSource = alumno.SearchingAlumnoId(search);
        }

        private void txtSearchAlumnoId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SearchAlumnoId(txtSearchAlumnoId.Text);
                if (txtSearchAlumnoId.Text == "")
                {
                    ShowAlumnos();
                }
            }
            catch (Exception ex)
            {
                FormInformacion frmError = new FormInformacion("ERROR: DATO INCORRECTO");
                frmError.ShowDialog();
                //MessageBox.Show("No se pudo BUSCAR el registro, no es un valor valido" + ex);
            }
        }

        //POR DNI
        public void SearchAlumnoDni(string search)
        {
            Alumno alumno = new Alumno();
            dataGridViewAlumnos.DataSource = alumno.SearchingAlumnoDni(search);
        }


        private void txtSearchAlumnoDni_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SearchAlumnoDni(txtSearchAlumnoDni.Text);
                if (txtSearchAlumnoDni.Text == "")
                {
                    ShowAlumnos();
                }
            }
            catch (Exception ex)
            {
                FormInformacion frmError = new FormInformacion("ERROR: DATO INCORRECTO");
                frmError.ShowDialog();
                //MessageBox.Show("No se pudo BUSCAR el registro, no es un valor valido" + ex);
            }
        }

       
    }
}
