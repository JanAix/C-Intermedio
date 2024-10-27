using System;

namespace Practica_SRP
{
    public class Persona
    {
        private string nombre { get; set; }
        private int edad { get; set; }
        private string direccion { get; set; }
        private string correoElectronico { get; set; }


        public void ImprimirDatos()
        {

            Console.WriteLine($"Nombre : { nombre}");
            Console.WriteLine($"Edad :  { edad}");
            Console.WriteLine($"Direccion :  {direccion}");
            Console.WriteLine($"Correo Electronico : {correoElectronico}");

        }

    }
}