
namespace menormayorpara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double i,mayor,menor,numero;
            int acu;
            acu = 0;
            mayor = 0;
            menor = 99999999999999;
            for (i=1;i<=30;i++)
            {
                acu = acu + 1;
                Console.WriteLine("Ingrese el numero " + acu + " de 30: ");
                numero = Convert.ToDouble(Console.ReadLine());
                if (numero<=menor)
                {
                    menor = numero;
                }
                else if (numero>=mayor)
                {
                    mayor = numero;
                }
            }
            Console.WriteLine("El numero mayor es: " + mayor);
            Console.WriteLine("El numero menor es: " + menor);
        }
    }
}
