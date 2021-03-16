using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Logic.DataAccess;

namespace Logic
{
    public class Alumno : Persona
    {
        
        
        #region Atributos
        private DateTime fechaDeNacimiento;
        private AlumnosDAO alumnosDAO = new AlumnosDAO();
        private string observaciones;
        private string search;

        #endregion

        #region Constructores

        public Alumno() 
        {

        }
        public Alumno(string nombre, string apellido, int dni,
                          int telefono, string direccion, string email, int estado, DateTime fechaDeNacimiento,string observaciones)
                          : base(nombre, apellido, dni, telefono, direccion, email, estado)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.observaciones = observaciones;
          

        }
        public Alumno(int id,string nombre, string apellido, int dni,
                          int telefono, string direccion, string email, int estado, DateTime fechaDeNacimiento,string observaciones)
                          : base(id,nombre, apellido, dni, telefono, direccion, email, estado)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.observaciones = observaciones;
        }

        #endregion

        #region Propiedades
        
        public DateTime FechaDeNacimiento
        {
            get { return fechaDeNacimiento; }
            set { fechaDeNacimiento = value; }
        }

        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }

        public string Search 
        {
            get { return search; }
            set { search = value; }
        }

        #endregion

        #region METODOS
        public void CreatingAlumno(Alumno alumno)
        {
            alumnosDAO.CreateAlumno(alumno);
        }

        public void UpdatingAlumno(Alumno alumno)
        {
            alumnosDAO.UpdateAlumno(alumno);
        }
        public void UpdatingBajaAlumno(Alumno alumno)
        {
            alumnosDAO.UpdateBajaAlumno(alumno);
        }

        public void DeletingAlumno(Alumno alumno)
        {
            alumnosDAO.DeleteAlumno(alumno);
        }

        public DataTable ListingAlumnos()
        {
            return alumnosDAO.ListarAlumno();
        }

        public DataTable ListingAlumnosPorEstado(Alumno alumno)
        {
            return alumnosDAO.ListarAlumnoPorEstado(alumno);
        }

        public DataTable SearchingAlumnoNombre(string search)
        {
            Alumno alumno = new Alumno();
             alumno.Search= search;
            return alumnosDAO.SearchAlumnoNombre(alumno);
        }

        public DataTable SearchingAlumnoApellido(string search)
        {
            Alumno alumno = new Alumno();
            alumno.Search = search;
            return alumnosDAO.SearchAlumnoApellido(alumno);
        }

        public DataTable SearchingAlumnoId(string search)
        {
            Alumno alumno = new Alumno();
            alumno.Search = search;
            return alumnosDAO.SearchAlumnoId(alumno);
        }

        public DataTable SearchingAlumnoDni(string search)
        {
            Alumno alumno = new Alumno();
            alumno.Search = search;
            return alumnosDAO.SearchAlumnoDni(alumno);
        }

        #endregion



    }
}
