namespace Tarea1.tarea
{
    public class Tarea2
    {
        public void tarea2()
        {
            Console.WriteLine("1-- de Celsious a Farenheit");
            Console.WriteLine("2-- de Farenheit a Celsious");
            Console.WriteLine("3-- de Celsious a Kelvin");
            Console.WriteLine("4-- de Kelvin a Celsious");
            Console.WriteLine("5-- de Farenheit a Kelvin");
            Console.WriteLine("6-- de Kelvin a Farenheit");

            decimal opcion = decimal.Parse(Console.ReadLine()!);

            switch (opcion)
            {
                case 1:
                    decimal celsious = decimal.Parse(Console.ReadLine()!);
                    decimal farenheit = (celsious * 9 / 5) + 32;
                    Console.WriteLine($"La temperatura en Farenheit es: {farenheit}");
                    break;
                case 2:
                    farenheit = decimal.Parse(Console.ReadLine()!);
                    celsious = (farenheit - 32) * 5 / 9;
                    Console.WriteLine($"La temperatura en Celsious es: {celsious}");
                    break;
                case 3:
                    celsious = decimal.Parse(Console.ReadLine()!);
                    decimal kelvin = celsious + 273.15m;
                    Console.WriteLine($"La temperatura en Kelvin es: {kelvin}");
                    break;
                case 4:
                    kelvin = decimal.Parse(Console.ReadLine()!);
                    celsious = kelvin - 273.15m;
                    Console.WriteLine($"La temperatura en Celsious es: {celsious}");
                    break;
                case 5:
                    farenheit = decimal.Parse(Console.ReadLine()!);
                    kelvin = (farenheit - 32) * 5 / 9 + 273.15m;
                    Console.WriteLine($"La temperatura en Kelvin es: {kelvin}");
                    break;
                case 6:
                    kelvin = decimal.Parse(Console.ReadLine()!);
                    farenheit = (kelvin - 273.15m) * 9 / 5 + 32;
                    Console.WriteLine($"La temperatura en Farenheit es: {farenheit}");
                    break;
            }

        }
    }
}