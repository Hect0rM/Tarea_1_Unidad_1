namespace Tarea1.tarea
{
    public class Tarea25
    {
        public void tarea25()
        {
            int i;

            Console.Write("Ingrese la cantidad de elementos (N): \n");
            int n = int.Parse(Console.ReadLine()!);

            int[] arreglo = new int[n];

            for (i = 0; i < n; i++)
            {
                Console.Write("Ingrese el elemento " + (i + 1) + ": ");
                arreglo[i] = int.Parse(Console.ReadLine()!);
            }

            Console.Write("\n1-- Rotar K posiciones a la izquierda\n");
            Console.Write("2-- Rotar K posiciones a la derecha\n");
            Console.Write("3-- Invertir el arreglo\n");
            int caso = int.Parse(Console.ReadLine()!);

            switch (caso)
            {
                case 1:
                    Console.Write("Ingrese la cantidad de posiciones a rotar (K): \n");
                    int kIzq = int.Parse(Console.ReadLine()!);
                    
                    kIzq = kIzq % n; 

                    int[] auxIzq = new int[n];
                    for (i = 0; i < n; i++)
                    {
                        int nuevaPosicion = (i - kIzq + n) % n;
                        auxIzq[nuevaPosicion] = arreglo[i];
                    }
                    arreglo = auxIzq;
                    break;

                case 2:
                    Console.Write("Ingrese la cantidad de posiciones a rotar (K): \n");
                    int kDer = int.Parse(Console.ReadLine()!);
                    
                    kDer = kDer % n; 

                    int[] auxDer = new int[n];
                    for (i = 0; i < n; i++)
                    {
                        int nuevaPosicion = (i + kDer) % n;
                        auxDer[nuevaPosicion] = arreglo[i];
                    }
                    arreglo = auxDer;
                    break;

                case 3:
                    for (i = 0; i < n / 2; i++)
                    {
                        int temporal = arreglo[i];
                        arreglo[i] = arreglo[n - 1 - i];
                        arreglo[n - 1 - i] = temporal;
                    }
                    break;

                default:
                    Console.WriteLine("Opcion invalida.");
                    break;
            }

            Console.Write("\nArreglo resultante: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arreglo[i] + " ");
            }
            Console.WriteLine();
        }
    }
}