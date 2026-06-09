namespace Tarea1.tarea
{
    public class Tarea27
    {
        public void tarea27()
        {
            int i;
            double[] temperaturas = new double[7];
            string[] dias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

            for (i = 0; i < 7; i++)
            {
                Console.Write("Ingrese la temperatura del " + dias[i] + ": ");
                temperaturas[i] = double.Parse(Console.ReadLine()!);
            }

            double suma = 0;
            for (i = 0; i < 7; i++)
            {
                suma = suma + temperaturas[i];
            }
            double promedio = suma / 7;

            double masCaluroso = temperaturas[0];
            double masFrio = temperaturas[0];
            string diaCaluroso = dias[0];
            string diaFrio = dias[0];

            for (i = 1; i < 7; i++)
            {
                if (temperaturas[i] > masCaluroso)
                {
                    masCaluroso = temperaturas[i];
                    diaCaluroso = dias[i];
                }
                if (temperaturas[i] < masFrio)
                {
                    masFrio = temperaturas[i];
                    diaFrio = dias[i];
                }
            }

            Console.WriteLine("\n--- RESULTADOS ---");
            Console.WriteLine("Promedio semanal: " + promedio);
            Console.WriteLine("Dia mas caluroso: " + diaCaluroso + " (" + masCaluroso + ")");
            Console.WriteLine("Dia mas frio: " + diaFrio + " (" + masFrio + ")");

            Console.WriteLine("\nDias con temperatura sobre el promedio:");
            for (i = 0; i < 7; i++)
            {
                if (temperaturas[i] > promedio)
                {
                    Console.WriteLine("- " + dias[i] + " (" + temperaturas[i] + ")");
                }
            }

            Console.WriteLine("\nVariacion entre dias consecutivos:");
            for (i = 0; i < 6; i++)
            {
                double variacion = temperaturas[i + 1] - temperaturas[i];
                Console.WriteLine(dias[i] + " a " + dias[i + 1] + ": " + variacion);
            }
        }
    }
}