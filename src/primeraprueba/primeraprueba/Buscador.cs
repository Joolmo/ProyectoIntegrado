using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeraprueba
{
    static class Buscador
    {
        public static List<Receta> BuscarRecetas(string nombre, List<string> tags = null)
        {
            int nletras = nombre.Length;
            Receta rec;
            List<Receta> List_Receta = new List<Receta>();
            for (int i = 0; i < nletras; i++)
            {
                string consulta = string.Format("SELECT * FROM recetas WHERE Nombre_Receta like '{0}%';", nombre);
                List<List<object>> lista = ConexionBBDD.Instanciar().Query(consulta);
                if (lista.Count > 0)
                {
                    foreach (List<object> l1 in lista)
                    {
                        rec = new Receta(l1);
                        List_Receta.Add(rec);
                    }
                    break;
                }
                else
                {
                    nombre = nombre.Substring(0, nombre.Length - 2);
                }

            }
            return List_Receta;
        }

        public static List<Usuario> BuscarUsuarios(string nombre)
        {
            int nletras = nombre.Length;
            Usuario u;
            List<Usuario> List_Usuario = new List<Usuario>();
            for (int i=0; i<nletras; i++)
            {
                string consulta = string.Format("SELECT * FROM usuario WHERE Nombre_Usuario like '{0}%';", nombre);
                List<List<object>> lista = ConexionBBDD.Instanciar().Query(consulta);
                if (lista.Count > 0)
                {
                    foreach (List<object> l1 in lista)
                    {
                        u = new Usuario(l1);
                        List_Usuario.Add(u);
                    }
                    break;
                }
                else
                {
                    nombre = nombre.Substring(0, nombre.Length - 2);
                }
                
            }
            return List_Usuario;
        }

		public static List<string> ObtenerTags(string t) 
		{
            t += " ";
            List<string> resultado = new List<string>();
			string palabra = "";
			bool interruptor = false;
			foreach (var ch in t)
			{
				if (ch == ' ')
				{
					interruptor = false;
					if (palabra != "")
					{
						resultado.Add(palabra);
						palabra = "";
					}
				}
				if (interruptor) palabra += ch;
				if (ch == '#') interruptor = true;
			}
			return resultado;
		}

		public static List<string> ObtenerIngredientes(string t)
		{
            t += " ";
			List<string> resultado = new List<string>();
			string palabra = "";
			bool interruptor = false;
			foreach (var ch in t)
			{
				if (ch == ' ')
				{
					interruptor = false;
					if (palabra != "")
					{
						resultado.Add(palabra);
						palabra = "";
					}
				}
				if (interruptor) palabra += ch;
				if (ch == '@') interruptor = true;
			}
			return resultado;
		}

        public static string ObtenerTags(List<string> list)
        {
            string total = "";
            foreach (var st in list)
                total += "#" + st + " ";

            return total;
        }

        public static string ObtenerIngredientes(List<string> list)
        {
            string total = "";
            foreach (var st in list)
                total += "@" + st + " ";

            return total;
        }
	}
}
