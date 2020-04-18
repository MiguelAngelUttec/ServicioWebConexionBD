using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MySql.Data.MySqlClient;

namespace MAMM_P2_AWOS_2.proyecto
{
    public class Conexion
    {
        static MySqlConnection con;
        public static MySqlConnection probarConexion()
        {
            // MySqlConnection con;
            String servidor = "localhost";
            String puerto = "3306";
            String usuario = "root";
            String password = "";
            String database = "mibasededatos";

            String cadenaConexion = String.Format("server={0};" + "port={1};" + "user={2};" + "password={3};" + "database={4}", servidor, puerto, usuario, password, database);

            con = new MySqlConnection(cadenaConexion);
            con.Open();//se abre la conexion
            if (con.State == System.Data.ConnectionState.Open)
            {
                return con;

            }
            else
            {
                return null;
            }
        }
        public static void cerrarConexion()
        {
            con.Close();
        }



    }//clase    
}//nom