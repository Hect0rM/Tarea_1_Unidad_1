//en esta me costo toco buscar ayuda externa para resolver

namespace Tarea1.tarea
{
    public class Tarea28
    {
        public void tarea28()
        {
            int i;
            int j;

            Console.Write("Ingrese la cantidad de estudiantes (N): \n");
            int n = int.Parse(Console.ReadLine()!);

            double[,] matrizNotas = new double[n, 3];
            double[] promedioEstudiantes = new double[n];
            double[] promedioParciales = new double[3];

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("\n--- Notas del Estudiante " + (i + 1) + " ---");
                for (j = 0; j < 3; j++)
                {
                    Console.Write("Ingrese la nota del Parcial " + (j + 1) + ": ");
                    matrizNotas[i, j] = double.Parse(Console.ReadLine()!);
                }
            }

            for (i = 0; i < n; i++)
            {
                double sumaEstudiante = 0;
                for (j = 0; j < 3; j++)
                {
                    sumaEstudiante = sumaEstudiante + matrizNotas[i, j];
                }
                promedioEstudiantes[i] = sumaEstudiante / 3;
            }

            for (j = 0; j < 3; j++)
            {
                double sumaParcial = 0;
                for (i = 0; i < n; i++)
                {
                    sumaParcial = sumaParcial + matrizNotas[i, j];
                }
                promedioParciales[j] = sumaParcial / n;
            }

            double mejorPromedio = promedioEstudiantes[0];
            int posicionMejorEstudiante = 0;

            for (i = 1; i < n; i++)
            {
                if (promedioEstudiantes[i] > mejorPromedio)
                {
                    mejorPromedio = promedioEstudiantes[i];
                    posicionMejorEstudiante = i;
                }
            }

            double peorPromedioParcial = promedioParciales[0];
            int parcialMasDificil = 0;

            for (j = 1; j < 3; j++)
            {
                if (promedioParciales[j] < peorPromedioParcial)
                {
                    peorPromedioParcial = promedioParciales[j];
                    parcialMasDificil = j;
                }
            }

            Console.WriteLine("\n=== RESULTADOS FINALES ===");
            
            Console.WriteLine("\nPromedio de cada estudiante:");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Estudiante " + (i + 1) + ": " + promedioEstudiantes[i]);
            }

            Console.WriteLine("\nPromedio de cada parcial:");
            for (j = 0; j < 3; j++)
            {
                Console.WriteLine("Parcial " + (j + 1) + ": " + promedioParciales[j]);
            }

            Console.WriteLine("\nEl estudiante con mejor promedio es el Estudiante " + (posicionMejorEstudiante + 1) + " con " + mejorPromedio);
            Console.WriteLine("El parcial mas dificil fue el Parcial " + (parcialMasDificil + 1) + " con promedio de " + peorPromedioParcial);
        }
    }
}