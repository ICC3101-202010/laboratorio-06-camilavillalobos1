using System;
using System.Collections.Generic;
namespace Lab6_poo
{
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

    }
}
