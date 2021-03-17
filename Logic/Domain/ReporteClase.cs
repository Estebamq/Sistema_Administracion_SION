using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.DataAccess;

namespace Logic.Domain
{
    public class ReporteClase
    {
        private string nombreAlumno;
        private string apellidoAlumno;
        private string direccionAlumno;
        private int numClase;
        private string dia;
        private string hora;
        private string descripcion;
        ClasesDAO clasesDAO = new ClasesDAO();


        #region Constructores
        public ReporteClase()
        {

        }

        public ReporteClase(string nombreAlumno, string apellidoAlumno, string direccionAlumno, int numClase, string dia, string hora, string descripcion)
        {
            this.NombreAlumno = nombreAlumno;
            this.ApellidoAlumno = apellidoAlumno;
            this.DireccionAlumno = direccionAlumno;
            this.NumClase = numClase;
            this.Dia = dia;
            this.Hora = hora;
            this.Descripcion = descripcion;
        }

        #endregion

        #region Propiedades

        public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }
        public string ApellidoAlumno { get => apellidoAlumno; set => apellidoAlumno = value; }
        public string DireccionAlumno { get => direccionAlumno; set => direccionAlumno = value; }
        public int NumClase { get => numClase; set => numClase = value; }
        public string Dia { get => dia; set => dia = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        #endregion

        #region Metodos

        public List<ReporteClase> ListiingInstructorIdPlanilla(Clase clase)
        {
            
            return clasesDAO.ListarInstructorIdPlanilla(clase);
        }

        #endregion

    }
}
