//en esta me costo toco buscar ayuda externa para resolver

namespace Tarea1.tarea
{
    public class Tarea30
    {
        public void tarea30()
        {
            int i;

            string[] nombres = new string[5];
            double[,] matrizDatos = new double[5, 3];

            nombres[0] = "Manzana";
            matrizDatos[0, 0] = 101;
            matrizDatos[0, 1] = 50;
            matrizDatos[0, 2] = 0.50;

            nombres[1] = "Leche";
            matrizDatos[1, 0] = 102;
            matrizDatos[1, 1] = 20;
            matrizDatos[1, 2] = 1.20;

            nombres[2] = "Pan";
            matrizDatos[2, 0] = 103;
            matrizDatos[2, 1] = 30;
            matrizDatos[2, 2] = 0.80;

            nombres[3] = "Arroz";
            matrizDatos[3, 0] = 104;
            matrizDatos[3, 1] = 15;
            matrizDatos[3, 2] = 1.50;

            nombres[4] = "Huevo";
            matrizDatos[4, 0] = 105;
            matrizDatos[4, 1] = 100;
            matrizDatos[4, 2] = 0.15;

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\n--- MENU INVENTARIO ---");
                Console.WriteLine("1-- Mostrar Inventario");
                Console.WriteLine("2-- Buscar Producto por Codigo");
                Console.WriteLine("3-- Actualizar Cantidad");
                Console.WriteLine("4-- Calcular Valor Total");
                Console.WriteLine("5-- Salir");
                Console.Write("Elija una opcion: ");

                int opcion = int.Parse(Console.ReadLine()!);

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\n=== LISTA DE PRODUCTOS ===");
                        for (i = 0; i < 5; i++)
                        {
                            Console.WriteLine("Codigo: " + matrizDatos[i, 0] + " | Nombre: " + nombres[i] + " | Cantidad: " + matrizDatos[i, 1] + " | Precio: $" + matrizDatos[i, 2]);
                        }
                        break;

                    case 2:
                        Console.Write("\nIngrese el codigo del producto a buscar: ");
                        double codigoBuscar = double.Parse(Console.ReadLine()!);
                        int indiceEncontrado = -1;

                        for (i = 0; i < 5; i++)
                        {
                            if (matrizDatos[i, 0] == codigoBuscar)
                            {
                                indiceEncontrado = i;
                                break;
                            }
                        }

                        if (indiceEncontrado != -1)
                        {
                            Console.WriteLine("Producto Encontrado: " + nombres[indiceEncontrado] + " | Cantidad: " + matrizDatos[indiceEncontrado, 1] + " | Precio: $" + matrizDatos[indiceEncontrado, 2]);
                        }
                        else
                        {
                            Console.WriteLine("Producto no encontrado.");
                        }
                        break;

                    case 3:
                        Console.Write("\nIngrese el codigo del producto a actualizar: ");
                        double codigoActualizar = double.Parse(Console.ReadLine()!);
                        int indiceActualizar = -1;

                        for (i = 0; i < 5; i++)
                        {
                            if (matrizDatos[i, 0] == codigoActualizar)
                            {
                                indiceActualizar = i;
                                break;
                            }
                        }

                        if (indiceActualizar != -1)
                        {
                            Console.Write("Ingrese la nueva cantidad para " + nombres[indiceActualizar] + ": ");
                            matrizDatos[indiceActualizar, 1] = double.Parse(Console.ReadLine()!);
                            Console.WriteLine("Cantidad actualizada con exito.");
                        }
                        else
                        {
                            Console.WriteLine("Producto no encontrado.");
                        }
                        break;

                    case 4:
                        double valorTotal = 0;
                        for (i = 0; i < 5; i++)
                        {
                            double cantidad = matrizDatos[i, 1];
                            double precio = matrizDatos[i, 2];
                            valorTotal = valorTotal + (cantidad * precio);
                        }
                        Console.WriteLine("\nEl valor total del inventario es: $" + valorTotal);
                        break;

                    case 5:
                        continuar = false;
                        Console.WriteLine("Saliendo del inventario...");
                        break;

                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                }
            }
        }
    }
}

