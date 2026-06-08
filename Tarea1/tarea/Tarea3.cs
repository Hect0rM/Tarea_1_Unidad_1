namespace Tarea1.tarea
{
    public class Tarea3
    {
        public void tarea3()
        {
            Console.Write("Ingrese el monto en lempiras: ");
        int monto = int.Parse(Console.ReadLine()!);

        int[] billetes = { 500, 100, 50, 20, 10, 5, 2, 1 };

        Console.WriteLine("\nDesglose de billetes:");

        foreach (int billete in billetes)
        {
            int cantidad = monto / billete;

            if (cantidad > 0)
            {
                Console.WriteLine($"{cantidad} billete(s) de L {billete}");
                monto %= billete;
            }
        }
        }
    }
}