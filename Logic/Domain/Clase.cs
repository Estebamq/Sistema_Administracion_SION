using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.DataAccess;
using System.Data;

namespace Logic
{
    public class Clase
    {
        private int id;
        private int numClase;
        private int idAlumno;
        private int idInstructor;
        private DateTime fecha;
        private DateTime hora;
        private int idPresente;
        private int idMetodoDePago;
        private string descripcion;
        private DateTime searchFecha;
        ClasesDAO claseDAO = new ClasesDAO();


        #region Constructores
        
        public Clase() 
        { 
        }

        public Clase( int id, int numClase, int idAlumno, int idInstructor, DateTime fecha, DateTime hora, int idPresente, int idMetodoDePago, string descripcion)
        {
            this.id = id;
            this.numClase = numClase;
            this.idAlumno = idAlumno;
            this.idInstructor = idInstructor;
            this.fecha = fecha;
            this.hora = hora;
            this.idPresente = idPresente;
            this.idMetodoDePago = idMetodoDePago;
            this.descripcion = descripcion;
        }
        public Clase(int numClase, int idAlumno, int idInstructor, DateTime fecha, DateTime hora, int idPresente, int idMetodoDePago, string descripcion)
        {
            this.numClase = numClase;
            this.idAlumno = idAlumno;
            this.idInstructor = idInstructor;
            this.fecha = fecha;
            this.hora = hora;
            this.idPresente = idPresente;
            this.idMetodoDePago = idMetodoDePago;
            this.descripcion = descripcion;
        }

        #endregion

        #region Propiedades

        public int Id 
        {
            get { return id; }
            set { id = value; }
        }
        public int NumClase
        {
            get { return numClase; }
            set { numClase = value; }
        }


        public int IdAlumno
        {
            get { return idAlumno; }
            set { idAlumno = value; }
        }

        public int IdInstructor
        {
            get { return idInstructor; }
            set { idInstructor = value; }
        }
        

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public DateTime Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        public int IdPresente
        {
            get { return idPresente; }
            set { idPresente = value; }
        }
        public int IdMetodoDePago 
        {
            get { return idMetodoDePago; }
            set { idMetodoDePago = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public DateTime SearchFecha
        {
            get { return searchFecha; }
            set { searchFecha = value; }
        }


        #endregion


        #region Metodos
        public void CreatingClase(Clase clase)
        {
            claseDAO.CreateClase(clase);
        }
        public void UpdatingClase(Clase clase)
        {
            claseDAO.UpdateClase(clase);
        }

        public void UpdatingAsistenciaClase(Clase clase)
        {
            claseDAO.UpdateAsistenciaClase(clase);
        }

        public void DeletingClase(Clase clase)
        {
            claseDAO.DeleteClase(clase);
        }

        public DataTable ListingInstructorClase(Clase clase)
        {
            return claseDAO.ListarInstructorClase(clase);
        }

        public DataTable ListingClasesPorIdAlumno(Clase clase)
        {
            return claseDAO.ListarClasesPorIdAlumno(clase);
        }
        public DataTable ListingClasesDeHoy(Clase clase)
        {
            return claseDAO.ListarClasesDeHoy(clase);
        }

        public DataTable ListingClaseCertificado(Clase clase)
        {
            return claseDAO.ListarClaseCertificado(clase);
        }

        public string ListingCantidadNuevosConductores(Clase clase)
        {
            return claseDAO.ListarCantidadDeNuevosConductores(clase);
        }

        public bool SearchingInstructorClase(Clase clase)
        {
            return claseDAO.SearchInstructorClaseValidacion(clase);
        }

        #endregion
    }
}
