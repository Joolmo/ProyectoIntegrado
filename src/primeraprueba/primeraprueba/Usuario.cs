using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace primeraprueba
{
    class Usuario
    {
        private int id_usuario;
        private string nombre;
        private string contraseña;
        private string correo;
        private string descripcion;

        public int ID_Usuario { get { return id_usuario; } }
        public string Nombre { get { return nombre; } }
        public string Contraseña { get { return contraseña; } set { contraseña = value; } }
        public string Correo { get { return correo; } }
        public string Descripcion { get { return descripcion;  } set { descripcion = value; } }

        public Usuario(string nomb, string paswd, string mail)
        {
            nombre = nomb;
            contraseña = paswd;
            correo = mail;
        }


        //Funcionalidad para insertar un usuario en la base de datos;
        public void Insertar_Usuario(MySqlConnection conexion, Usuario u)
        { 


        }

        //Funcionalidad usada para insertar en la base de datos cuando se quiere seguir a un usuario
        public void Seguir()
        {



        }

        //Funcionalidad para dejar de seguir a un usuario
        public void dejarSeguir()
        {



        }

        //Hace la consulta para contar los seguidores de cierto usuario
        public int Cont_NumSeguidores()
        {
			throw new NotImplementedException();


		}


        //Hace la consulta para contar el numero de recetas de cierto usuario
        public int Cont_NumRecetas()
        {
			throw new NotImplementedException();

		}

        




    }
}
