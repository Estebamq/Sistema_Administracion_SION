using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.DataAccess;


namespace Logic.Domain
{
    public class Usuario
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();

        /// <summary>
        /// Recibe el USUARIO y la CONTRASEÑA y valida si existen los datos
        /// </summary>
        /// <param name="user">USUARIO</param>
        /// <param name="pass">CONTRASEÑA</param>
        /// <returns>Devuelve true si los datos existen</returns>
        public bool LoginUsuario(string user,string pass) 
        {
            return usuarioDAO.Login(user,pass);

        }

    }
}
