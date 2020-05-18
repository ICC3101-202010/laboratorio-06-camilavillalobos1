using System;
using System.Collections.Generic;
namespace Lab6_poo
{
    public class Area
    {
        public string Nombre_Area;
        public Persona Encargado_Area;
        public List<Departamento> departamento = new List<Departamento>();

        public Area(string nombre, Persona encargado)
        {
            Nombre_Area = nombre;
            Encargado_Area = encargado;
           
        }
        public string Informacion()
        {
            string datos = "";

            datos += "Departamento: ";

            int i = 1;
            foreach (var item in departamento)
            {
                Console.WriteLine("1. " + departamento[i - 1]);
                i++;
            }
            return datos;

        }

    }
}
