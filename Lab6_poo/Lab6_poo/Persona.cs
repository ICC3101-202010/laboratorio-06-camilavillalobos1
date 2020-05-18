using System;
using System.Collections.Generic;
namespace Lab6_poo
{
    public class Persona
    {
        private string Nombre;
        private string Apellido;
        private string Rut;
        private string Cargo;
        public List<Persona> personal = new List<Persona>();


        public Persona(string nombre, string apellido, string rut, string cargo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Rut = rut;
            Cargo = cargo;

        }

    }
}
