namespace Tarea1.tarea
{
    public class Tarea15
    {
        public void tarea15()
        {

            Console.Write("Ingrese el Numero a multiplicar: ");
            int mult = int.Parse(Console.ReadLine()!);

            Console.Write("Ingrese hasta que numero va a Multiplicar: ");
            int cant = int.Parse(Console.ReadLine()!);

            int i;

            for ( i = 0 ; i<= cant; i++ )
            {
                int sol = i*mult;
                Console.Write($"{mult} X {i} = {sol} ");
            }

        }
    }
}