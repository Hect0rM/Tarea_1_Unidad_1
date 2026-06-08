namespace Tarea1.tarea
{
    public class Tarea14
    {
        public void tarea14()
        {
            int saldo = 5000;
            Console.Write("Ingrese Cantidad a retirar: ");
            int can = int.Parse(Console.ReadLine()!);

            if ( can <= saldo )
            {
                if ( can % 4 == 0)
                {
                    int retir = saldo - can;
                    int bill = retir/4;

                    Console.Write($"EL saldo retirado es de:{can}");
                    Console.Write($"El saldo restante es de: {retir}");
                    Console.Write($"se entrego 4 billestes de: {bill}");
                }
            }
        }
    }
}