using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public abstract class Persona
    {
        private int id;
        private string nombre;
        private string apellido;
        private int dni;
        private int telefono;
        private string direccion;
        private string email;
        private int estado;

        #region Constructores

        public Persona() 
        {
        }

        public Persona(string nombre, string apellido, int dni, int telefono,
                       string direccion, string email, int estado)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.telefono = telefono;
            this.direccion = direccion;
            this.email = email;
            this.estado = estado;
        }




        public Persona(int id, string nombre, string apellido, int dni, int telefono,
                       string direccion, string email, int estado)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.telefono = telefono;
            this.direccion = direccion;
            this.email = email;
            this.estado = estado;
        }

        #endregion

        #region Propiedades

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        #endregion

    }
}
