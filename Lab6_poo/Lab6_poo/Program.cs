using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab6_poo
{
    class MainClass
    {
        
        public static void Main(string[] args)

        {
            
            Persona persona1 = new Persona("Camila", "Villalobos", "123", "Jefe");
            Persona persona3 = new Persona("nombre3", "apellido3", "634", "Empleado");
            Empresa empresa1 = new Empresa("Empresa1", "1");
            Division division1 = new Division("division1", new Persona("Camilo", "Henriquez", "345", "Encargado"));
            Area area1 = new Area("Area1", new Persona("Vicente", "Lira", "465", "Encargado"));
            Departamento depto1 = new Departamento("Depto1", new Persona("Javiera", "Henriquez", "384", "Encargado"));
            Seccion seccion1 = new Seccion("Seccion1", new Persona("Patricio", "Villalobos", "984", "Encargado"));
            Bloque bloque1 = new Bloque("bloque1", new Persona("nombre1", "apellido1", "674", "Empleado"));
            Bloque bloque2 = new Bloque("bloque2", new Persona("nombre2", "apellido2", "774", "Empleado"));
            bloque1.Personal.Add(persona1);
            bloque2.Personal.Add(persona3);
            seccion1.bloques.Add(bloque1);
            seccion1.bloques.Add(bloque2);
            depto1.secciones.Add(seccion1);
            area1.departamento.Add(depto1);
            division1.area.Add(area1);
            empresa1.division.Add(division1);
            List<Empresa> empresa = new List<Empresa>();
            empresa.Add(empresa1);

            Console.WriteLine("1. Entrar \n2. Salir");
            int respuesta = Convert.ToInt32(Console.ReadLine());

            while (respuesta == 1)
            {
                Console.WriteLine("1. Crear empresa \n2. Subir empresa \n3. Mostrar empresas \n4. Guardar informacion \n0. Salir");
                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {
                    Crear_archivo(empresa);
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("Ingrese nombre del archivo: ");
                    string fileName = Console.ReadLine();

                    try
                    {
                        Console.WriteLine("Abriendo archivo");
                        IFormatter formatter = new BinaryFormatter();
                        Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                        List<Empresa> empresas = (List<Empresa>)formatter.Deserialize(stream);
                        Console.WriteLine("Cerrando archivo. Se abrio correctamente");
                        stream.Close();
                    }
                    catch (FileNotFoundException e)
                    {
                        Console.WriteLine("No pudimos abrir el archivo");
                        Console.WriteLine(e.Message);
                        Crear_archivo(empresa);

                    }

                }
                else if (opcion == 3)
                {
                    foreach(var item in empresa)

                    Console.WriteLine(item.Informacion());

                }
                else if (opcion == 4)
                {
                    IFormatter formatter = new BinaryFormatter();
                    Stream stream = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                    formatter.Serialize(stream, empresa);
                    stream.Close();
                }
                else if (opcion == 0)
                {
                    break;
                }
            }
            

        }
        public static void Crear_archivo(List<Empresa> empresa)
        {
            Console.WriteLine("Ingrese nombre de la empresa: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese RUT de la empresa: ");
            string rut = Console.ReadLine();
            empresa.Add(new Empresa(nombre, rut));
            Division division1 = new Division("division1", new Persona("Camilo", "Henriquez", "345", "Encargado"));
            Area area1 = new Area("Area1", new Persona("Vicente", "Lira", "465", "Encargado"));
            Departamento depto1 = new Departamento("Depto1", new Persona("Javiera", "Henriquez", "384", "Encargado"));
            Seccion seccion1 = new Seccion("Seccion1", new Persona("Patricio", "Villalobos", "984", "Encargado"));
            Bloque bloque1 = new Bloque("bloque1", new Persona("nombre1", "apellido1", "674", "Encargado1"));
            Bloque bloque2 = new Bloque("bloque2", new Persona("nombre2", "apellido2", "774", "Encargado2"));
            seccion1.bloques.Add(bloque1);
            seccion1.bloques.Add(bloque2);
            depto1.secciones.Add(seccion1);
            area1.departamento.Add(depto1);
            division1.area.Add(area1);

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, empresa);
            stream.Close();
        }

        public static void Informacion(object o)
        {
            
        }

    }
}
