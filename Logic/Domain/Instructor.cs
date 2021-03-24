using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.DataAccess;
using System.Data;


namespace Logic

{
    public class Instructor : Persona
    {
        private string patente;
        private string modeloAuto;
        private DateTime fechaVencimientoSeguro;
        private string search;
        private InstructoresDAO instructorDAO = new InstructoresDAO();


        #region Constructores

        public Instructor() 
        {
        }

        public Instructor( string nombre, string apellido, int dni, int telefono,
                             string direccion, string email, int estado, string patente, string modeloAuto, DateTime fechaVencimientoSeguro)
                            : base( nombre, apellido, dni, telefono, direccion, email, estado)
        {
            this.patente = patente;
            this.modeloAuto = modeloAuto;
            this.FechaVencimientoSeguro = fechaVencimientoSeguro;
        }

        public Instructor(int id,string nombre, string apellido, int dni, int telefono,
                            string direccion, string email, int estado, string patente, string modeloAuto, DateTime fechaVencimientoSeguro)
                           : base(nombre, apellido, dni, telefono, direccion, email, estado)
        {
            this.patente = patente;
            this.modeloAuto = modeloAuto;
            this.FechaVencimientoSeguro = fechaVencimientoSeguro;
        }
        #endregion

        #region Propiedades
        public string Patente
        {
            get { return patente; }
            set { patente = value; }
        }

        public string ModeloAuto
        {
            get { return modeloAuto; }
            set { modeloAuto = value; }
        }

        public DateTime FechaVencimientoSeguro 
        {
            get {return fechaVencimientoSeguro; }
            set {fechaVencimientoSeguro = value; }
        }

        public string Search
        {
            get { return search; }
            set { search = value; }
        }
        #endregion

        #region Metodo
        public void CreatingInstructor(Instructor instructor)
        {
            instructorDAO.CreateInstructor(instructor);
        }
        public void UpdatingInstructor(Instructor instructor)
        {
            instructorDAO.UpdateInstructor(instructor);
        }
        public DataTable ListingInstructores()
        {
            return instructorDAO.ListarInstructor();
        }

        public DataTable ListingInstructoresPorEstado(Instructor instructor)
        {
            return instructorDAO.ListarInstructorPorEstado(instructor);
        }

        public void UpdatingBajaInstructor(Instructor instructor)
        {
            instructorDAO.UpdateBajaInstructor(instructor);
        }

        public void DeletingInstructor(Instructor instructor)
        {
            instructorDAO.DeleteInstructor(instructor);
        }

        public DataTable SearchingInstructorNombre(string search)
        {
            Instructor instructor= new Instructor();
            instructor.Search = search;
            return instructorDAO.SearchInstructorNombre(instructor);
        }

        public DataTable SearchingInstructorApellido(string search)
        {
            Instructor instructor = new Instructor();
            instructor.Search = search;
            return instructorDAO.SearchInstructorApellido(instructor);
        }

        public DataTable SearchingInstructorId(string search)
        {
            Instructor instructor = new Instructor();
            instructor.Search = search;
            return instructorDAO.SearchInstructorId(instructor);
        }

        public DataTable SearchingInstructorDni(string search)
        {
            Instructor instructor = new Instructor();
            instructor.Search = search;
            return instructorDAO.SearchInstructorDni(instructor);
        }

        //BUSCAR INSTRUCTORES POR ID
        public List<Instructor> SearchingInstructorIdPlanilla(string search)
        {
            Instructor instructor = new Instructor();
            instructor.Search = search;
            return instructorDAO.SearchInstructorIdPlanilla(instructor);
        }

        //LISTAR INSTRUCTORES VENCIMIENTO DE SEGURO
        public List<Instructor> ListingInstructorVencimientoSeguro(Instructor instructor)
        {
            return instructorDAO.ListarInstructorVencimientoSeguro(instructor);
        }

        #endregion
    }
}
