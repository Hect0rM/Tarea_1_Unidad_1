namespace Tarea1.tarea
{
    public class Tarea8
    {
        public void tarea8()
        {
            Console.Write("Ingrese Horas trabajadas: ");
            int horasTrabajadas = int.Parse(Console.ReadLine()!);
            Console.Write("Ingrese el pago por hora: ");
            decimal pagoPorHora = decimal.Parse(Console.ReadLine()!);

            if(horasTrabajadas > 44)
            {
                decimal horasExtra = horasTrabajadas - 44;
                decimal pagoHorasExtra = horasExtra * pagoPorHora * 1.5m;
                decimal horasTotal = 44 * pagoPorHora + pagoHorasExtra;
                Console.WriteLine($"El pago total es: {horasTotal}");
                Console.WriteLine($"El pago por horas extra es: {pagoHorasExtra}");
            }
            else
            {
                decimal pagoTotal = horasTrabajadas * pagoPorHora;
                Console.WriteLine($"El pago total es: {pagoTotal}");
            }
            
        }
    }
}