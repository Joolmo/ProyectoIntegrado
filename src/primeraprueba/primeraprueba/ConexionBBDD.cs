using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using Dispenser;
using System.Security.Cryptography;
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
            string connectionstring = string.Format("Server={0}; Port={1}; Database={2}; Uid={3}; Pwd={4};",
                host, puerto, BaseDatos, usuario, password);

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

        /// <summary>
        /// La función consulta devuelve el resultado de una consulta SQL SELECT
        /// </summary> 
        /// <param name="consulta">La consulta a realizar</param>
        /// <returns>
        ///     Si no hay ninguna coincidencia devulece un list vacio.
        ///     Si todo funciona bien devuelve un list de filas, que contiene un list de columnas.
        ///     Si falla devulve null y añade el error a LastError
        /// </returns>
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

        /// <summary>
        /// La funcion realiza INSERTS, UPDATES y cualquier tipo de modificación que no sea un SELECT
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns>
        ///     Devuelve true si se ha ejecutado correctamente y false si no,
        ///     en el caso de haber algun error lo pushea a LastError
        /// </returns>
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

        /// <summary>
        /// Funcion para hacer inserts, deltes y ipdates que tengan alguna foto
        /// </summary>
        /// <param name="consulta">String dondese guarda la consulta MySql</param>
        /// <param name="picture">La imagen que queremos guardar en la base de datos</param>
        /// <returns></returns>
        public bool NonQuery(string consulta, Image picture)
        {

            try
            {
                byte[] pic = FormImageToByte(picture);
                using (var cmd = new MySqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@foto", pic);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                errores.Push(ex.Message);
                return false;
            }
        }

        public static byte[] FormImageToByte(Image foto)
        {
            byte[] byteArr = new byte[0];
            using (MemoryStream stream = new MemoryStream())
            {
                foto.Save(stream, ImageFormat.Png);
                stream.Close();

                byteArr = stream.ToArray();
            }
            return byteArr;

        }

        //La encriptacion de la contraseña, puede que no este completa
        public static string EncriptarContraseña(string password)
        {
            using (var sha256 = SHA256.Create())
            { 
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password)); 
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
    }
}
