using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace primeraprueba
{
    class ConexionBBDD
    {
        private MySqlConnection conexion;
        private static ConexionBBDD instancia = null;
        public MySqlConnection Conexion { get { return conexion; } }


        //Constructor de la clase que nos permitira conectarnos a la base de datos remota cuando tenga las variable rellenadas 
        private ConexionBBDD()
        {
            string host = "18.191.242.134";
            string puerto = "3306";
            string BaseDatos = "pirojo";
            string usuario = "root";
            string password = "PI,rojo123";
            string connectionstring = host + puerto + BaseDatos + usuario + password;

            conexion = new MySqlConnection(connectionstring);

        }

        public static ConexionBBDD Instanciar()
        {
            if (instancia == null) instancia = new ConexionBBDD();
            return instancia;
        }
        public void AbrirConexion()
        {
            try
            {
                conexion.Open();

            }
            catch (MySqlException ex)  // Inicialmente no es necesario utilizar el objeto ex
            {
                


            }
        }

        public void CerrarConexion()
        {
            try
            {
                conexion.Close();

            }
            catch (MySqlException ex) 
            {
                


            }
        }
    }
}
