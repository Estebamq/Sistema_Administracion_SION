using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Logic.Domain;


namespace Logic.DataAccess
{
    public class MetodosDePagoDAO :  ConnectionSql
    {
        //CREAR MEDIO DE PAGO
        public void CreateMedioDePago(string medioDePago)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_createMedioDePago", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombreMedioPago", medioDePago);

                    cmd.ExecuteNonQuery();

                }
            }
        }

        //BUSCAR MEDIO DE PAGO
        public List<MetodosDePago> MetodosDePagoList(string search)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_searchMetodosDePago", connection))
                {
                    SqlDataReader readRows;

                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@search", search);

                    readRows = cmd.ExecuteReader();

                    List<MetodosDePago> listing = new List<MetodosDePago>();

                    while (readRows.Read())
                    {
                        listing.Add(new MetodosDePago
                        {
                            Id = readRows.GetInt32(0),
                            MetodoDePago = readRows.GetString(1),

                        });
                    }


                    readRows.Close();

                    return listing;
                }
            }
        }


        //MOSTRAR TODOS LOS MEDIOS DE PAGO
        public List<MetodosDePago> MetodosDePagoTodos()
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_listarMetodosDePago", connection))
                {
                    SqlDataReader readRows;

                    cmd.CommandType = CommandType.StoredProcedure;

                    readRows = cmd.ExecuteReader();

                    List<MetodosDePago> listing = new List<MetodosDePago>();

                    while (readRows.Read())
                    {
                        listing.Add(new MetodosDePago
                        {
                            Id = readRows.GetInt32(0),
                            MetodoDePago = readRows.GetString(1),

                        });
                    }


                    readRows.Close();

                    return listing;
                }
            }
        }

        //BORRAR MEDIO DE PAGO
        public void DeleteMedioDePago(int idMedioDePago)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_deleteMedioDePago", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idMedioDePago", idMedioDePago);
                    cmd.ExecuteNonQuery();

                }
            }
        }
    }
}
