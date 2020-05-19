using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Lab6_poo
{
    [Serializable]
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
