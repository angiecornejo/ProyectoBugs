using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoBugs.Clases
{
    class Usuario
    {
        // Atributos
        private int id_usuario;
        private string n_usuario;
        private string password;
        private string email;
        private int id_perfil;

        // Property
        public int Id_usuario
        {
            get {return id_usuario; }
            set { id_usuario = value; }
        }
        public string N_usuario
        {
            get { return n_usuario; }
            set { n_usuario = value; }
        }

        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public int Id_perfil { get => id_perfil; set => id_perfil = value; }

        public int validarUsuario(string nombre, string clave)
        {
            
            return 0;
        }

    }
}
