using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

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

    }
}
