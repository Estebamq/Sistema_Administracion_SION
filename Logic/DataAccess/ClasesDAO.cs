using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.DataAccess;
using Logic.Domain;


namespace Logic
{
    public class ClasesDAO : ConnectionSql
    {
        public void CreateClase(Clase clase)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_createClases", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@numClase", clase.NumClase);
                    cmd.Parameters.AddWithValue("@idAlumno", clase.IdAlumno);
                    cmd.Parameters.AddWithValue("@idInstructor", clase.IdInstructor);
                    cmd.Parameters.AddWithValue("@fecha", clase.Fecha);
                    cmd.Parameters.AddWithValue("@hora", clase.Hora);
                    cmd.Parameters.AddWithValue("@idPresente", clase.IdPresente);
                    cmd.Parameters.AddWithValue("@idMetodoPago", clase.IdMetodoDePago);
                    cmd.Parameters.AddWithValue("@descripcion", clase.Descripcion);

                    cmd.ExecuteNonQuery();

                }
            }
        }

        public void UpdateClase(Clase clase)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_UpdateClase", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idClase", clase.Id);
                    cmd.Parameters.AddWithValue("@numClase", clase.NumClase);
                    cmd.Parameters.AddWithValue("@idAlumno", clase.IdAlumno);
                    cmd.Parameters.AddWithValue("@idInstructor", clase.IdInstructor);
                    cmd.Parameters.AddWithValue("@fecha", clase.Fecha);
                    cmd.Parameters.AddWithValue("@hora", clase.Hora);
                    cmd.Parameters.AddWithValue("@idPresente", clase.IdPresente);
                    cmd.Parameters.AddWithValue("@idMetodoPago", clase.IdMetodoDePago);
                    cmd.Parameters.AddWithValue("@descripcion", clase.Descripcion);

                    cmd.ExecuteNonQuery();

                }
            }
        }

        public void UpdateAsistenciaClase(Clase clase) 
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_ActualizarAsistenciaAlumno", connection))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idClase", clase.Id);
                    cmd.Parameters.AddWithValue("@estadoPresente", clase.IdPresente);


                    cmd.ExecuteNonQuery();

                }
            }

        }

        public DataTable ListarInstructorClase(Clase clase)
        {

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_listInstructorClases", connection))
                {

                    DataTable tabla = new DataTable();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@searchFecha", clase.SearchFecha);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                    return tabla;
                }
            }

        }

        public bool SearchInstructorClaseValidacion(Clase clase)
        {
            bool respuesta = false;
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_SearchInstruClasesValidacion", connection))
                {

                    SqlDataReader readRows;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@searchFecha", clase.Fecha);
                    cmd.Parameters.AddWithValue("@searchHora", clase.Hora);
                    cmd.Parameters.AddWithValue("@searchIdInstructor", clase.IdInstructor);


                    readRows = cmd.ExecuteReader();

                    List<Clase> listing = new List<Clase>();

                    while (readRows.Read())
                    {
                        listing.Add(new Clase
                        {
                            IdInstructor = readRows.GetInt32(3),
                            Fecha = readRows.GetDateTime(4),
                            Hora = readRows.GetDateTime(5)

                        });
                    }


                    readRows.Close();
                    //Despues de buscar el instructor en la base de dato corroboro si lo encontro cambio a true la respuesta.
                    foreach (Clase claseInstructor in listing)
                    {
                        if (claseInstructor.IdInstructor == clase.IdInstructor) 
                        {
                            respuesta = true;
                        }
                    }


                }
                
                    return respuesta;
                
            }

        }
        public DataTable ListarClasesPorIdAlumno(Clase clase)
        {

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_listClasesPorIdAlumno", connection))
                {

                    DataTable tabla = new DataTable();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@searchIdAlumno", clase.IdAlumno);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                    return tabla;
                }
            }

        }

        //LISTAR CLASE POR FECHA Y ID DE INSTRUCTOR

        public List<ReporteClase> ListarInstructorIdPlanilla(Clase clase)
        {


            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_listClasesPorIdInstructor", connection))
                {
                    SqlDataReader reader;

                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@searchIdInstructor", clase.IdInstructor);
                    cmd.Parameters.AddWithValue("@searchFechaClase", clase.Fecha);

                    reader = cmd.ExecuteReader();

                    List<ReporteClase> listing = new List<ReporteClase>();

                    while (reader.Read())
                    {
                        string nombreAlumno =(string) reader[0];
                        string apellidoAlumno = (string)reader[1];
                        string direccionAlumno = (string)reader[2];
                        int numClase = (int)reader[3];
                        string dia = DateTime.Parse(reader[4].ToString()).ToString("dd/MM/yyyy");
                        string hora = DateTime.Parse(reader[5].ToString()).ToString("hh: mm");
                        string descripcion = null;
                        if (reader["descripcion"]!=DBNull.Value )
                        {
                            descripcion = reader.GetString(6);
                        }

                        ReporteClase reporteClase = new ReporteClase(nombreAlumno,apellidoAlumno,direccionAlumno,numClase,dia,hora,descripcion);
                        listing.Add(reporteClase);
                    }


                    reader.Close();

                    return listing;
                }
            }
        }

        //BORRAR CLASE
        public void DeleteClase(Clase clase)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_deleteClase", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", clase.Id);
                    cmd.ExecuteNonQuery();

                }
            }
        }
    }
}
