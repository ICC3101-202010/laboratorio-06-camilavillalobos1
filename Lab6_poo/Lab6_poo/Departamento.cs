using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Lab6_poo
{
    [Serializable]
    public class Departamento
    {
        public string Nombre_Departamento;
        public Persona Encargado_Depto;
        public List<Seccion> secciones = new List<Seccion>();

        public Departamento(string nombre, Persona encargado)
        {
            Nombre_Departamento = nombre;
            Encargado_Depto = encargado;
            
        }
        public void Informacion()
        {
            string datos = "";

            datos += "Seccion: ";

            int i = 1;
            foreach (var item in secciones)
            {
                Console.WriteLine("1. " + secciones[i - 1]);
                datos += Console.ReadLine();
                i++;
            }
          

        }

    }
}
