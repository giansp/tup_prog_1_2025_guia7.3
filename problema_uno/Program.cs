namespace Apuestas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double apuesta, apuestaMenor, apuestaMayor;
            string nombreApuesta, nombreApuestaMenor, nombreApuestaMayor;
            bool stop = false;
            apuestaMayor = 0;
            apuestaMenor= 9999999999999999;
            nombreApuestaMayor = "nn";
            nombreApuestaMenor = "nn";

            while (stop==false)
            {
                Console.WriteLine("Ingrese el nombre del apostador:");
                nombreApuesta = Console.ReadLine();
                Console.WriteLine("Ingrese el monto de la apuesta:");
                apuesta = Convert.ToDouble(Console.ReadLine());
                if (apuesta < 0)
                {
                    Console.WriteLine("El monto de la apuesta no puede ser negativo. Intente nuevamente.");
                    continue;
                }
                if (apuesta == 0)
                {
                    Console.WriteLine("El monto de la apuesta no puede ser cero. Intente nuevamente.");
                    continue;
                }
                if (apuesta<apuestaMenor)
                    {
                    apuestaMenor = apuesta;
                    nombreApuestaMenor = nombreApuesta;
                }
                else
                {
                     if (apuesta>apuestaMayor)
                    {
                         apuestaMayor = apuesta;
                        nombreApuestaMayor = nombreApuesta;
                    }
                }
                Console.WriteLine("¿Desea continuar? (s/n):");
                string respuesta = Console.ReadLine().ToLower();
                if (respuesta!="s")
                {
                    stop = true;
                    break;
                }
            }
            Console.WriteLine("Apuesta menor: " + apuestaMenor + " por " + nombreApuestaMenor);
            Console.WriteLine("Apuesta mayor: " + apuestaMayor + " por " + nombreApuestaMayor);
        }
    }
}
