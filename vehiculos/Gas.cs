using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace vehiculos
{
    internal class Gas : Motor
    {
        public int pipeta;

        public Gas(string combustible, int ruedas, string color, int precio, int modelo, string uso, int capacidad, string marca, string carroceria, int cilindraje, string motor, string accesorios, int puertas, int suspencion, string trasmision, string traccion, string sistemadefrenos) : base(combustible, ruedas, color, precio, modelo, uso, capacidad, marca, cilindraje, carroceria, motor, accesorios, puertas, suspencion, trasmision, traccion, sistemadefrenos)
        {
        }

        public int getPipeta() { return pipeta; }


    }

}




