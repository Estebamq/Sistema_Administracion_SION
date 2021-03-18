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

        public string NombreAlumno 
        {
             get {return nombreAlumno; }
             private set { nombreAlumno = value; }
        }
        public string ApellidoAlumno
        {
            get { return apellidoAlumno; }
            private set { apellidoAlumno = value; }
        }
        public string DireccionAlumno
        {
            get { return direccionAlumno; }
            private set { direccionAlumno = value; }
        }
        public int NumClase
        {
            get { return numClase; }
            private set { numClase = value; }
        }
        public string Dia
        {
            get { return dia;}
            private set{ dia = value;}
        }
        public string Hora
        { 
            get { return hora;} 
            private set { hora = value;} 
        }
        public string Descripcion
        {
            get {return descripcion;}
           private set {descripcion = value;}
        }

        #endregion

        #region Metodos

        public List<ReporteClase> ListiingInstructorIdPlanilla(Clase clase)
        {
            
            return clasesDAO.ListarInstructorIdPlanilla(clase);
        }

        #endregion

    }
}
