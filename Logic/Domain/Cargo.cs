using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.DataAccess;

namespace Logic.Domain
{
    public class Cargo
    {
        #region ATTRIBUTOS
        private int idCargo;
        private string nombreCargo;
        #endregion
        UsuarioDAO cargo = new UsuarioDAO();


        #region CONSTRUCTORES
        public Cargo(int idCargo, string nombreCargo)
        {
            this.IdCargo = idCargo;
            this.NombreCargo = nombreCargo;
        }
        public Cargo()
        {

        }
        #endregion

        #region PROPIEDADES
        public int IdCargo
        {
            get { return idCargo; }
            set { idCargo = value; }
        }
        public string NombreCargo
        {
            get { return nombreCargo; }
            set { nombreCargo = value; }
        }
        #endregion

        #region METODOS
        public List<Cargo> ListingCargosPersonal(string searchCargo)
        {
            return cargo.ListCargoPersonal(searchCargo);
        }

        public Cargo ListingCargosPersonalId(int searchIdCargo)
        {
            return cargo.ListCargoPersonalId(searchIdCargo);
        }
        #endregion
    }
}
