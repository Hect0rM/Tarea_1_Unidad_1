namespace Tarea1.tarea
{
    public class Tarea24
    {
        public void tarea24()
        {
            int i;
            int[] numeros = new int[10];

            for (i = 0; i < 10; i++)
            {
                Console.Write("Ingrese el numero " + (i + 1) + ": ");
                numeros[i] = int.Parse(Console.ReadLine()!);
            }

            Console.Write("\nIngrese el numero que desea buscar (Busqueda Lineal): ");
            int numeroBuscar = int.Parse(Console.ReadLine()!);
            int posicionEncontrada = -1;

            for (i = 0; i < 10; i++)
            {
                if (numeros[i] == numeroBuscar)
                {
                    posicionEncontrada = i;
                    break;
                }
            }

            int maximo = numeros[0];
            for (i = 1; i < 10; i++)
            {
                if (numeros[i] > maximo)
                {
                    maximo = numeros[i];
                }
            }

            int segundoMaximo = int.MinValue;
            for (i = 0; i < 10; i++)
            {
                if (numeros[i] > segundoMaximo && numeros[i] < maximo)
                {
                    segundoMaximo = numeros[i];
                }
            }

            for (i = 0; i < 10 - 1; i++)
            {
                for (int j = 0; j < 10 - i - 1; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        int temporal = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = temporal;
                    }
                }
            }

            Console.WriteLine("\n--- RESULTADOS ---");
            if (posicionEncontrada != -1)
            {
                Console.WriteLine("Numero encontrado en la posicion (indice): " + posicionEncontrada);
            }
            else
            {
                Console.WriteLine("El numero no existe en el arreglo.");
            }

            if (segundoMaximo != int.MinValue)
            {
                Console.WriteLine("El segundo numero mayor es: " + segundoMaximo);
            }
            else
            {
                Console.WriteLine("No se pudo determinar el segundo mayor (todos los numeros son iguales).");
            }

            Console.Write("Arreglo ordenado (Burbuja): ");
            for (i = 0; i < 10; i++)
            {
                Console.Write(numeros[i] + " ");
            }
            Console.WriteLine();

            Console.Write("Elementos en las posiciones (indices) pares: ");
            for (i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(numeros[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
