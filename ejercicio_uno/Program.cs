namespace Promedio20Num
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double i,acu,num,promedio;
            promedio = 0;
            acu = 0;
            i = 1;
            for (i=1; i<=20;i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                num = Convert.ToDouble(Console.ReadLine());
                acu = acu + num;
                promedio=acu /i;
                Console.WriteLine("El promedio para " + i + " numeros es: " + promedio);
            }
            Console.WriteLine($"El promedio total es: {promedio}");
        }
    }
}
