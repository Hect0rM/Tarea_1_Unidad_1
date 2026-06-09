namespace Tarea1.tarea
{
    public class Tarea19
    {
        public void tarea19()
        {
            Random Rand = new Random();
            int random = Rand.Next(1,100);

            Console.Write("Ingrese un Numero a Adivinar: \n");
            int numero = 0;
            

           for (int i = 1; i < 8 ; i++)
            {
                numero = int.Parse(Console.ReadLine()!);

                if ( numero > random)
                {
                    Console.Write("El Numero es Menor que ese\n");
                }
                else if ( numero < random)
                {
                    Console.Write("EL numero es Mayor que ese \n");
                }
                else if (numero == random)
                {
                    Console.WriteLine("Felicidades ese el Numero Ganaste");
                    Console.WriteLine($"Lo lograste en {i} intentos");
                }
                else if (i == 7)
                {
                    Console.Write("GAME OVER MANCO JEJEJE");
                }
            }
        }
    }
}