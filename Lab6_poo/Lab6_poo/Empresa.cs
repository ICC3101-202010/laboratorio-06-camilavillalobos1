using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Lab6_poo
{
    [Serializable]
    public class Empresa
    {
        public string Nombre;
        public string Rut;
        public List<Empresa> empresa = new List<Empresa>();
        public List<Division> division = new List<Division>();

        public Empresa(string nombre, string rut)
        {
            Nombre = nombre;
            Rut = rut;
        }

        public string Informacion()
        {
            string datos = "Nombre empresa: " + Nombre + "\nRUT: "+ Rut ;

            datos += "\nDivision: ";

            int i = 1;
            foreach (var item in division)
            {
                Console.WriteLine("1. " + division[i-1]);
                datos += Console.ReadLine();
                i++;
            }
            return datos;

        }

    }
}
