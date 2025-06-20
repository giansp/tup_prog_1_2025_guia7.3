namespace Encuesta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int positivos, negativos, indecisos, total, voto;
            double porcentajePositivos, porcentajeNegativos, porcentajeIndecisos;
            bool continuar = true;
            positivos = 0;
            negativos = 0;
            indecisos = 0;
            total = 0;
            Console.WriteLine("Encuesta de opinion");
            Console.WriteLine("0:Positivo   |   1:Negativo  |   2:Indeciso  |   -1: Terminar encuesta");
            while (continuar == true)
            {
                Console.WriteLine("Ingrese su voto: ");
                voto = Convert.ToInt32(Console.ReadLine());
                switch (voto)
                {
                    case 0:
                        positivos++;
                        total++;
                        break;
                    case 1:
                        negativos++;
                        total++;
                        break;
                    case 2:
                        indecisos++;
                        total++;
                        break;
                    case -1:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        continue;
                }
            }
            if (total > 0)
            {
                porcentajePositivos = (positivos * 100.00) / total;
                porcentajeNegativos = (negativos * 100.00) / total;
                porcentajeIndecisos = (indecisos * 100.00) / total;
                Console.WriteLine("Resultados de la encuesta:");
                Console.WriteLine($"Positivos: {porcentajePositivos:F2}% con {positivos} votos positivos");
                Console.WriteLine($"Negativos: {porcentajeNegativos:F2}% con {negativos} votos negativos");
                Console.WriteLine($"Indecisos: {porcentajeIndecisos:F2}% con {indecisos} votos indecisos");
            }
            else
            {
                Console.WriteLine("No se registraron votos.");
            }
        }
    }
}
