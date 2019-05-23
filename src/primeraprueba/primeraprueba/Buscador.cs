﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeraprueba
{
    static class Buscador
    {
        public static List<Receta> BuscarRecetas(string busqueda)
        {
            List<Receta> listReceta = new List<Receta>();
            ConexionBBDD.Instanciar().AbrirConexion();

            string nombre = GetNombre(busqueda);
            int nletras = nombre.Length;

            for (int i = 0; i < nletras; i++)
            {
                string consulta = string.Format("SELECT * FROM recetas WHERE Nombre_Receta like '{0}%';", nombre);
                List<List<object>> lista = ConexionBBDD.Instanciar().Query(consulta);

                if (lista.Count > 0)
                {
                    foreach (List<object> l1 in lista)
                        listReceta.Add(new Receta(l1));
                    break;
                }
                else nombre = nombre.Substring(0, nombre.Length - 2);
            }

            ConexionBBDD.Instanciar().CerrarConexion();

            if (listReceta.Count == 0)
                listReceta = Receta.GetRecetas();

            List<string> ingredientes = ObtenerIngredientes(busqueda);
            List<string> tags = ObtenerTags(busqueda);
            List<Receta> tmp = new List<Receta>();

            foreach (var ing in ingredientes)
                tmp.AddRange(listReceta.Where((Receta rec) => rec.Indredientes.Find(x => x == ing).ToList().Count > 0));

            foreach (var t in tags)
                tmp.AddRange(listReceta.Where((Receta rec) => rec.Tags.Find(x => x == t).ToList().Count > 0));

            if (tmp.Count > 0)
                listReceta = tmp;

            return listReceta;
        }

        public static string GetNombre(string busqueda)
        {
            string nombre = "";

            foreach(var ch in busqueda)
            {
                if (ch == '#' || ch == '@')
                    break;
                if (ch != ' ')
                    nombre += ch;
            }

            return nombre;
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
