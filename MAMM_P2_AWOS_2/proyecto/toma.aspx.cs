using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MAMM_P2_AWOS_2.proyecto
{
    public partial class toma : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id_otro = "";
            if (!string.IsNullOrEmpty(Request.Form["id_otro"]))
            {
                id_otro = Request.Form["id_otro"];
                this.txtid.Text = id_otro;//caja de texto
            }
            // string id_otro = Request.Form["id_otro"];
            txtid.Text = id_otro;
            Computadora compu = GestionCompu.buscar(id_otro);
            if (compu != null)
            {
                txtid.Text = compu.id_otro;
                marca.Text = compu.marca;
                modelo.Text = compu.modelo;
                tamano.Text = compu.tamano;
                memoriaRAM.Text = compu.memoriaRAM;
                memoriaROM.Text = compu.memoriaROM;
                SO.Text = compu.SO;
                procesador.Text = compu.procesador;
            }
            else
            {
                marca.Text = "";
                modelo.Text = "";
                tamano.Text = "";
                memoriaRAM.Text = "";
                memoriaROM.Text = "";
                SO.Text = "";
                procesador.Text = "";

            }

        }
        protected void alta1_Click(object sender, EventArgs e)// insertar computadoras
        {
            Computadora g = new Computadora();
            g.marca = marca.Text;
            g.modelo = modelo.Text;
            g.tamano = tamano.Text;
            g.memoriaRAM = memoriaRAM.Text;
            g.memoriaROM = memoriaROM.Text;
            g.SO = SO.Text;
            g.procesador = procesador.Text;
            string c = GestionCompu.altaCompu(g);
            Response.Write("<script>alert('" + c + "');</script>");


        }

        protected void Unnamed1_Click(object sender, EventArgs e)//probar conexion
        {
            if (Conexion.probarConexion() != null)
            {
                Response.Write("si me pude conectar");
            }
            else
            {
                Response.Write("no me pude conectar");
            }
        }

        protected void boton2_Click(object sender, EventArgs e)//procedimiento almacenado
        {
            Computadora g = new Computadora();
            g.marca = marca.Text;
            g.modelo = modelo.Text;
            g.tamano = tamano.Text;
            g.memoriaRAM = memoriaRAM.Text;
            g.memoriaROM = memoriaROM.Text;
            g.SO = SO.Text;
            g.procesador = procesador.Text;
            string str = GestionCompu.Alta(g);
            Response.Write("<script>alert('" + str + "');</script>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GestionCompu.bajaCompu(txtid.Text);
            Response.Redirect("ejemplo.aspx");
        }
    }
}