using System.ComponentModel;
using System.ComponentModel.Design;

namespace Tarea1.tarea
{
    public class Tarea12
    {
        public void tarea12()
        {
            Console.Write("Ingrese el anio: ");
            int anio = int.Parse(Console.ReadLine()!);

            Console.Write("Ingrese el mes en forma Numerica: ");
            int mes = int.Parse(Console.ReadLine()!);

            int compro = 0;

            if (anio % 4 == 0 || anio % 100 == 0)
            {
                Console.Write("El anio es Bisieto");
                compro = 1;
            }

            if ( compro == 1)
            {
                if ( mes==1 || mes == 3 || mes == 5 || mes==7|| mes==8 || mes==10 || mes==12)
                {
                    Console.Write("EL mes tiene 31 dias");
                }
                else if ( mes == 2)
                {
                    Console.Write("El mes tiene 28 dias ");
                }
                else
                {
                    Console.Write("El mes tiene 30 dias");
                }
            }
            else if ( compro == 0)
            {
                if ( mes==1 || mes == 3 || mes == 5 || mes==7|| mes==8 || mes==10 || mes==12)
                {
                    Console.Write("EL mes tiene 31 dias");
                }
                else if ( mes == 2)
                {
                    Console.Write("El mes tiene 29 dias ");
                }
                else
                {
                    Console.Write("El mes tiene 30 dias");
                }
            }

        }
    }
}