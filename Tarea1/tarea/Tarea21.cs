using System;

namespace Tarea1.tarea
{
    public class Tarea21
    {
        public void tarea21()
        {
            int i;
            Console.Write("1-- Triagulo\n");
            Console.Write("2-- Triagulo Invertido\n");
            Console.Write("3-- Rombo\n");
            Console.Write("4-- Cuadrado Hueco\n");

            int caso = int.Parse(Console.ReadLine()!);

            Console.Write("Ingrese dimencion: \n");
            int dim = int.Parse(Console.ReadLine()!);

            switch (caso)
            {
                case 1:
                    for (i = 1; i <= dim; i++)
                    {
                        for (int j = 1; j <= dim - i; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 1; j <= (2 * i) - 1; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 2:
                    for (i = dim; i >= 1; i--)
                    {
                        for (int j = 1; j <= dim - i; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 1; j <= (2 * i) - 1; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 3:
                    for (i = 1; i <= dim; i++)
                    {
                        for (int j = 1; j <= dim - i; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 1; j <= (2 * i) - 1; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    for (i = dim - 1; i >= 1; i--)
                    {
                        for (int j = 1; j <= dim - i; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 1; j <= (2 * i) - 1; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 4:
                    for (i = 1; i <= dim; i++)
                    {
                        for (int j = 1; j <= dim; j++)
                        {
                            if (i == 1 || i == dim || j == 1 || j == dim)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        Console.WriteLine();
                    }
                    break;

                default:
                    Console.WriteLine("Opcion invalida.");
                    break;
            }
        }
    }
}
