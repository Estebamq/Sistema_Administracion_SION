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
    class EstadosDAO: ConnectionSql
    {
        /// <summary>
        /// Trae un listado de la base de datos sobre los estados de los alumnos
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<Estados> EstadosALumnosList(string search)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_searchEstadosA", connection))
                {
                    SqlDataReader readRows;

                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@search", search);

                    readRows = cmd.ExecuteReader();

                    List<Estados> listing = new List<Estados>();

                    while (readRows.Read())
                    {
                        listing.Add(new Estados
                        {
                            Id = readRows.GetInt32(0),
                            EstadoA = readRows.GetString(1),
                            
                        });
                    }


                    readRows.Close();

                    return listing;
                }
            }
        }
        /// <summary>
        /// Trae los estados de los instructores
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<Estados> EstadosInstructoresList(string search)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_searchEstadosI", connection))
                {
                    SqlDataReader readRows;

                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@search", search);

                    readRows = cmd.ExecuteReader();

                    List<Estados> listing = new List<Estados>();

                    while (readRows.Read())
                    {
                        listing.Add(new Estados
                        {
                            Id = readRows.GetInt32(0),
                            EstadoI = readRows.GetString(1),

                        });
                    }


                    readRows.Close();

                    return listing;
                }
            }
        }


        public List<Estados> EstadosPresenteList(string search)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_searchEstadosP", connection))
                {
                    SqlDataReader readRows;

                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@search", search);

                    readRows = cmd.ExecuteReader();

                    List<Estados> listing = new List<Estados>();

                    while (readRows.Read())
                    {
                        listing.Add(new Estados
                        {
                            Id = readRows.GetInt32(0),
                            EstadoP = readRows.GetString(1),

                        });
                    }


                    readRows.Close();

                    return listing;
                }
            }
        }
    }
}
