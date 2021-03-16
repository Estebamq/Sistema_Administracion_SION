using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.DataAccess;
using System.Data;




namespace Logic
{
    public class InstructoresDAO:ConnectionSql
    {
        

        public void CreateInstructor(Instructor instructor)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_createInstructor", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@nombre", instructor.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", instructor.Apellido);
                    cmd.Parameters.AddWithValue("@dni", instructor.Dni);
                    cmd.Parameters.AddWithValue("@telefono", instructor.Telefono);
                    cmd.Parameters.AddWithValue("@direccion", instructor.Direccion);
                    cmd.Parameters.AddWithValue("@email", instructor.Email);
                    cmd.Parameters.AddWithValue("@estadoI", instructor.Estado);
                    cmd.Parameters.AddWithValue("@patenteAuto", instructor.Patente);
                    cmd.Parameters.AddWithValue("@modeloAuto", instructor.ModeloAuto);
                    cmd.Parameters.AddWithValue("@vencimientoSeguro", instructor.FechaVencimientoSeguro);

                    cmd.ExecuteNonQuery();

                }
            }
        }
        public void UpdateInstructor(Instructor instructor)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_updateInstructor", connection))
                {

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id", instructor.Id);
                    cmd.Parameters.AddWithValue("@nombre", instructor.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", instructor.Apellido);
                    cmd.Parameters.AddWithValue("@dni", instructor.Dni);
                    cmd.Parameters.AddWithValue("@telefono", instructor.Telefono);
                    cmd.Parameters.AddWithValue("@direccion", instructor.Direccion);
                    cmd.Parameters.AddWithValue("@email", instructor.Email);
                    cmd.Parameters.AddWithValue("@estadoI", instructor.Estado);
                    cmd.Parameters.AddWithValue("@modeloAuto", instructor.ModeloAuto);
                    cmd.Parameters.AddWithValue("@patenteAuto", instructor.Patente);
                    cmd.Parameters.AddWithValue("@vencimientoSeguro", instructor.FechaVencimientoSeguro);

                    
                    

                    cmd.ExecuteNonQuery();

                }
            }
        }


        public DataTable ListarInstructor()
        {

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SP_listarInstructores", connection))
                {

                    DataTable table = new DataTable();

                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader readRows = command.ExecuteReader();

                    table.Load(readRows);

                    readRows.Close();

                    return table;
                }
            }


        }

        public DataTable ListarInstructorPorEstado(Instructor instructor)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_listarInstructorPorEstado", connection))
                {
                    DataTable tabla = new DataTable();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@searchEstado", instructor.Estado);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                    return tabla;
                }
            }

        }

       

        public void UpdateBajaInstructor(Instructor instructor)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_bajaInstructor", connection))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", instructor.Id);
                    cmd.Parameters.AddWithValue("@estadoI", instructor.Estado);


                    cmd.ExecuteNonQuery();

                }
            }
        }

        //BUSCAR INSTRUCTOR

        //POR NOMBRE
        public DataTable SearchInstructorNombre(Instructor instructor)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_searchInstructorNombre", connection))
                {
                    DataTable tabla = new DataTable();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@searchNombre", instructor.Search);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                    return tabla;
                }
            }
        }

        //POR APELLIDO
        public DataTable SearchInstructorApellido(Instructor instructor)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_searchInstructorApellido", connection))
                {
                    DataTable tabla = new DataTable();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@searchApellido", instructor.Search);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                    return tabla;
                }
            }
        }

        //POR ID
        public DataTable SearchInstructorId(Instructor instructor)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_searchInstructorId", connection))
                {
                    DataTable tabla = new DataTable();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@searchId", instructor.Search);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                    return tabla;
                }
            }
        }

        //POR DNI
        public DataTable SearchInstructorDni(Instructor instructor)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_searchInstructorDni", connection))
                {
                    DataTable tabla = new DataTable();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@searchDni", instructor.Search);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                    return tabla;
                }
            }
        }
        //LISTAR INSTRUCTORES EN LA PLANILLA
        public List<Instructor> SearchInstructorIdPlanilla(Instructor instructor)
        {


            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_searchInstructorIdClase", connection))
                {
                    SqlDataReader readRows;

                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@searchId", instructor.Search);

                    readRows = cmd.ExecuteReader();

                    List<Instructor> listing = new List<Instructor>();

                    while (readRows.Read())
                    {
                        listing.Add(new Instructor
                        {
                            Id = readRows.GetInt32(0),
                            Nombre = readRows.GetString(1),
                            Apellido = readRows.GetString(2),
                            Telefono = readRows.GetInt32(3),

                        });
                    }


                    readRows.Close();

                    return listing;
                }
            }
        }
        public void DeleteInstructor(Instructor instructor)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_deleteInstructor", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", instructor.Id);
                    cmd.ExecuteNonQuery();

                }
            }
        }
    }
}
