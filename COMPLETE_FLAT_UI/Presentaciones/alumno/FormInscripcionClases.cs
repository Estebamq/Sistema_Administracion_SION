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
using Logic;
using Logic.DataAccess;
using COMPLETE_FLAT_UI.Presentaciones;

namespace COMPLETE_FLAT_UI
{
    public partial class FormInscripcionClases : Form
    {
        Clase clase = new Clase();
        private int renglon = -1;
        private bool update = false;
        private Estados estados = new Estados();
        private List<Estados> listEstadosPresente = new List<Estados>();
        private List<Estados> listEstadosInstructores = new List<Estados>();
        public FormInscripcionClases()
        {
            InitializeComponent();
            ListMetodosDePago();
            ShowInstructoresClase();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormInscripcionClases_Load(object sender, EventArgs e)
        {
            //poner intervalo en la hora del combobox, 
            //"timestart" inicio del horario 
            //"timefin" el fin del horario 
            //"intervalo" el intervalo en ue se va a mostrar "cada una hora" 
            TimeSpan timeStart = new TimeSpan(6, 0, 0);
            TimeSpan timeFin = new TimeSpan(19, 0, 0);
            TimeSpan intervalo = new TimeSpan(0, 30, 0);

            cmbHoraClase.FormatString = "hh\\:mm";
            while (!(timeStart > timeFin))
            {
                cmbHoraClase.Items.Add(timeStart);
                timeStart += intervalo;
            }

            ShowClasPorIdAlumno();
        }
        public void ShowInstructoresClase()
        {
            Instructor instructor = new Instructor();

            listEstadosInstructores = estados.ListingEstadosI("");
            foreach (Estados estado in listEstadosInstructores)
            {
                if (estado.EstadoI == "Alta")
                {
                    instructor.Estado = estado.Id;
                }
            }
            dataGridViewInstructoresClases.DataSource = instructor.ListingInstructoresPorEstado(instructor);
            dataGridViewInstructoresClases.Columns[0].HeaderText = "ID";
            dataGridViewInstructoresClases.Columns[1].HeaderText = "NOMBRE";
            dataGridViewInstructoresClases.Columns[2].HeaderText = "APELLIDO";
            dataGridViewInstructoresClases.Columns[3].HeaderText = "DNI";
            dataGridViewInstructoresClases.Columns[4].HeaderText = "TELEFONO";
            dataGridViewInstructoresClases.Columns[5].HeaderText = "DIRECCION";
            dataGridViewInstructoresClases.Columns[9].HeaderText = "MODELO DE AUTO";
            HideColumnsInstructures();     
        }

        private void HideColumnsInstructures() 
        {
            dataGridViewInstructoresClases.Columns[6].Visible = false;
            dataGridViewInstructoresClases.Columns[7].Visible = false;
            dataGridViewInstructoresClases.Columns[8].Visible = false;
            dataGridViewInstructoresClases.Columns[10].Visible = false;
            dataGridViewInstructoresClases.Columns[11].Visible = false;
           

        }

        public void ShowClasPorIdAlumno()
        {
            clase.IdAlumno = Convert.ToInt32(txtIdAlumno.Text);
            dataGridViewClases.DataSource = clase.ListingClasesPorIdAlumno(clase);
            dataGridViewClases.Columns[0].Visible = false;
            dataGridViewClases.Columns[1].HeaderText = "ID";
            dataGridViewClases.Columns[2].HeaderText = "NOMBRE";
            dataGridViewClases.Columns[3].HeaderText = "APELLIDO";
            dataGridViewClases.Columns[4].HeaderText = "Nº CLASE";
            dataGridViewClases.Columns[5].HeaderText = "FECHA";
            dataGridViewClases.Columns[6].HeaderText = "HORA";
            dataGridViewClases.Columns[7].HeaderText = "DIRECCION";
            dataGridViewClases.Columns[8].HeaderText = "METODO DE PAGO";
            dataGridViewClases.Columns[9].HeaderText = "DESCRIPCION";

        }
       

        //PERMITE SELECCIONAR UN DIA PARA LAS CLASES
        private void monthCalendarClases_DateChanged(object sender, DateRangeEventArgs e)
        {
            //Carga de dia
            DateTime dia = monthCalendarClases.SelectionStart;
            txtDiaClase.Text = dia.ToString("d");
            ShowInstructoresClase();
        }

        //MUESTRA LOS METODOS DE PAGO EN EL COMBO BOX
        public void ListMetodosDePago()
        {
            MetodosDePago metodosDePago = new MetodosDePago();
            cmbMediosDePago.DataSource = metodosDePago.ListingMetodosDePago("");
            cmbMediosDePago.ValueMember = "Id";
            cmbMediosDePago.DisplayMember = "MetodoDePago";
        }
       //ELIJO CELDA PARA PASAR DATOS DE LOS INTRUCTORES
        private void dataGridViewInstructoresClases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex; //La variable renglon debe estar previamente declarada y ser de tipo entero
        }

        //PASO LOS DATOS A LOS TEXBOX
        private void dataGridViewInstructoresClases_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdInstructor.Text = dataGridViewInstructoresClases.Rows[renglon].Cells[0].Value.ToString();
            txtNombreInstructor.Text = dataGridViewInstructoresClases.Rows[renglon].Cells[1].Value.ToString();
            txtApellidoInstructor.Text = dataGridViewInstructoresClases.Rows[renglon].Cells[2].Value.ToString();
        }


