using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeraprueba
{
    class Reto
    {
        private int id_usuario;
        private string nombre;
        private DateTime fecha_inicial;
        private DateTime fecha_final;
        private int idreto;
        private string descripcion;


        public string Nombre { get { return nombre; } }
        public int ID_Usuario { get { return id_usuario; } }
        public DateTime Fecha_Inicial { get { return fecha_inicial; } }
        public DateTime Fecha_Final { get { return fecha_final; } }
        public int IdReto { get { return idreto; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public ConexionBBDD bbdd = ConexionBBDD.Instanciar();


        public Reto(int id, string nom, string desc, DateTime fecha_i, DateTime fecha_f)
        {
            id_usuario = id;
            nombre = nom;
            fecha_inicial = fecha_i;
            fecha_final = fecha_f;
            descripcion = desc;
        }

        public Reto()
        {

        }

        public Reto(List<object> listaReto)
        {
            idreto = (int)listaReto[0];
            id_usuario = (int)listaReto[1];
            idreto = (int)listaReto[0];
            nombre = (string)listaReto[2];
            descripcion = (string)listaReto[3];
            fecha_inicial = (DateTime)listaReto[4];
            fecha_final = (DateTime)listaReto[5];

        }

        //Obtiene una lista de los retos del usuario seleccionado
        static List<Reto> GetRetos(int user)
        {
            List<Reto> List_Reto = new List<Reto>();

            ConexionBBDD.Instanciar().AbrirConexion();

            string consulta = string.Format("select * from retos where ID_Usuario_P={0}", user);
            List<List<object>> lista = ConexionBBDD.Instanciar().Query(consulta);

            ConexionBBDD.Instanciar().AbrirConexion();

            if (lista == null) return null;

            foreach (List<object> l1 in lista)
                List_Reto.Add(new Reto(l1));

            return List_Reto;
        }


        public static bool CrearReto(Reto ret)
        {
            string consulta = string.Format(
                "insert into reto values(null,'{0}','{1}','{2}','{3}','{4}')",
                ret.id_usuario, ret.nombre, ret.descripcion, ret.fecha_inicial, ret.fecha_final
            );

            ConexionBBDD.Instanciar().AbrirConexion();
            bool result = ConexionBBDD.Instanciar().NonQuery(consulta);
            ConexionBBDD.Instanciar().CerrarConexion();

            if (result) return true;

            string error = ConexionBBDD.Instanciar().LastError;
            return false;
        }

        public static bool BorrarReto(int id)
        {
            string consulta = string.Format("Delete from reto where ID_Reto={0}", id);

            ConexionBBDD.Instanciar().AbrirConexion();
            bool result = ConexionBBDD.Instanciar().NonQuery(consulta);
            ConexionBBDD.Instanciar().CerrarConexion();

            if (result) return true;

            string error = ConexionBBDD.Instanciar().LastError;
            return false;

        }

        public static Reto GetReto(int id)
        {
            string consulta = string.Format("select * from retos where ID_Reto={0}", id);

            ConexionBBDD.Instanciar().AbrirConexion();
            List<List<object>> lista = ConexionBBDD.Instanciar().Query(consulta);
            ConexionBBDD.Instanciar().CerrarConexion();

            if (lista == null) return null;
            return new Reto(lista[0]);
        }
    }
}
