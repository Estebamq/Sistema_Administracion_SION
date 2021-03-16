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
    public class AlumnosDAO:ConnectionSql
    {
        /// <summary>
        /// Crea Alumnos en la base de datos
        /// </summary>
        /// <param name="alumno"></param>

        public void CreateAlumno(Alumno alumno)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_createAlumno", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    

                    cmd.Parameters.AddWithValue("@nombre", alumno.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", alumno.Apellido);
                    cmd.Parameters.AddWithValue("@dni", alumno.Dni);
                    cmd.Parameters.AddWithValue("@telefono", alumno.Telefono);
                    cmd.Parameters.AddWithValue("@direccion", alumno.Direccion);
                    cmd.Parameters.AddWithValue("@email", alumno.Email);
                    cmd.Parameters.AddWithValue("@fechadenacimiento", alumno.FechaDeNacimiento);
                    cmd.Parameters.AddWithValue("@estadoA", alumno.Estado);
                    cmd.Parameters.AddWithValue("@observaciones", alumno.Observaciones);

                    cmd.ExecuteNonQuery();
                    
                }
            }
        }

        /// <summary>
        /// Actualiza Alumnos en la base de datos
        /// </summary>
        /// <param name="alumno"></param>
        public void UpdateAlumno(Alumno alumno)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_updateAlumno", connection))
                {

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id", alumno.Id);
                    cmd.Parameters.AddWithValue("@nombre", alumno.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", alumno.Apellido);
                    cmd.Parameters.AddWithValue("@dni", alumno.Dni);
                    cmd.Parameters.AddWithValue("@telefono", alumno.Telefono);
                    cmd.Parameters.AddWithValue("@direccion", alumno.Direccion);
                    cmd.Parameters.AddWithValue("@email", alumno.Email);
                    cmd.Parameters.AddWithValue("@fechadenacimiento", alumno.FechaDeNacimiento);
                    cmd.Parameters.AddWithValue("@estadoA", alumno.Estado);
                    cmd.Parameters.AddWithValue("@observaciones", alumno.Observaciones);
                    cmd.ExecuteNonQuery();
                    
                }
            }
        }
        /// <summary>
        /// Da de baja el alumno 
        /// </summary>
        /// <param name="alumno"></param>
        public void UpdateBajaAlumno(Alumno alumno)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_bajaAlumno", connection))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", alumno.Id);
                    cmd.Parameters.AddWithValue("@estadoA", alumno.Estado);
                    

                    cmd.ExecuteNonQuery();

                }
            }
        }

        /// <summary>
        /// Lista los Alumnos en la base de datos
        /// </summary>
        /// <returns></returns>
        public DataTable ListarAlumno()
        {

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SP_listAlumn", connection))
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

        public DataTable ListarAlumnoPorEstado(Alumno alumno)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_listarAlumPorEstado", connection))
                {
                    DataTable tabla = new DataTable();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@searchEstado", alumno.Estado);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                    return tabla;
                }
            }

        }

        //BUSCAR ALUMNO

        //POR NOMBRE
        public DataTable SearchAlumnoNombre(Alumno alumno)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_seachAlumnoNombre", connection))
                {
                    DataTable tabla = new DataTable();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@searchNombre", alumno.Search);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                    return tabla;
                }
            }
        }

        //POR APELLIDO
        public DataTable SearchAlumnoApellido(Alumno alumno)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_seachAlumnoApellido", connection))
                {
                    DataTable tabla = new DataTable();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@searchApellido", alumno.Search);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                    return tabla;
                }
            }
        }
        //POR ID
        public DataTable SearchAlumnoId(Alumno alumno)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_seachAlumId", connection))
                {
                    DataTable tabla = new DataTable();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@searchId", alumno.Search);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                    return tabla;
                }
            }
        }

        public DataTable SearchAlumnoDni(Alumno alumno)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_searchAlumnoDni", connection))
                {
                    DataTable tabla = new DataTable();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@searchDni", alumno.Search);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                    return tabla;
                }
            }
        }


        public void DeleteAlumno(Alumno alumno)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_deleteAlumno", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", alumno.Id);
                    cmd.ExecuteNonQuery();

                }
            }
        }
    }
}
