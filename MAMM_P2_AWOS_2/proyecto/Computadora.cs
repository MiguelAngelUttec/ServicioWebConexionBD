using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAMM_P2_AWOS_2.proyecto
{
    public class Computadora
    {
        public string id_otro { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string tamano { get; set; }
        public string memoriaRAM { get; set; }
        public string memoriaROM { get; set; }

        public string SO { get; set; }
        public string procesador { get; set; }


        public Computadora()
        {

        }

        public Computadora(string id_otro, string marca, string modelo, string tamano, string memoriaRAM, string memoriaROM, string SO, string procesador)
        {
            this.id_otro = id_otro;
            this.marca = marca;
            this.modelo = modelo;
            this.tamano = tamano;
            this.memoriaROM = memoriaROM;
            this.memoriaROM = memoriaROM;
            this.SO = SO;
            this.procesador = procesador;

        }


    }
}