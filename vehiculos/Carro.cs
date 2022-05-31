using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace vehiculos
{
    internal class Carro:Vehiculos
    {
        public string carroceria;
        public int cilindraje;
        public string motor;
        public string accesorios;

        public Carro(string combustible, int ruedas, string color, int precio, int modelo, string uso, int capacidad, string marca, int cilindraje, string carroceria, string motor, string accesorios) :base(combustible,ruedas,color,precio,modelo,uso,capacidad,marca,cilindraje,carroceria,motor,accesorios)

        {

            this.carroceria = carroceria;
            this.cilindraje = cilindraje;
            this.motor = motor;
            this.accesorios = accesorios;

        }

        public Carro(string combustible, int ruedas, string color, int precio, int modelo, string uso, int capacidad, string marca, int cilindraje, string carroceria, string motor, string accesorios, int puertas, int suspencion, string trasmision, string traccion, string sistemadefrenos) : base(combustible, ruedas, color, precio, modelo, uso, capacidad, marca, cilindraje, carroceria, motor, accesorios, puertas, suspencion, trasmision, traccion, sistemadefrenos)
        {
        }

        public int getCilindraje() { return cilindraje; }
        public string getcarroceria() { return carroceria; }
        public string getmotor() { return motor; }
        public string getaccesorios() { return accesorios; }


    }

}


