namespace Tarea1.tarea
{
    public class Tarea23
    {
        public void tarea23()
        {
            int i;
            
            Console.Write("Ingrese la cantidad de calificaciones: \n");
            int n = int.Parse(Console.ReadLine()!);

            double[] notas = new double[n];

            for (i = 0; i < n; i++)
            {
                Console.Write("Ingrese la calificacion " + (i + 1) + ": ");
                notas[i] = double.Parse(Console.ReadLine()!);
            }

            double suma = 0;
            for (i = 0; i < n; i++)
            {
                suma = suma + notas[i];
            }
            double promedio = suma / n;

            double maxima = notas[0];
            double minima = notas[0];

            for (i = 1; i < n; i++)
            {
                if (notas[i] > maxima)
                {
                    maxima = notas[i];
                }
                if (notas[i] < minima)
                {
                    minima = notas[i];
                }
            }

            int aprobados = 0;
            int reprobados = 0;

            for (i = 0; i < n; i++)
            {
                if (notas[i] >= 60)
                {
                    aprobados = aprobados + 1;
                }
                else
                {
                    reprobados = reprobados + 1;
                }
            }

            double sumaDiferencias = 0;
            for (i = 0; i < n; i++)
            {
                double diferencia = notas[i] - promedio;
                sumaDiferencias = sumaDiferencias + (diferencia * diferencia);
            }
            double varianza = sumaDiferencias / n;
            double desviacion = Math.Sqrt(varianza);

            Console.WriteLine("\n--- ESTADISTICAS ---");
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Calificacion maxima: " + maxima);
            Console.WriteLine("Calificacion minima: " + minima);
            Console.WriteLine("Cantidad de aprobados: " + aprobados);
            Console.WriteLine("Cantidad de reprobados: " + reprobados);
            Console.WriteLine("Desviacion estandar: " + desviacion);
        }
    }
}
