namespace Tarea1.tarea
{
    public class Tarea22
    {
        public void tarea22()
        {
            double resultado = 0;
            bool primerCalculo = true;
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\n--- MENU CALCULADORA ---");
                if (!primerCalculo)
                {
                    Console.WriteLine($"Resultado actual: {resultado}");
                }
                Console.WriteLine("1-- Suma");
                Console.WriteLine("2-- Resta");
                Console.WriteLine("3-- Multiplicacion");
                Console.WriteLine("4-- Division");
                Console.WriteLine("5-- Potencia");
                Console.WriteLine("6-- Raiz Cuadrada");
                Console.WriteLine("7-- Porcentaje");
                Console.WriteLine("8-- Limpiar resultado (Reset)");
                Console.WriteLine("9-- Salir");
                Console.Write("Elija una opcion: ");

                int opcion = int.Parse(Console.ReadLine()!);

                if (opcion == 9)
                {
                    continuar = false;
                    Console.WriteLine("Saliendo de la calculadora...");
                    break;
                }

                if (opcion == 8)
                {
                    resultado = 0;
                    primerCalculo = true;
                    Console.WriteLine("Resultado reiniciado a 0.");
                    continue;
                }

                double num1 = 0;
                double num2 = 0;

                if (primerCalculo)
                {
                    if (opcion >= 1 && opcion <= 7)
                    {
                        Console.Write("Ingrese el primer numero: ");
                        num1 = double.Parse(Console.ReadLine()!);
                        primerCalculo = false;
                    }
                }
                else
                {
                    num1 = resultado;
                }

                if (opcion >= 1 && opcion <= 5)
                {
                    Console.Write("Ingrese el siguiente numero: ");
                    num2 = double.Parse(Console.ReadLine()!);
                }
                else if (opcion == 7)
                {
                    Console.Write("Ingrese el porcentaje a calcular (ej: 15 para 15%): ");
                    num2 = double.Parse(Console.ReadLine()!);
                }

                switch (opcion)
                {
                    case 1:
                        resultado = num1 + num2;
                        break;
                    case 2:
                        resultado = num1 - num2;
                        break;
                    case 3:
                        resultado = num1 * num2;
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Error: No se puede dividir entre cero.");
                        }
                        break;
                    case 5:
                        resultado = Math.Pow(num1, num2);
                        break;
                    case 6:
                        if (num1 >= 0)
                        {
                            resultado = Math.Sqrt(num1);
                        }
                        else
                        {
                            Console.WriteLine("Error: No existe raiz cuadrada de un numero negativo.");
                        }
                        break;
                    case 7:
                        resultado = (num1 * num2) / 100;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                }

                Console.WriteLine($"Resultado de la operacion: {resultado}");
            }
        }
    }
}