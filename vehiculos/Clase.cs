using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace vehiculos
{
    internal class Clase : Carro
    {
        public int puertas;
        public int suspencion;
        public string trasmision;
        public string traccion;
        public string sistemadefrenos;

        public Clase(string combustible, int ruedas, string color, int precio, int modelo, string uso, int capacidad, string marca, string carroceria, int cilindraje, string motor, string accesorios, int puertas, int suspencion, string trasmision, string traccion, string sistemadefrenos) : base(combustible, ruedas, color, precio, modelo, uso, capacidad, marca, cilindraje, carroceria, motor, accesorios, puertas, suspencion, trasmision, traccion, sistemadefrenos)

        {   

            this.puertas = puertas;
            this.suspencion = suspencion;
            this.trasmision = trasmision;
            this.traccion = traccion;
            this.sistemadefrenos = sistemadefrenos;
        }

        public int getPuertas() { return puertas; }
        public int getSuspencion() { return suspencion; }
        public string getTrasmision() { return trasmision; }
        public string getTraccion() { return traccion; }
        public string getSistemadefrenos() { return sistemadefrenos; }


    }

}


