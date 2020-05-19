using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Lab6_poo
{
    [Serializable]
    public class Seccion
    {
        public string Nombre_Seccion;
        public Persona Encargado_Seccion;
        public List<Bloque> bloques = new List<Bloque>();

        public Seccion(string nombre, Persona encargado)
        {
            Nombre_Seccion = nombre;
            Encargado_Seccion = encargado;

        }
        public void Informacion()
        {
            string datos = "";

            datos += "Bloques: ";

            int i = 1;
            foreach (var item in bloques)
            {
                Console.WriteLine("1. " + bloques[i - 1]);
                datos += Console.ReadLine();
                i++;
            }
           

        }

    }

}
