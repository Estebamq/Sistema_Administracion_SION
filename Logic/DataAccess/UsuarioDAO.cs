using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using Logic.Cache;

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
                            UserLoginCache.nombre = reader.GetString(3);
                            UserLoginCache.apellido = reader.GetString(4);
                            UserLoginCache.email = reader.GetString(5);
                            UserLoginCache.cargo = reader.GetString(6);
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
       




    }

}
