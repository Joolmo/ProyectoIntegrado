using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
namespace primeraprueba
{
    class Receta
    {
        #region Propieda
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

        //Obtiene una lista de los retos del usuario seleccionado
        static List<Receta> GetReceta(int user)
        {
            List<Receta> List_Receta = new List<Receta>();

            string consulta = string.Format("select * from recetas where ID_Usuario_P={0}", user);
            List<List<object>> lista = ConexionBBDD.Instanciar().Query(consulta);
            foreach (List<object> l1 in lista)
            {
                Receta r = new Receta();
                r.IdUsuario = (int) l1[1];
                r.Nombre = (string) l1[2];
                r.Pasos = (string) l1[3];
                r.Indredientes = (List<string>)l1[4];
                r.Foto =(Image) l1[5];
                r.Tags = (List<string>)l1[6];
                List_Receta.Add(r);
            }
            return List_Receta;
        }


        public static bool CrearReceta(Receta recet)
        {
            byte[] buffer = ConexionBBDD.Instanciar().FormImageToByte(recet.foto);

            string consulta = string.Format("insert into recetas values(null,'{0}','{1}','{2}',{3},'{4}')", 
                recet.IdUsuario, recet.Nombre, recet.pasos, buffer, recet.Tags);
            if (ConexionBBDD.Instanciar().NonQuery(consulta))
            {
                return true;
            }
            else
            {
                string error = ConexionBBDD.Instanciar().LastError;
                return false;
            }

        }

        public static bool BorrarReceta(int id)
        {
            string consulta = string.Format("Delete from recetas where ID_Receta={0}", id);

            if (ConexionBBDD.Instanciar().NonQuery(consulta))
            {
                return true;
            }
            else
            {
                string error = ConexionBBDD.Instanciar().LastError;
                return false;
            }

        }
    }
}
