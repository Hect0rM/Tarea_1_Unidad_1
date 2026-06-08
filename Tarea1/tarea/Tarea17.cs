using System.Reflection.Emit;

namespace Tarea1.tarea
{
    public class Tarea17
    {
        public void tarea17()
        {
            int i=0;
            int a =0;
            int b=1;
            int c =0;
            Console.WriteLine("Ingrese la cantidad de numeros Fibonacci: ");
            int cant = int.Parse(Console.ReadLine()!);

            for (i=0;i<=cant; i++)
            {

                Console.Write($"{a}");
                c = a + b;
                
                a=b;
                b=c;
            }
        }
    }
}