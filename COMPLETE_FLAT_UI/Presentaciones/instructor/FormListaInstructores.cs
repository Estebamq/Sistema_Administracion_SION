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
using COMPLETE_FLAT_UI.Presentaciones.instructor;
using COMPLETE_FLAT_UI.Presentaciones;



namespace COMPLETE_FLAT_UI
{
    public partial class FormListaInstructores : Form
    {
        private Estados estados = new Estados();
        private List<Estados> listEstadosInstructores = new List<Estados>();
        Instructor instructor = new Instructor();
        public FormListaInstructores()
        {
            InitializeComponent();
            ShowInstructores();
            HideWidthColumns();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void HideWidthColumns()
        {
            dataGridViewInstructores.Columns[7].Visible = false;
        }
        public void ShowInstructores()
        {
            
            listEstadosInstructores = estados.ListingEstadosI("");
            foreach (Estados estado in listEstadosInstructores)
            {
                if (estado.EstadoI == "Alta")
                {
                    instructor.Estado = estado.Id;
                }
            }
            dataGridViewInstructores.DataSource = instructor.ListingInstructoresPorEstado(instructor);
            dataGridViewInstructores.Columns[0].HeaderText = "ID";
            dataGridViewInstructores.Columns[1].HeaderText = "NOMBRE";
            dataGridViewInstructores.Columns[2].HeaderText = "APELLIDO";
            dataGridViewInstructores.Columns[3].HeaderText = "DNI";
            dataGridViewInstructores.Columns[4].HeaderText = "TELEFONO";
            dataGridViewInstructores.Columns[5].HeaderText = "DIRECCION";
            dataGridViewInstructores.Columns[6].HeaderText = "EMAIL";
            dataGridViewInstructores.Columns[8].HeaderText = "ESTADO";
            dataGridViewInstructores.Columns[9].HeaderText = "MODELO DE AUTO";
            dataGridViewInstructores.Columns[10].HeaderText = "PATENTE";
            dataGridViewInstructores.Columns[11].HeaderText = "VENCIMIENTO SEGURO";
           
        }

        private void btnNuevoInstructor_Click(object sender, EventArgs e)
        {
            FormMantInstructor frm = new FormMantInstructor();
            frm.ShowDialog();
            ShowInstructores();
        }

        private void btnEditarInstructor_Click(object sender, EventArgs e)
        {
            FormMantInstructor frm = new FormMantInstructor();
            frm.updateInstructor = true;
            if (dataGridViewInstructores.SelectedRows.Count > 0)
            {
                frm.txtId.Text = dataGridViewInstructores.CurrentRow.Cells[0].Value.ToString();
                frm.txtNombre.Text = dataGridViewInstructores.CurrentRow.Cells[1].Value.ToString();
                frm.txtApellido.Text = dataGridViewInstructores.CurrentRow.Cells[2].Value.ToString();
                frm.txtDni.Text = dataGridViewInstructores.CurrentRow.Cells[3].Value.ToString();
                frm.txtTelefono.Text = dataGridViewInstructores.CurrentRow.Cells[4].Value.ToString();
                frm.txtDireccion.Text = dataGridViewInstructores.CurrentRow.Cells[5].Value.ToString();
                frm.txtEmail.Text = dataGridViewInstructores.CurrentRow.Cells[6].Value.ToString();
                frm.cmbEstadoInstructor.Text = dataGridViewInstructores.CurrentRow.Cells[8].Value.ToString();
                frm.txtModeloAuto.Text = dataGridViewInstructores.CurrentRow.Cells[9].Value.ToString();
                frm.txtPatente.Text = dataGridViewInstructores.CurrentRow.Cells[10].Value.ToString();
                frm.dateTimePickerVencimientoSeguro.Text = dataGridViewInstructores.CurrentRow.Cells[11].Value.ToString();
              
                frm.ShowDialog();
                ShowInstructores();
            }
            else
            {
                FormInformacion frmError = new FormInformacion("SELECCIONE UNA FILA POR FAVOR");
                frmError.ShowDialog();
                // MessageBox.Show("seleccione una fila por favor");
            }
        }

        private void btnBajaInstructor_Click(object sender, EventArgs e)
        {
            FormInformacion frm = new FormInformacion("DESEA DAR DE BAJA");
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Instructor instructor = new Instructor();
                if (dataGridViewInstructores.SelectedRows.Count > 0)
                {
                    instructor.Id = Convert.ToInt32(dataGridViewInstructores.CurrentRow.Cells[0].Value.ToString());
                    //Busca el estado "Baja" del instructor y agrega su id en el estado del instructor 
                    listEstadosInstructores = estados.ListingEstadosI("");
                    foreach (Estados estado in listEstadosInstructores) {
                        if (estado.EstadoI == "Baja")
                        {
                            instructor.Estado = estado.Id;
                        }
                    }
                    instructor.UpdatingBajaInstructor(instructor);
                    ShowInstructores();
                }
                else
                {
                    FormInformacion frmError = new FormInformacion("SELECCIONE UNA FILA POR FAVOR");
                    frmError.ShowDialog();
                    //MessageBox.Show("seleccione una fila por favor");
                }
            }
        }

        //BUSCAR INSTRUCTOR 
        //POR NOMBRE
        public void SearchInstructorNombre(string search)
        {
            Instructor instructor = new Instructor();
            dataGridViewInstructores.DataSource = instructor.SearchingInstructorNombre(search);
        }

        private void txtSearchInstructorNombre_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                SearchInstructorNombre(txtSearchInstructorNombre.Text);
            }
            catch (Exception ex)
            {
                FormInformacion frmError = new FormInformacion("ERROR: DATO INCORRECTO");
                frmError.ShowDialog();
                //MessageBox.Show("No se pudo BUSCAR el registro, no es un valor valido" + ex);
            }
        }

        //POR APELLIDO
        public void SearchInstructorApellido(string search)
        {
            Instructor instructor = new Instructor();
            dataGridViewInstructores.DataSource = instructor.SearchingInstructorApellido(search);
        }

       
        private void txtSearchInstructorApellido_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SearchInstructorApellido(txtSearchInstructorApellido.Text);
            }
            catch (Exception ex)
            {
                FormInformacion frmError = new FormInformacion("ERROR: DATO INCORRECTO");
                frmError.ShowDialog();
                //MessageBox.Show("No se pudo BUSCAR el registro, no es un valor valido" + ex);
            }
        }

        //POR ID
        public void SearchInstructorId(string search)
        {
            Instructor instructor = new Instructor();
            dataGridViewInstructores.DataSource = instructor.SearchingInstructorId(search);
        }

        private void txtSearchInstructorId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SearchInstructorId(txtSearchInstructorId.Text);
                if (txtSearchInstructorId.Text == "")
                {
                    ShowInstructores();
                }
            }
            catch (Exception ex)
            {
                /*FormInformacion frmError = new FormInformacion("ERROR: DATO INCORRECTO");
                frmError.ShowDialog();*/
                MessageBox.Show("No se pudo BUSCAR el registro, no es un valor valido" + ex);
            }
        }

        //POR DNI
        public void SearchInstructorDni(string search)
        {
            Instructor instructor = new Instructor();
            dataGridViewInstructores.DataSource = instructor.SearchingInstructorDni(search);
        }

        private void txtSearchInstructorDni_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SearchInstructorDni(txtSearchInstructorDni.Text);
                if (txtSearchInstructorDni.Text == "")
                {
                    ShowInstructores();
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
