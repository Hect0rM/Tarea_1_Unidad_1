namespace Tarea1.tarea
{
    public class Tarea26
    {
        public void tarea26()
        {
            int i;
            int[] numeros = new int[20];
            int[] frecuencias = new int[11];

            Random rand = new Random();

            for (i = 0; i < 20; i++)
            {
                numeros[i] = rand.Next(1, 11);
            }

            Console.Write("Numeros generados: ");
            for (i = 0; i < 20; i++)
            {
                Console.Write(numeros[i] + " ");
            }
            Console.WriteLine("\n");

            for (i = 0; i < 20; i++)
            {
                int valor = numeros[i];
                frecuencias[valor] = frecuencias[valor] + 1;
            }

            Console.WriteLine("Frecuencia de cada numero:");
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("Numero " + i + ": se repite " + frecuencias[i] + " veces");
            }

            int maxFrecuencia = frecuencias[1];
            int minFrecuencia = frecuencias[1];
            int masFrecuente = 1;
            int menosFrecuente = 1;

            for (i = 2; i <= 10; i++)
            {
                if (frecuencias[i] > maxFrecuencia)
                {
                    maxFrecuencia = frecuencias[i];
                    masFrecuente = i;
                }
                if (frecuencias[i] < minFrecuencia)
                {
                    minFrecuencia = frecuencias[i];
                    menosFrecuente = i;
                }
            }

            Console.WriteLine("\nEl numero mas frecuente es el " + masFrecuente + " (se repite " + maxFrecuencia + " veces)");
            Console.WriteLine("El numero menos frecuente es el " + menosFrecuente + " (se repite " + minFrecuencia + " veces)");
        }
    }
}
