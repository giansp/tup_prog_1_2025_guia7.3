using System;

namespace ListadoAlumnos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantAlumnos = 0, numLibreta = 0, numLibretaMayor = 0, numLibretaMenor = 0, i = 0;
            double nota = 0, notaMayor = 0, notaMenor = 99;
            string nombre = "", nombreMayor = "", nombreMenor = "";
            bool continuar = true;

            Console.WriteLine("Ingrese la cantidad de alumnos:");
            cantAlumnos = Convert.ToInt32(Console.ReadLine());

            while (continuar==true)
            {
                for (i = 0; i <= cantAlumnos; i++)
                {
                    Console.WriteLine("Ingrese el nombre del alumno:");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el número de libreta del alumno:");
                    numLibreta = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese la nota del alumno:");
                    nota = Convert.ToDouble(Console.ReadLine());
                    if (nota<notaMenor)
                    {
                        notaMenor = nota;
                        nombreMenor = nombre;
                        numLibretaMenor = numLibreta;
                    }
                    if (nota>notaMayor)
                    {
                        notaMayor = nota;
                        nombreMayor = nombre;
                        numLibretaMayor = numLibreta;
                    }
                    Console.WriteLine("¿Desea continuar ingresando alumnos? (s/n):");
                    string respuesta = Console.ReadLine().ToLower();
                    if (respuesta != "s")
                    {
                        continuar = false;
                        break;
                    }
                }
            }
            Console.WriteLine("El alumno con la nota mayor es: " + nombreMayor + " con la libreta número " + numLibretaMayor + " y una nota de " + notaMayor);
            Console.WriteLine("El alumno con la nota menor es: " + nombreMenor + " con la libreta número " + numLibretaMenor + " y una nota de " + notaMenor);
        }
    }
}
