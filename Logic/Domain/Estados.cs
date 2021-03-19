using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.DataAccess;

namespace Logic.Domain
{
    public class Estados
    {
        private int id;
        //estadosA son los estados de los alumnos (Alta/Baja)
        private string estadoA;
        //estadosI son los estados de los instructores(Alta/Baja)
        private string estadoI;
        //estadoP son los estados de los Alumnos en las Clases
        private string estadoP;

        EstadosDAO estadosDAO = new EstadosDAO();

        #region PROPIEDADES
        public int Id { get => id; set => id = value; }
        public string EstadoA { get => estadoA; set => estadoA = value; }
        public string EstadoI { get => estadoI; set => estadoI = value; }
        public string EstadoP { get => estadoP; set => estadoP = value; }
        #endregion

        #region METODOS
        public List<Estados> ListingEstadosA(string search)
        {
            return estadosDAO.EstadosALumnosList(search);
        }

        public List<Estados> ListingEstadosI(string search)
        {
            return estadosDAO.EstadosInstructoresList(search);
        }
        public List<Estados> ListingEstadosP(string search)
        {
            return estadosDAO.EstadosPresenteList(search);
        }
        #endregion
    }
}
