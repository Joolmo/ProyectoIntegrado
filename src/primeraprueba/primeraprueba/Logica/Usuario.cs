using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Drawing;

namespace primeraprueba
{
    public class Usuario
    {
        private int id_usuario;
        private string nombre;
        private string contraseña;
        private string correo;
        private string descripcion;
        private int numSeguidores;
        private int numRecetas;
        private Image foto;

        static Usuario usuarioActual = null;
        static public Usuario UsuarioActual { get { return usuarioActual; } }

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

            descripcion = (string)listaUsuario[2];

            correo = (string)listaUsuario[3];
            contraseña = (string)listaUsuario[4];
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
            string consulta = string.Format("select * from usuario");
            List<List<object>> lista = ConexionBBDD.Instanciar().Query(consulta);

            ConexionBBDD.Instanciar().CerrarConexion();

            if (lista == null) return null;

            foreach (List<object> l1 in lista)
                List_Usuario.Add(new Usuario(l1));

            return List_Usuario;
        }



        //Funcionalidad para insertar un usuario en la base de datos;
        public static bool RegistrarUsuario(Usuario u)
        {
            ConexionBBDD.Instanciar().AbrirConexion();

            string passhash = ConexionBBDD.EncriptarContraseña(u.Contraseña);
            string consulta = String.Format(
                "INSERT INTO usuario(Nombre_Usuario, Correo, Contraseña, N_Receta, N_Seguidor, Foto, descripcion) " +
                "VALUES('{0}','{1}','{2}',0,0, @foto,'')", u.Nombre, u.Correo, passhash
            );
            
            bool funciona = ConexionBBDD.Instanciar().NonQuery(consulta, u.foto);

            ConexionBBDD.Instanciar().CerrarConexion();

            return funciona;
        }

        public static bool LogIn(string nom, string passwd)
        {
            ConexionBBDD.Instanciar().AbrirConexion();

            string passhash = ConexionBBDD.EncriptarContraseña(passwd);
            string consulta = String.Format(
                "SELECT * FROM usuario WHERE nombre_usuario = '{0}' AND contraseña ='{1}'"
                , nom, passhash
            );

            var resultado = ConexionBBDD.Instanciar().Query(consulta);
            
            ConexionBBDD.Instanciar().CerrarConexion();
            if(resultado != null)
            {
                if (resultado.Count == 0)
                    return false;
                else
                {

                    Usuario usuario = new Usuario(resultado[0]);
                    usuarioActual = usuario;

                    return true;
                }
            }
            else
                return false;
        }

        public static List<Usuario> GetSeguidos(int id)
        {
            ConexionBBDD.Instanciar().AbrirConexion();

            List<Usuario> list_usuario = new List<Usuario>();
            string consulta = string.Format("SELECT usuario.* from seguidores inner join usuario on seguidores.ID_SIGUIENDO = usuario.ID_Usuario where seguidores.ID_USUARIO ={0}", id);
            List <List<object>> lista = ConexionBBDD.Instanciar().Query(consulta);

            foreach (List<object> l1 in lista)
                list_usuario.Add(new Usuario(l1));

            ConexionBBDD.Instanciar().CerrarConexion();
            return list_usuario;
        }

        public static List<Usuario> GetSeguidores(int id)
        {
            ConexionBBDD.Instanciar().AbrirConexion();

            List<Usuario> list_usuario = new List<Usuario>();
            string consulta = string.Format("SELECT usuario.* from seguidores inner join usuario on seguidores.ID_USUARIO = usuario.ID_Usuario where seguidores.ID_SIGUIENDO ={0}", id);
            List<List<object>> lista = ConexionBBDD.Instanciar().Query(consulta);

            foreach (List<object> l1 in lista)
                list_usuario.Add(new Usuario(l1));

            ConexionBBDD.Instanciar().CerrarConexion();
            return list_usuario;
        }


        //public bool CambiarContraseña(string correo, string nuevaC)
        //{
        //    ConexionBBDD.Instanciar().AbrirConexion();
        //    string consulta = String.Format(
        //        "updare usuario set Contraseña='{0}' where Correo={1}",nuevaC , correo)
        //}

        public static void LogOff()
        {
            usuarioActual = null;
        }

        //Funcionalidad usada para insertar en la base de datos cuando se quiere seguir a un usuario
        public static bool Seguir(int id)
        {
            ConexionBBDD.Instanciar().AbrirConexion();
            string consulta = string.Format(
                "SELECT * FROM seguidores where ID_USUARIO='{0}' AND ID_SIGUIENDO='{1}'",
                UsuarioActual.id_usuario, id
            );
            
            List<List<object>> funciona = ConexionBBDD.Instanciar().Query(consulta);
            if(funciona == null)
                return false;
            else
            {
                if (funciona.Count == 0)
                {
                    consulta = String.Format(
                    "INSERT INTO seguidores Values('{0}','{1}')", UsuarioActual.ID_Usuario, id
                    );
                    funciona = ConexionBBDD.Instanciar().Query(consulta);
                    return true;

                }
                else
                {
                    consulta = String.Format(
                        "Delete from seguidores where ID_USUARIO='{0}' AND ID_SIGUIENDO='{1}'", UsuarioActual.ID_Usuario, id
                        );
                    funciona = ConexionBBDD.Instanciar().Query(consulta);
                    return true;
                }
            }
        }

        public static void ModificarUsuario(int id, string desc, string passwd, Image foto)
        {
            ConexionBBDD.Instanciar().AbrirConexion();
            string pas = ConexionBBDD.EncriptarContraseña(passwd);
            string consulta = String.Format(
                "UPDATE usuario SET descripcion='{0}', Contraseña = '{1}',Foto = @foto WHERE ID_Usuario={2}",desc, pas, id
            );

            bool funciona = ConexionBBDD.Instanciar().NonQuery(consulta, foto);
            ConexionBBDD.Instanciar().CerrarConexion();

        }
    }
}
