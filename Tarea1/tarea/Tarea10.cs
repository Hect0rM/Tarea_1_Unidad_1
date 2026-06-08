using System.ComponentModel.Design;

namespace Tarea1.tarea
{
    public class Tarea10
    {
        public void tarea10()
        {
            Console.Write("Ingres la Nota A: \n");
            decimal A = decimal.Parse(Console.ReadLine()!);
            if (A > 1 && A < 100 )
            {
                Console.Write("Ingres la Nota B: \n");
                decimal B = decimal.Parse(Console.ReadLine()!);
                if (B > 1 && B < 100)
                {
                    Console.Write("Ingres la Nota C: \n");
                    decimal C = decimal.Parse(Console.ReadLine()!);
                    if (C > 1 && C <100)
                    {
                        Console.Write("Ingres la Nota D: \n");
                        decimal D = decimal.Parse(Console.ReadLine()!);
                        if (D > 1 && D > 100)
                        {
                            Console.Write("Ingres la Nota F: \n");
                            decimal F = decimal.Parse(Console.ReadLine()!);
                            if (F > 1 && F < 100)
                            {
                                decimal avg = (A+B+C+D+F)/5;
                                if (avg > 65 )
                                {
                                    Console.Write("Aprobo la materia");
                                }
                                else
                                {
                                    Console.Write("No Probo la clase");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}