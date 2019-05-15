using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeraprueba
{
    class Reto
    {
        private string nombre;
        private DateTime fecha_inicial;
        private DateTime fecha_final;
        private int idreto;
        private string descripcion;
   
        public string Nombre { get { return nombre; } }
        public DateTime Fecha_Inicial { get { return fecha_inicial; } }
        public DateTime Fecha_Final { get { return fecha_final; } }
        public int IdReto { get { return idreto; } }
        public string Descripcion { get { return descripcion; }  set { descripcion = value; } }

        public Reto(string nom, DateTime fecha_i, DateTime fecha_f, string desc)
        {
            nombre = nom;
            fecha_inicial = fecha_i;
            fecha_final = fecha_f;
            descripcion = desc;
        }

        public Reto()
        {
           
        }
        //Funcionalidad para crear el reto
        public void CrearReto()
        {



        }

        //Obtiene una lista de los retos del usuario seleccionado
        static List<Reto> GetReto(int usuari)
        {



        }


        //En el caso de que se quiera borrar un reto
        public void BorrarReto()
        {


        }





    }
}
