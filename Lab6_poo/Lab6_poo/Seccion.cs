using System;
using System.Collections.Generic;
namespace Lab6_poo
{
    public class Seccion
    {
        private string Nombre_Seccion;
        public Persona Encargado_Seccion;
        public List<Bloque> bloques = new List<Bloque>();

        public Seccion(string nombre, Persona encargado)
        {
            Nombre_Seccion = nombre;
            Encargado_Seccion = encargado;

        }
        public string Informacion()
        {
            string datos = "";

            datos += "Bloques: ";

            int i = 1;
            foreach (var item in bloques)
            {
                Console.WriteLine("1. " + bloques[i - 1]);
                i++;
            }
            return datos;

        }

    }

}
