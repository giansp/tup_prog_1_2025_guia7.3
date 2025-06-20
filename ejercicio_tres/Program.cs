using System.ComponentModel.Design;

namespace menormayor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double menor,mayor,numero;
            bool bandera = true;
            string respuesta;
            menor=1000000;
            mayor=0;

            while (bandera==true)
            {
                Console.WriteLine("Ingrese un numero");
                numero = Convert.ToDouble(Console.ReadLine());
                if (numero>=0 && numero<=100)
                {
                    if (numero < menor)
                    {
                        menor = numero;
                        if (numero > mayor)
                        {
                            mayor = numero;
                        }
                    }
                    else if (numero > mayor)
                    {
                         mayor = numero;
                    }
                }
                else
                {
                    Console.WriteLine("El numero ingresado no es valido, debe estar entre 0 y 100");
                }
                Console.WriteLine("Desea ingresar otro numero? (Y/N)");
                respuesta = Console.ReadLine().ToUpper();
                if (respuesta== "Y")
                {
                    bandera = true;
                }
                else if (respuesta != "Y")
                {
                    bandera = false;
                }
            }
            Console.WriteLine("El menor numero ingresado es: " + menor);
            Console.WriteLine("El mayor numero ingresado es: " + mayor);
        }
    }
}
