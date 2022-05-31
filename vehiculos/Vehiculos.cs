using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace vehiculos
{
    internal class Vehiculos

    {
        public string combustible;
        public int ruedas;
        public string color;
        public int precio;
        public int modelo;
        public string uso;
        public int capacidad;
        public string marca;


        public Vehiculos(string combustible, int ruedas, string color, int precio, int modelo, string uso, int capacidad, string marca, int cilindraje, string carroceria, string motor, string accesorios)

        {
            this.combustible = combustible;
            this.ruedas = ruedas;
            this.color = color;
            this.precio = precio;
            this.modelo = modelo;
            this.uso = uso;
            this.capacidad = capacidad;
            this.marca = marca;

        }

        public Vehiculos(string combustible, int ruedas, string color, int precio, int modelo, string uso, int capacidad, string marca, int cilindraje, string carroceria, string motor, string accesorios, int puertas, int suspencion, string trasmision, string traccion, string sistemadefrenos) : this(combustible, ruedas, color, precio, modelo, uso, capacidad, marca, cilindraje, carroceria, motor, accesorios)
        {
        }

        public string getcombustible() { return combustible; }
        public int getruedas() { return ruedas; }

        public string getcolor() { return color; }
        public int getprecio() { return precio; }
        public int getmodelo() { return modelo; }
        public string getuso() { return uso; }
        public int getcapacidad() { return capacidad; }

        public string getmarca() { return marca; }

    }
}



