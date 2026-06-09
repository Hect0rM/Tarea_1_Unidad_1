namespace Tarea1.tarea
{
    public class Tarea18
    {
        public void tarea18()
        {
       
            //int a =1;
            int resultado=0;
            Console.Write("Ingrese N (nCr)");
            int n = int.Parse(Console.ReadLine()!);

            Console.Write("Ingrese r (nCr)");
            int r = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= r; i++) 
            {
            resultado *= ( - r + i);
            resultado /= i;
            }
            Console.Write($"{resultado}");

        }
    }
}