using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Lab6_poo
{
    [Serializable]
    public class Bloque
    {
        public List<Persona> Personal = new List<Persona>();
        public List<Bloque> bloques = new List<Bloque>();
        public string Nombre_Bloque;
        public Persona Encargado_Bloque;

        public Bloque(string nombre_bloque, Persona encargado)
        {
            Nombre_Bloque = nombre_bloque;
            Encargado_Bloque = encargado;
  
        }

        public void Informacion()
        {
            string datos = "";

            datos += "Personal: ";

            int i = 1;
            foreach (var item in Personal)
            {
                Console.WriteLine("1. " + Personal[i - 1]);
                datos += Console.ReadLine();
                i++;
            }


        }

    }
}
