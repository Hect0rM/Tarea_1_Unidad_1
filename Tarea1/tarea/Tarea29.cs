//en esta me costo toco buscar ayuda externa para resolver

namespace Tarea1.tarea
{
    public class Tarea29
    {
        public void tarea29()
        {
            int i;
            int j;
            bool jugarDeNuevo = true;

            while (jugarDeNuevo)
            {
                char[,] tablero = new char[3, 3];
                
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        tablero[i, j] = ' ';
                    }
                }

                char jugadorActual = 'X';
                bool juegoTerminado = false;
                int movimientos = 0;

                while (juegoTerminado == false)
                {
                    Console.WriteLine("\n=== TABLERO ===");
                    for (i = 0; i < 3; i++)
                    {
                        Console.WriteLine(" " + tablero[i, 0] + " | " + tablero[i, 1] + " | " + tablero[i, 2]);
                        if (i < 2)
                        {
                            Console.WriteLine("-----------");
                        }
                    }

                    Console.WriteLine("\nTurno del Jugador " + jugadorActual);
                    Console.Write("Ingrese la fila (1-3): ");
                    int fila = int.Parse(Console.ReadLine()!) - 1;

                    Console.Write("Ingrese la columna (1-3): ");
                    int columna = int.Parse(Console.ReadLine()!) - 1;

                    if (fila >= 0 && fila < 3 && columna >= 0 && columna < 3 && tablero[fila, columna] == ' ')
                    {
                        tablero[fila, columna] = jugadorActual;
                        movimientos = movimientos + 1;

                        bool hayGanador = false;

                        for (i = 0; i < 3; i++)
                        {
                            if (tablero[i, 0] == jugadorActual && tablero[i, 1] == jugadorActual && tablero[i, 2] == jugadorActual)
                            {
                                hayGanador = true;
                            }
                            if (tablero[0, i] == jugadorActual && tablero[1, i] == jugadorActual && tablero[2, i] == jugadorActual)
                            {
                                hayGanador = true;
                            }
                        }

                        if (tablero[0, 0] == jugadorActual && tablero[1, 1] == jugadorActual && tablero[2, 2] == jugadorActual)
                        {
                            hayGanador = true;
                        }
                        if (tablero[0, 2] == jugadorActual && tablero[1, 1] == jugadorActual && tablero[2, 0] == jugadorActual)
                        {
                            hayGanador = true;
                        }

                        if (hayGanador == true)
                        {
                            Console.WriteLine("\n=== TABLERO FINAL ===");
                            for (i = 0; i < 3; i++)
                            {
                                Console.WriteLine(" " + tablero[i, 0] + " | " + tablero[i, 1] + " | " + tablero[i, 2]);
                            }
                            Console.WriteLine("\n¡El Jugador " + jugadorActual + " ha ganado!");
                            juegoTerminado = true;
                        }
                        else if (movimientos == 9)
                        {
                            Console.WriteLine("\n=== TABLERO FINAL ===");
                            for (i = 0; i < 3; i++)
                            {
                                Console.WriteLine(" " + tablero[i, 0] + " | " + tablero[i, 1] + " | " + tablero[i, 2]);
                            }
                            Console.WriteLine("\n¡Es un empate!");
                            juegoTerminado = true;
                        }
                        else
                        {
                            if (jugadorActual == 'X')
                            {
                                jugadorActual = 'O';
                            }
                            else
                            {
                                jugadorActual = 'X';
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Movimiento invalido. Intente de nuevo.");
                    }
                }

                Console.Write("\n¿Desea jugar de nuevo? (1 = Si, 2 = No): ");
                int respuesta = int.Parse(Console.ReadLine()!);
                if (respuesta != 1)
                {
                    jugarDeNuevo = false;
                }
            }
        }
    }
}
