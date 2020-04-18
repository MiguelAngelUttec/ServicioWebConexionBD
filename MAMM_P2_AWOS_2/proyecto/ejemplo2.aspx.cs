using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace MAMM_P2_AWOS_2.proyecto
{
    public partial class ejemplo2 : System.Web.UI.Page
    {
        string html = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (GestionCompu.consulta().Rows.Count > 0)
            {
                html += "<table>";
                html += "<thead><tr><td>marca</td><td>modelo</td><td>tamano</td>";
                html += "<tbody>";

                foreach (DataRow dbRow in GestionCompu.consulta().Rows)
                {
                    html += "<form action= 'toma.aspx' method ='post'>";
                    html += "<tr>";
                    html += "<td>" + dbRow["marca"].ToString();
                    html += "<input type='hidden' name='id_otro' value='" + dbRow["id_otro"].ToString() + "'>" + "</td>";
                    html += "<td>" + dbRow["modelo"].ToString() + "</td>";
                    html += "<td>" + dbRow["tamano"].ToString() + "</td>";
                    html += "<td><input class='btn' type='submit' value='Buscar'/></td>";
                    html += "</tr>";
                }//for
                html += "</tbody>";
                html += "</table>";


            }
            else
            {
                html += "<table>";
                html += "<tr><td><marquee>no hay registros</marquee></td></tr>";
                html += "</table>";
            }//else
            Literal1.Text = html;
        }
        