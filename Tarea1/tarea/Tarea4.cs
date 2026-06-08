namespace Tarea1.tarea
{
    public class Tarea4
    {
        public void tarea4()
        {
            Console.Write("Ingrese el Monto: ");
            decimal monto = decimal.Parse(Console.ReadLine()!);

            Console.Write("Ingrese el Porcentaje de Interés: ");
            decimal porcentaje = decimal.Parse(Console.ReadLine()!);

            Console.Write("Ingrese el plazo en meses: ");
            int plazo = int.Parse(Console.ReadLine()!);
            decimal interesMensual = monto * (porcentaje / 100) / 12;
            decimal pagoMensual = (monto / plazo) + interesMensual;
            Console.WriteLine($"El pago mensual es: {pagoMensual:C}");
            

        }
    }
}