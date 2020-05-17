using System;
namespace Lab6_poo
{
    public class Personal
    {
        private string Nombre;
        private string Apellido;
        private string Rut;
        private string Cargo;


        public Personal(string nombre, string apellido, string rut, string cargo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Rut = rut;
            Cargo = cargo;
        }
    }
}
