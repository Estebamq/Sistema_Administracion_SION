using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using Logic.Cache;
using Logic.Domain;

namespace Logic.DataAccess
{
    public class UsuarioDAO : ConnectionSql
    {
        bool respuesta;
        
        /// <summary>
        /// Verifica si el Usuario y la contraseña estan en la base de datos
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <returns>Devuelve true si existen y son correctos</returns>
        public bool Login(string user, String pass) {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Usuarios WHERE loginName=@user and password=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read()) 
                        {
                            UserLoginCache.idUser = reader.GetInt32(0);
                            UserLoginCache.nombreUsuario = reader.GetString(1);
                            UserLoginCache.password = reader.GetString(2);
                            UserLoginCache.nombre = reader.GetString(3);
                            UserLoginCache.apellido = reader.GetString(4);
                            UserLoginCache.email = reader.GetString(5);
                            UserLoginCache.cargo = reader.GetInt32(6);
                        }
                        respuesta = true;
                    }
                    else 
                    {
                        respuesta = false;
                    }

                    return respuesta;
                }
            }
        }

        public void UpdateUsuario(Usuario usuario)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_updateUsuario", connection))
                {

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@userId", usuario.UserId);
                    cmd.Parameters.AddWithValue("@nombreUsuario", usuario.NombreUsuario);
                    cmd.Parameters.AddWithValue("@password", usuario.Contraseña);
                    cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", usuario.Apellido);
                    cmd.Parameters.AddWithValue("@email", usuario.Email);
                    cmd.ExecuteNonQuery();

                }
            }
        }

        public bool GenerateBackUp()
        {
            bool respuesta=false;
            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    //esto puede ser un método aparte para ejecutar comandos SQL---------------
                    SqlCommand command;
                    command = new SqlCommand(@"backup database AdministracionDB to disk ='c:\ Respaldo\resp.bak' with init,stats=10", connection);
                    command.ExecuteNonQuery();
                    //-------------------------------------------------------------------------
                    respuesta = true;
                }
                finally
                {
                    connection.Close();

                }
                return respuesta;

            }

        }

        //CREAR USUARIOS
        public void CreateAlumno(Usuario usuario)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_createUsuario", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@userName", usuario.NombreUsuario);
                    cmd.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
                    cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", usuario.Apellido);
                    cmd.Parameters.AddWithValue("@email", usuario.Email);
                    cmd.Parameters.AddWithValue("@idCargo", usuario.IdCargo);
                   

                    cmd.ExecuteNonQuery();

                }
            }
        }

        //BUSCAR CARGO DEL USUARIO POR NOMBRE DE CARGO
        public List<Cargo> ListCargoPersonal(string search)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_searchCargoPersonal", connection))
                {
                    SqlDataReader readRows;

                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@search", search);

                    readRows = cmd.ExecuteReader();

                    List<Cargo> listing = new List<Cargo>();

                    while (readRows.Read())
                    {
                        listing.Add(new Cargo

                        {
                            IdCargo = readRows.GetInt32(0),
                            NombreCargo = readRows.GetString(1),

                        });
                    }


                    readRows.Close();

                    return listing;
                }
            }
        }
        ////BUSCAR CARGO DEL USUARIO POR ID DE CARGO
        public Cargo ListCargoPersonalId(int search)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_searchCargoPersonalID", connection))
                {
                    SqlDataReader reader;

                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@search", search);

                    reader = cmd.ExecuteReader();

                   Cargo cargo = new Cargo();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            cargo.IdCargo = reader.GetInt32(0);
                            cargo.NombreCargo = reader.GetString(1);


                        }
                    }

                    

                    return cargo;
                }
            }
        }

        //BUSCAR CARGO DEL USUARIO POR NOMBRE DE CARGO
        public List<Usuario> ListUsuariosActivos()
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_listarUsuariosActivos", connection))
                {
                    SqlDataReader readRows;

                    cmd.CommandType = CommandType.StoredProcedure;
                    readRows = cmd.ExecuteReader();

                    List<Usuario> listing = new List<Usuario>();

                    while (readRows.Read())
                    {
                        listing.Add(new Usuario

                        {
                            UserId = readRows.GetInt32(0),
                            NombreUsuario = readRows.GetString(1),
                            Nombre = readRows.GetString(2),
                            Apellido = readRows.GetString(3),
                            Email = readRows.GetString(4),
                            Cargo = readRows.GetString(5),

                        });
                    }


                    readRows.Close();

                    return listing;
                }
            }
        }

        public void DeleteUsuario(Usuario usuario)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_deleteUsuario", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idUsuario", usuario.UserId);
                    cmd.ExecuteNonQuery();

                }
            }
        }

    }

}
