namespace Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int igrupo, ivalor, grupoMenor, grupoMayor;
            double val,prom,menprom,mayprom,promGrupo;

            mayprom = -1;
            menprom=9999999;
            grupoMayor = 0;
            grupoMenor = 0;

            for (igrupo=1;igrupo<=4;igrupo++)
            {
                prom=0;
                Console.WriteLine($"Grupo " + igrupo);
                for (ivalor=1;ivalor<=6;ivalor++)
                {
                   Console.WriteLine($"Ingrese valor: "+ ivalor);
                    val = Convert.ToDouble(Console.ReadLine());
                    prom=prom + val;
                }
                promGrupo = prom / 6;
                Console.WriteLine($"El promedio del grupo " + igrupo + " es: " + promGrupo);
                if (promGrupo > mayprom)
                {
                    mayprom = promGrupo;
                    grupoMayor = igrupo;
                }
                if (promGrupo < menprom)
                {
                    menprom = promGrupo;
                    grupoMenor = igrupo;
                }
            }
            Console.WriteLine($"El grupo con mayor promedio es el grupo " + grupoMayor + " con un promedio de: " + mayprom);
            Console.WriteLine($"El grupo con menor promedio es el grupo " + grupoMenor + " con un promedio de: " + menprom);
        }
    }
}
