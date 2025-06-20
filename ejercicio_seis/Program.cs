

using System.Globalization;

namespace VentasRubro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rubro, cantidad,monto, numventa;
            int numventaMax, totalProductos;
            int contRubro1, contRubro2, contRubro3, contRubro4, contRubro5;
            double maxMonto,recaudacionTotal;
            bool continuar = true;
            maxMonto = 0;
            recaudacionTotal = 0;
            contRubro1 = 0;
            contRubro2 = 0;
            contRubro3 = 0;
            contRubro4 = 0;
            contRubro5 = 0;
            totalProductos = 0;
            numventa = 0;
            numventaMax = 0;

            Console.WriteLine("SISTEMA DE VENTAS RUBRO");
            Console.WriteLine("==========================");
            Console.WriteLine("Ingrese los datos de cada venta");
            Console.WriteLine("Ingrese 0 en el rubro para terminar");

            while (continuar==true)
            {
                Console.WriteLine($"Venta N° {numventa+1}");
                Console.Write("Ingrese el rubro (1-5): ");
                rubro = Convert.ToInt32(Console.ReadLine());
                if (rubro == 0)
                {
                    continuar=false;
                    Console.WriteLine("Fin de las ventas.");
                    break;
                }
                else if (rubro>=1 && rubro<=5)
                {
                    numventa = numventa + 1;
                    Console.WriteLine("Cantidad de productos vendidos");
                    cantidad= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Monto total");
                    monto= Convert.ToInt32(Console.ReadLine());

                    switch(rubro)
                    {
                        case 1:
                            contRubro1++;
                            break;
                        case 2:
                            contRubro2++;
                            break;
                        case 3:
                            contRubro3++;
                            break;
                        case 4:
                            contRubro4++;
                            break;
                        case 5:
                            contRubro5++;
                            break;
                    }

                    totalProductos = totalProductos + cantidad;
                    recaudacionTotal = recaudacionTotal + monto;

                    if (monto > maxMonto)
                    {
                        maxMonto = monto;
                        numventaMax = numventa;
                    }
                }
                else
                    Console.WriteLine("Rubro incorrecto");
                numventa = numventa;

            }
            if (totalProductos> 0)
            {
                Console.WriteLine("Porcentajes por rubro en cantidad");
                Console.WriteLine($"Rubro 1: {(contRubro1 * 100.0 / totalProductos):F2}%");
                Console.WriteLine($"Rubro 2: {(contRubro2 * 100.0 / totalProductos):F2}%");
                Console.WriteLine($"Rubro 3: {(contRubro3 * 100.0 / totalProductos):F2}%");
                Console.WriteLine($"Rubro 4: {(contRubro4 * 100.0 / totalProductos):F2}%");
                Console.WriteLine($"Rubro 5: {(contRubro5 * 100.0 / totalProductos):F2}%");
                Console.WriteLine("==================================");
                Console.WriteLine("Venta con mayor monto");
                Console.WriteLine($"Numero de venta: {numventaMax}");
                Console.WriteLine($"Monto: {maxMonto}");
                Console.WriteLine("Recaudación total:");
                Console.WriteLine($"Total recaudado {recaudacionTotal}");
            }
            else
                Console.WriteLine("No se ingresaron ventas validas");
        }
    }
}
