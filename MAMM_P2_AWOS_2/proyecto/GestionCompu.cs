using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace MAMM_P2_AWOS_2.proyecto
{
    public class GestionCompu
    {

        public static string altaCompu(Computadora g)// alta de computadoras(todas)
        {
            string c = "error";

            try
            {
                string sql = string.Format("insert into pc " +
                    "values (null,'{0}','{1}','{2}','{3}','{4}','{5}','{6}')", g.id_otro, g.marca, g.modelo, g.tamano, g.memoriaRAM, g.memoriaROM, g.SO, g.procesador);

                MySqlCommand cmd = new MySqlCommand(sql, Conexion.probarConexion());

                cmd.ExecuteNonQuery();
                c = "compu registrada";
                Conexion.cerrarConexion();
            }
            catch (System.Data.SqlClient.SqlException exsql)
            {
                c = exsql.ToString();

            }
            catch (Exception ex)
            {
                c = ex.ToString();
            }

            return c;
        }
        public static string Alta(Computadora g)//procedimiento almacenado
        {
            string str = "error";
            try
            {
                MySqlCommand com = new MySqlCommand();
                com.Connection = Conexion.probarConexion();
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "alta_marca";//nombre del procedimiento almacenado
                com.Parameters.Add("@marca", MySqlDbType.VarChar).Value = g.marca;
                com.Parameters.Add("@modelo", MySqlDbType.VarChar).Value = g.modelo;
                com.ExecuteNonQuery();
                str = "alta marca";

                Conexion.cerrarConexion();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                str = ex.ToString();
            }
            catch (Exception ex)
            {
                str = ex.ToString();
            }
            return str;
        }
        public static DataTable consulta()//martes, raspberry
        {
            DataTable dt;
            MySqlDataAdapter da;
            string sql = "select * from pc ";
            MySqlCommand cmd = new MySqlCommand(sql, Conexion.probarConexion());
            dt = new DataTable();
            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            Conexion.cerrarConexion();
            return dt;
        }

        public static List<Computadora> consulta2()
        {
            List<Computadora> compu = new List<Computadora>();
            string sql = "select * from pc";

            MySqlCommand cmd = new MySqlCommand(sql, Conexion.probarConexion());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                compu.Add(new Computadora
                {
                    id_otro = reader.GetString(0),
                    marca = reader.GetString(1),
                    modelo = reader.GetString(2),
                    tamano = reader.GetString(3),
                    memoriaRAM = reader.GetString(4),
                    memoriaROM = reader.GetString(5),
                    SO = reader.GetString(6),
                    procesador = reader.GetString(7)
                });
            Conexion.cerrarConexion();
            return compu;


        }

        public static Computadora buscar(string id_otro)
        {
            Computadora computadora;
            String sql = String.Format("select * from pc where id={0}", id_otro);
            MySqlCommand cmd = new MySqlCommand(sql, Conexion.probarConexion());
            //MySqlDataReader reader = cmd.ExecuteReader();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
                computadora = new Computadora
                {
                    id_otro = reader.GetString(0),
                    marca = reader.GetString(1),
                    modelo = reader.GetString(2),
                    tamano = reader.GetString(3),
                    memoriaRAM = reader.GetString(4),
                    memoriaROM = reader.GetString(5),
                    SO = reader.GetString(6),
                    procesador = reader.GetString(7)
                };
            else
                computadora = null;
            Conexion.cerrarConexion();
            return computadora;
        }
        public static void bajaCompu(string id_otro)
        {
            String sql = String.Format("delete from pc where id_otro={0}", id_otro);
            MySqlCommand cmd = new MySqlCommand(sql, Conexion.probarConexion());
            cmd.ExecuteNonQuery();
            Conexion.cerrarConexion();
        }
    }//clase

}//nombre