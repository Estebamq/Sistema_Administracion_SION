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

        private int userId;
        private string nombreUsuario;
        private string contraseña;
        private string nombre;
        private string apellido;
        private string email;
        private int    idCargo;
        private string cargo;


        UsuarioDAO usuarioDAO = new UsuarioDAO();
        #region CONSTRUCTORES
        public Usuario(int userId, string nombreUsuario, string contraseña, string nombre, string apellido, string email, string cargo)
        {
            this.userId = userId;
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.cargo = cargo;
        }

        public Usuario() 
        {

        }
        #endregion

        #region PROPIEDADES
        public int UserId { get => userId; set => userId = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Email { get => email; set => email = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public int IdCargo { get => idCargo; set => idCargo = value; }
        #endregion



        #region METODOS
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

        public bool GeneratingBackUp() 
        {
            return usuarioDAO.GenerateBackUp();
        }

        public bool CreatingUsuario(Usuario usuarioNuevo) 
        {
            //busco si existe el "Nombre de usuario", si existe no dejo crear un nuevo usuario
            bool existeNombreUsuario=false;
            List<Usuario> usuariosLista = new List<Usuario>();
            usuariosLista = ListingUsuariosActivos();
            foreach (Usuario usuarioAComparar in usuariosLista)
            {
                if (usuarioAComparar.nombreUsuario == usuarioNuevo.nombreUsuario) 
                {
                    existeNombreUsuario = true;
                    break;
                }

            }
            //si no existe el nombre entonces si permito crearlo
            if (!existeNombreUsuario) {
                UsuarioDAO usuarioDao = new UsuarioDAO();
                usuarioDao.CreateAlumno(usuarioNuevo);
            }
            return existeNombreUsuario;
        }

        public List<Usuario> ListingUsuariosActivos() 
        {
            UsuarioDAO usuarioDao = new UsuarioDAO();
            return usuarioDao.ListUsuariosActivos();
        }


        public void DeletingUsuario(Usuario usuario) 
        {
            usuarioDAO.DeleteUsuario(usuario);
        }
        #endregion

    }
}
