using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MAMM_P2_AWOS_2.proyecto
{
    public partial class ejemplo3 : System.Web.UI.Page
    {
        string Html = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Computadora> g = GestionCompu.consulta2();
            Html += "<section class='contenido'>";
            foreach (Computadora c in g)
            {
                Html += "<div class='div'>";
                Html += "<h2 class='h2'>" + c.id_otro + "</h2>";
                Html += "<ul>";
                Html += "<li>" + c.marca + "</h2>";
                Html += "<li>" + c.modelo + "</h2>";
                Html += "<li>" + c.tamano + "</h2>";
                Html += "<li>" + c.memoriaRAM + "</h2>";
                Html += "<li>" + c.memoriaROM + "</h2>";
                Html += "<li>" + c.SO + "</h2>";
                Html += "<li>" + c.procesador + "</h2>";
                Html += "</ul>";
                Html += "</div>";
            }//for
            Html += "</section>";
            Literal1.Text = Html;
        }

        protected void Agrega_Click(object sender, EventArgs e)
        {

        }

        protected void Elimina_Click(object sender, EventArgs e)
        {

        }

        protected void Busca_Click(object sender, EventArgs e)
        {

        }
    }
}