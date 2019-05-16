﻿using System;
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
        public string Descripcion { get { return descripcion; }  set { descripcion = value; } }
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

        //Obtiene una lista de los retos del usuario seleccionado
        static List<Reto> GetReto(int user)
        {
            List<Reto> List_Reto = new List<Reto>();
            
            string consulta = string.Format("select * from retos where ID_Usuario_P={0}", user);
            List<List<object>> lista = ConexionBBDD.Query(consulta);
            foreach (List<object> l1 in lista)
            {
                    Reto r = new Reto(l1[1], l1[2],l1[3],l1[4],l1[5]);
                    List_Reto.Add(r);
            }
            return List_Reto;
        }
           

        public static bool CrearReto(Reto ret)
        {
            
            string consulta = string.Format("insert into reto values({0},{1},{2},{3},{4})",
                ret.id_usuario, ret.nombre, ret.descripcion, ret.fecha_inicial, ret.fecha_final);
            if (ConexionBBDD.NonQuery(consulta)) 
            {
                return true;
            }
            else
            {
                string error = ConexionBBDD.LastError;
                return false;
            }

        }

        public static bool BorrarReto(int id)
        {
            string consulta = string.Format("Delete from reto where ID_Reto={0}", id);
            
            if (ConexionBBDD.NonQuery(consulta)) 
            {
                return true;
            }
            else
            {
                string error = ConexionBBDD.LastError;
                return false;
            }

        }





    }
}