        //--------------------------------BOTONES---------------------------------------------------------------

        //BOTONES PARA VER LOS INSTRUCTORES
        private void btnTodosInstructores_Click(object sender, EventArgs e)
        {
            if (txtDiaClase.Text != "")

            {
                clase.SearchFecha = Convert.ToDateTime(txtDiaClase.Text);
                dataGridViewInstructoresClases.DataSource = clase.ListingInstructorClase(clase);


            }
        }

        private void btnDisponibleInstructor_Click(object sender, EventArgs e)
        {
            ShowInstructoresClase();
        }

        //DE EDICION DE CLASE
        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            FormInformacion frm = new FormInformacion("DESEA GUARDAR LOS CAMBIOS");
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK )
            {

                try
                {
                    

                    clase.NumClase = Convert.ToInt32(txtNumClase.Text);
                    clase.IdAlumno = Convert.ToInt32(txtIdAlumno.Text);
                    clase.IdInstructor = Convert.ToInt32(txtIdInstructor.Text);
                    clase.Fecha = Convert.ToDateTime(txtDiaClase.Text);
                    clase.Hora = Convert.ToDateTime(cmbHoraClase.Text);

                    //BUSCO EL DATO AUSENTE EN LA BASE DE DATOS

                    listEstadosPresente = estados.ListingEstadosP("Ausente");
                    foreach (Estados estado in listEstadosPresente)
                    {
                        if (estado.EstadoP == "Ausente")
                        {
                            clase.IdPresente = estado.Id;
                        }
                    }

                    clase.IdMetodoDePago = Convert.ToInt32(cmbMediosDePago.SelectedValue);
                    clase.Descripcion = txtDescripcionClase.Text;
                    //ANTES DE GUARDAR LOS DATOS BUSCAMOS SI EXISTE EL INSTRUCTOR

                            if (update)
                            {
                                clase.Id = Convert.ToInt32(txtIdClase.Text);
                                clase.UpdatingClase(clase);
                                FormConfirmacion frmConfirm = new FormConfirmacion("SE ACTUALIZO CON EXITO");
                                DialogResult resultConfirm = frmConfirm.ShowDialog();
                                update = false;
                            }
                            else if (clase.SearchingInstructorClase(clase) == false)
                            {
                                

                                clase.CreatingClase(clase);
                                FormConfirmacion frmConfirmGuardar = new FormConfirmacion("SE GUARDARON CON EXITO");
                                DialogResult resultConfirmGuardar = frmConfirmGuardar.ShowDialog();

                            }
                        
                        ShowClasPorIdAlumno();
                
                }
                //SI EL INSTRUCTOR EXISTE LO CAPTURAMOS ACA
                catch (IndexOutOfRangeException ex) 
                {
                    FormInformacion frmError = new FormInformacion("INSTRUCTOR OCUPADO");
                    frmError.ShowDialog();
                    //MessageBox.Show("No se pudo guardar el registro" + ex);
                }

                //SI SURGE UN ERROR EN LA CARGA LO CAPTURAMOS ACA
                catch (Exception ex)
                {
                    
                        FormInformacion frmError = new FormInformacion("ERROR: DATOS INCORRECTOS");
                        frmError.ShowDialog();
                        //MessageBox.Show("No se pudo guardar el registro" + ex);
                    
                }

            }
        }
        private void btnEditarClase_Click(object sender, EventArgs e)
        {
            update = true;
            if (dataGridViewClases.SelectedRows.Count > 0)
            {
                txtIdClase.Text = dataGridViewClases.CurrentRow.Cells[0].Value.ToString();
                txtIdInstructor.Text = dataGridViewClases.CurrentRow.Cells[1].Value.ToString();
                txtNombreInstructor.Text = dataGridViewClases.CurrentRow.Cells[2].Value.ToString();
                txtApellidoInstructor.Text = dataGridViewClases.CurrentRow.Cells[3].Value.ToString();
                txtNumClase.Text = dataGridViewClases.CurrentRow.Cells[4].Value.ToString();
                txtDiaClase.Text = dataGridViewClases.CurrentRow.Cells[5].Value.ToString();
                cmbHoraClase.Text = dataGridViewClases.CurrentRow.Cells[6].Value.ToString();
                cmbMediosDePago.Text = dataGridViewClases.CurrentRow.Cells[8].Value.ToString();
                txtDescripcionClase.Text = dataGridViewClases.CurrentRow.Cells[9].Value.ToString();
            }
            else
            {
                FormInformacion frmError = new FormInformacion("SELECCIONE UNA FILA POR FAVOR");
                frmError.ShowDialog();
                // MessageBox.Show("seleccione una fila por favor");
            }
        }

        private void btnEliminarClase_Click(object sender, EventArgs e)
        {
            if (dataGridViewClases.SelectedRows.Count > 0)
            {
                FormInformacion frm = new FormInformacion("DESEA ELIMINAR LA CLASE");
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    clase.Id = Convert.ToInt32(dataGridViewClases.CurrentRow.Cells[0].Value.ToString());
                    clase.DeletingClase(clase);
                    ShowClasPorIdAlumno();
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
