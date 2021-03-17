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

namespace COMPLETE_FLAT_UI.Presentaciones
{
    public partial class FormPlanillas : Form
    {
        private Estados estados = new Estados();
        private int renglon = -1;
        private List<Estados> listEstadosInstructores = new List<Estados>();
        Instructor instructor = new Instructor();
        public FormPlanillas()
        {
            InitializeComponent();
            ShowInstructores();
            HideWidthColumns();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPlanillas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        public void HideWidthColumns()
        {
            dataGridViewInstructores.Columns[7].Visible = false;
            dataGridViewInstructores.Columns[3].Visible = false;
            dataGridViewInstructores.Columns[4].Visible = false;
            dataGridViewInstructores.Columns[5].Visible = false;
            dataGridViewInstructores.Columns[6].Visible = false;
            dataGridViewInstructores.Columns[8].Visible = false;
            dataGridViewInstructores.Columns[9].Visible = false;
            dataGridViewInstructores.Columns[10].Visible = false;
            dataGridViewInstructores.Columns[11].Visible = false;

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

        }

        //ELIJO CELDA PARA PASAR DATOS DE LOS INTRUCTORES
        private void dataGridViewInstructores_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex; //La variable renglon debe estar previamente declarada y ser de tipo entero
        }

        //PASO LOS DATOS AL REPORTE CON EL DOBLE CLICK

        private void dataGridViewInstructores_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // cuando selecciono una fila con un click en esta parte seteo el id con el doble click
            instructor.Search = dataGridViewInstructores.Rows[renglon].Cells[0].Value.ToString();
            
            // paso la lista con el id seleccionado
            InstructorBindingSource.DataSource = instructor.SearchingInstructorIdPlanilla(instructor.Search);
            this.reportViewer1.RefreshReport();
        }

        private void btnBuscarClasesInstructor_Click(object sender, EventArgs e)
        {
            Clase clase = new Clase();
            clase.IdInstructor = Convert.ToInt32(instructor.Search);
            clase.Fecha = DateTime.Today.AddDays(1);

            ReporteClase reporteClase = new ReporteClase();

            ReporteClaseBindingSource.DataSource = reporteClase.ListiingInstructorIdPlanilla(clase);
            this.reportViewer1.RefreshReport();

        }
    }
}
