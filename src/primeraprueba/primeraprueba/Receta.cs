using System;
using System.Collections.Generic;
using System.Drawing;

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
        #endregion

        public static List<Receta> GetRecetasUsuario(int usario)
        {
            throw new NotImplementedException();
        }


    }
}
