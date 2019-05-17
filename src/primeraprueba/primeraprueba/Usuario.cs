using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        static Usuario usuarioActual = new Usuario();

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

        public Usuario()
        {

        }


        //Funcionalidad para insertar un usuario en la base de datos;
        public void RegistrarUsuario(MySqlConnection conexion, Usuario u)
        {
            string passhash = ConexionBBDD.EncriptarContraseña(u.Contraseña);
            string consulta = String.Format("INSERT INTO usuario(Nombre_Usuario, descripcion, Correo, Contraseña, NºReceta, NºSeguidor) " +
                "VALUES('{0}','{1}','{2}','{3}',0,0)", u.Nombre, u.Descripcion, u.Correo, passhash);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            int retorno = comando.ExecuteNonQuery();

        }

        public Usuario LogIn(MySqlConnection conexion, string nom, string passwd)
        {
            string passhash = ConexionBBDD.EncriptarContraseña(passwd);
            string consulta = String.Format("SELECT * FROM usuario WHERE nombre_usuario = '{0}' " +
                "AND contraseña ='{1}'", nom, passhash);
            Usuario user = new Usuario();

            List <List<object>> lista = ConexionBBDD.Instanciar().Query(consulta);
            foreach (List<object> l1 in lista)
            {
                user.nombre = (string)l1[1];
                user.correo = (string)l1[3];
                user.contraseña = (string)l1[4];
            }
            return user;

        }

        public Usuario LogOut(MySqlConnection conexion, string nom, string passwd)
        {
            usuarioActual.nombre = null;
            usuarioActual.correo = null;
            usuarioActual.contraseña = null;

            return usuarioActual;
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
