namespace Tarea1.tarea
{
    public class Tarea16
    {
        public void tarea16()

        {
            int i = 0;
            Console.Write("Ingrese el Numero inicial");
            int inicial = int.Parse(Console.ReadLine()!);

            Console.Write("Ingrese el Numero a terminar");
            int ultimo = int.Parse(Console.ReadLine()!);

            for (i = inicial ; i <= inicial ; i++)
            {
                double h = i;
                if ( i % h == 0 && i % 2 != 0)
                {
                    Console.Write($"{i}");
                }
            }
        }
    }
}