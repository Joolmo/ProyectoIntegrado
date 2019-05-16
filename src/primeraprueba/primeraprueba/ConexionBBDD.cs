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
        #region atributos
        private static ConexionBBDD instancia = null;
        private MySqlConnection conexion;
        private Stack<string> errores = new Stack<string>();
        #endregion

        #region propiedades
        /// <summary>
        /// Esta propiedad devolvera un string con el ultimo error,
        /// al devolvero lo eliminara y no se podra recuperar.
        /// </summary>
        public string LastError
        {
            get
            {
                if (errores.Count == 0)
                    return "Sin errrores";
                else
                    return errores.Pop();
            }
        }
        #endregion

        private ConexionBBDD()
        {
            //Configuración de la base de datos hardcodeada
            string host = "18.191.242.134";
            string puerto = "3306";
            string BaseDatos = "pirojo";
            string usuario = "rojo";
            string password = "PI,rojo123";
            string connectionstring = host + puerto + BaseDatos + usuario + password;

            conexion = new MySqlConnection(connectionstring);

        }
        
        /// <summary>
        /// Metodo instanciador de clase siguiendo el patrion singleton
        /// </summary>
        /// <returns>Devuelve la unica instancia de la clase</returns>
        public static ConexionBBDD Instanciar()
        {
            if (instancia == null)
                instancia = new ConexionBBDD();
            return instancia;
        }

        public bool AbrirConexion()
        {
            try
            {
                if(!IsConnected())
                    conexion.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                errores.Push(ex.Message);
                return false;
            }
        }

        public void CerrarConexion()
        {
            try
            {
                conexion.Close();
            }
            catch (MySqlException) {}
        }

        public bool IsConnected()
        {
            return (conexion.State.ToString() == "Open");
        }

        public List<List<object>> Query(string consulta)
        {
            try
            {
                List<List<object>> final = new List<List<object>>();

                using (var cmd = new MySqlCommand(consulta, conexion))
                {
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        List<object> list = new List<object>();

                        for (int i = 0; i < reader.FieldCount; i++)
                            list.Add(reader[i]);

                        final.Add(list);
                    }
                }

                return final;
            }
            catch(MySqlException ex)
            {
                errores.Push(ex.Message);
                return null;
            }
        }

        public bool NonQuery(string consulta)
        {
            try
            {
                using (var cmd = new MySqlCommand(consulta, conexion))
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch(MySqlException ex)
            {
                errores.Push(ex.Message);
                return false;
            }
        }
    }
}
