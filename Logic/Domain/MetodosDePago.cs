using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.DataAccess;
namespace Logic.Domain
{
    public class MetodosDePago
    {
        private int id;
        private string metodoDePago;
        
        MetodosDePagoDAO metodosDePagoDAO= new MetodosDePagoDAO();

        public MetodosDePago()
        {
            
        }
        public MetodosDePago(int id, string metodoDePago)
        {
            this.id = id;
            this.metodoDePago = metodoDePago;
        }

        #region Propiedades
        public int Id 
        {
            get { return id; }
            set { id = value; }
        }
        public string MetodoDePago 
        {
            get { return metodoDePago; }
            set { metodoDePago = value; }
        }
        #endregion

        #region Metodos
        public List<MetodosDePago> ListingMetodosDePago(string search)
        {
            return metodosDePagoDAO.MetodosDePagoList(search);
        }

        public List<MetodosDePago> ListingTodosLosMetodosDePago()
        {
            return metodosDePagoDAO.MetodosDePagoTodos();
        }

        public void CreatingMedioDePago(string medioDePago) 
        {
            metodosDePagoDAO.CreateMedioDePago(medioDePago);
        }

        public void DeletingMedioDePago(int idMedioDePago)
        {
            metodosDePagoDAO.DeleteMedioDePago(idMedioDePago);
        }
        #endregion
    }
}
