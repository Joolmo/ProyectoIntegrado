using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using Dispenser;
namespace primeraprueba
{
    class Usuario
    {
        private int id_usuario;
        private string nombre;
        private string contraseña;
        private string correo;
        private string descripcion;
        private int numSeguidores;
        private int numRecetas;
        private Image foto;

        static Usuario usuarioActual = new Usuario();

        public int ID_Usuario { get { return id_usuario; } }
        public string Nombre { get { return nombre; } }
        public string Contraseña { get { return contraseña; } set { contraseña = value; } }
        public string Correo { get { return correo; } }
        public string Descripcion { get { return descripcion;  } set { descripcion = value; } }
        public int NumeroSeguidores { get { return numSeguidores; } }
        public int NumeroRecetas { get { return numRecetas; } }
        public Image Foto { get { return foto; } }

        public Usuario(string nomb, string paswd, string mail, string desc, Image f)
        {
            nombre = nomb;
            contraseña = paswd;
            correo = mail;
            descripcion = desc;
            foto = f;

        }

        public Usuario()
        {

        }

        public Usuario(List<object> listaUsuario)
        {
                id_usuario = (int)listaUsuario[0];
                nombre = (string)listaUsuario[1];
                //descripcion = (string)listaUsuario[2];
                correo = (string)listaUsuario[3];
                contraseña = ConexionBBDD.EncriptarContraseña((string)listaUsuario[4]);
                numRecetas = (int)listaUsuario[5];
                numSeguidores = (int)listaUsuario[6];
                foto = ConexionBBDD.FromByteToImage((byte[])listaUsuario[7]);
        }

        //Obtiene un usuario con un id
        public static Usuario GetUsuario(int id)
        {
            ConexionBBDD.Instanciar().AbrirConexion();
            List<Usuario> List_Usuario = new List<Usuario>();
            string consulta = string.Format("select * from usuario where ID_Usuario={0}", id);
            List<List<object>> lista = ConexionBBDD.Instanciar().Query(consulta);
            ConexionBBDD.Instanciar().CerrarConexion();
            if (lista == null) return null;


            return new Usuario(lista[0]);

             
        }

        //Obtener todos los usuarios
        public static List<Usuario> GetUsuarios()
        {
            ConexionBBDD.Instanciar().AbrirConexion();
            List<Usuario> List_Usuario = new List<Usuario>();
            Usuario us;
            string consulta = string.Format("select * from usuario");
            List<List<object>> lista = ConexionBBDD.Instanciar().Query(consulta);
            ConexionBBDD.Instanciar().CerrarConexion();

            if (lista == null) return null;

            foreach (List<object> l1 in lista)
            {
                us = new Usuario(l1);
                List_Usuario.Add(us);
            }
            return List_Usuario;
        }



        //Funcionalidad para insertar un usuario en la base de datos;
        public static bool RegistrarUsuario(Usuario u)
        {
            ConexionBBDD.Instanciar().AbrirConexion();
            string passhash = ConexionBBDD.EncriptarContraseña(u.Contraseña);
            string consulta = String.Format("INSERT INTO usuario(Nombre_Usuario, Correo, Contraseña, N_Receta, N_Seguidor, Foto) " +
                "VALUES('{0}','{1}','{2}',0,0, @foto)", u.Nombre, u.Correo, passhash);
            
            bool funciona = ConexionBBDD.Instanciar().NonQuery(consulta, u.foto);

            ConexionBBDD.Instanciar().CerrarConexion();
            return funciona;


        }

        public static Usuario LogIn(string nom, string passwd)
        {
            ConexionBBDD.Instanciar().AbrirConexion();
            string passhash = ConexionBBDD.EncriptarContraseña(passwd);
            string consulta = String.Format("SELECT * FROM usuario WHERE nombre_usuario = '{0}' " +
                "AND contraseña ='{1}'", nom, passhash);

            var resultado = ConexionBBDD.Instanciar().Query(consulta);
            ConexionBBDD.Instanciar().CerrarConexion();
            if (resultado == null)
                return null;
            else
                return new Usuario(resultado[0]);

        }

        public static Usuario LogOff(MySqlConnection conexion, string nom, string passwd)
        {
            var oldUsuario = usuarioActual;
            usuarioActual = null;

            return oldUsuario;
        }

        //Funcionalidad usada para insertar en la base de datos cuando se quiere seguir a un usuario
        public void Seguir()
        {
            throw new NotImplementedException();
        }

        //Funcionalidad para dejar de seguir a un usuario
        public void dejarSeguir()
        {
            throw new NotImplementedException();
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
