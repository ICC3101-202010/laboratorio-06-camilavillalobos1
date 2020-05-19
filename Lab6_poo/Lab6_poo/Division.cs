using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Lab6_poo
{
    [Serializable]
    public class Division
    {
        public string Nombre_Division;
        public Persona Encargado_Division;
        public List<Area> area = new List<Area>();
        

        public Division(string nombre, Persona encargado)
        {
            Nombre_Division = nombre;
            Encargado_Division= encargado;
            
        }
        public void Informacion()
        {
            string datos = "";

            datos += "Area: ";

            int i = 1;
            foreach (var item in area)
            {
                Console.WriteLine("1. " + area[i - 1]);
                datos += Console.ReadLine();
                i++;
            }
           

        }

    }
}
