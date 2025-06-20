namespace PromedioMientras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num, promedio=0, acu, i;
            bool bandera=true;
            string respuesta;
            i = 0;
            acu = 0;

            while (bandera==true)
            {
                i++;
                Console.WriteLine($"Ingrese el número {i}: ");
                num= Convert.ToDouble(Console.ReadLine());
                acu=acu+num;
                promedio=acu/i;
                Console.WriteLine($"Promedio para {i} números: {promedio}");
                Console.WriteLine("Ingresar otro numero? (Y/N): ");
                respuesta = Convert.ToString(Console.ReadLine()).ToUpper();
                if (respuesta== "N")
                {
                    bandera = false;
                    Console.WriteLine("Fin del programa.");
                }
                else if (respuesta !="Y")
                {
                    break;
                }
            }
            Console.WriteLine($"El promedio final es : {promedio}");
        }
    }
}
