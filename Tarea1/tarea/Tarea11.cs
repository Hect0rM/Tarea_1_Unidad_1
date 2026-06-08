namespace Tarea1.tarea
{
    public class Tarea11
    {
        public void tarea11()
        {
            Console.Write("Ingrese monto a pagar: ");
            double monto = double.Parse(Console.ReadLine()!);

            if ( monto < 1000 && monto > 499)
            {
                double descuento = monto * 0.95;
                Console.Write($"El Total es de {monto}");
                Console.Write("El descuento es de 10%");
                Console.Write($"El Total a pagar sera de {descuento}");
                
            }
            else if ( monto < 999 && monto > 2499)
            {
                double descuento = monto * 0.9;
                Console.Write($"El Total es de {monto}");
                Console.Write("El descuento es de 10%");
                Console.Write($"El Total a pagar sera de {descuento}");
            }
            else if (monto > 2499)
            {
                double descuento = monto * 0.85;
                Console.Write($"El Total es de {monto}");
                Console.Write("El descuento es de 10%");
                Console.Write($"El Total a pagar sera de {descuento}");
            }
        }

    }
}