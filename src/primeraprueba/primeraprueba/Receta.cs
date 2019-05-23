using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
namespace primeraprueba
{
    public class Receta
    {
        #region Propiedades
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string pasos;
        public string Pasos
        {
            get { return pasos; }
            set { pasos = value; }
        }

        private List<string> ingredientes;
        public List<string> Indredientes
        {
            get { return ingredientes; }
            set { ingredientes = value; }
        }

        private Image foto;
        public Image Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        private List<string> tags;
        public List<string> Tags
        {
            get { return tags; }
            set { tags = value; }
        }

        private int idReceta;
        public int IdReceta
        {
            get { return idReceta; }
            set { idReceta = value; }
        }

        private int idUsuario;
        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value;}
        }
        #endregion
        
        public Receta()
        {
        }

        public Receta(List<object> listaReceta)
        {
            idReceta = (int)listaReceta[0];
            IdUsuario = (int)listaReceta[1];
            nombre = (string)listaReceta[2];
            pasos = (string)listaReceta[3];
            ingredientes = Buscador.ObtenerIngredientes((string)listaReceta[4]);
            foto = ConexionBBDD.FromByteToImage((byte[])listaReceta[5]);
            tags = Buscador.ObtenerTags((string)listaReceta[6]);
        }

        //Obtiene una lista de los retos del usuario seleccionado
        public static List<Receta> GetRecetas(int user)
        {
            ConexionBBDD.Instanciar().AbrirConexion();

            List<Receta> List_Receta = new List<Receta>();
            string consulta = string.Format("select * from recetas where ID_Usuario_P={0}", user);
            List<List<object>> lista = ConexionBBDD.Instanciar().Query(consulta);

            ConexionBBDD.Instanciar().CerrarConexion();
           
            if (lista == null) return null;

            foreach (List<object> l1 in lista)
                List_Receta.Add(new Receta(l1));

            return List_Receta;
        }

        public static List<Receta> GetRecetas()
        {
            ConexionBBDD.Instanciar().AbrirConexion();

            List<Receta> List_Receta = new List<Receta>();
            string consulta = string.Format("select * from recetas");
            List<List<object>> lista = ConexionBBDD.Instanciar().Query(consulta);

            ConexionBBDD.Instanciar().CerrarConexion();

            if (lista == null) return null;

            foreach (List<object> l1 in lista)
                List_Receta.Add(new Receta(l1));

            return List_Receta;
        }


        public static bool CrearReceta(Receta recet)
        {
            string consulta = string.Format(
                "insert into recetas values (null,{0},'{1}','{2}','{3}', @foto,'{4}')", 
                recet.IdUsuario, recet.Nombre, recet.pasos, Buscador.ObtenerIngredientes(recet.ingredientes), Buscador.ObtenerTags(recet.tags)
            );

            ConexionBBDD.Instanciar().AbrirConexion();
            bool result = ConexionBBDD.Instanciar().NonQuery(consulta, recet.foto);
            ConexionBBDD.Instanciar().CerrarConexion();

            if (result) return true;
            else return false;

        }

        public static bool BorrarReceta(int id)
        {
            string consulta = string.Format("Delete from recetas where ID_Receta={0}", id);

            ConexionBBDD.Instanciar().AbrirConexion();
            bool result = ConexionBBDD.Instanciar().NonQuery(consulta);
            ConexionBBDD.Instanciar().CerrarConexion();

            if (result) return true;
            else return false;

        }

        public static Receta GetReceta(int id)
        {
            ConexionBBDD.Instanciar().AbrirConexion();
            
            string consulta = string.Format("select * from recetas where ID_Receta={0}", id);
            List<List<object>> lista = ConexionBBDD.Instanciar().Query(consulta);
            
            ConexionBBDD.Instanciar().CerrarConexion();
            
            if (lista == null) return null;
            return new Receta(lista[0]);

        }
    }
}
