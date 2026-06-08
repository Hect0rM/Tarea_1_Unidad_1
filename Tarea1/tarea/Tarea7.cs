namespace Tarea1.tarea
{
    public class Tarea7
    {
        public void tarea7()
        {
            Console.Write("1-- bytes a kilobytes");
            Console.Write("2-- kilobytes a bytes");
            Console.Write("3-- bytes a megabytes");
            Console.Write("4-- megabytes a bytes");
            Console.Write("5-- kilobytes a megabytes");
            Console.Write("6-- megabytes a kilobytes");
            Console.Write("7-- bytes a gigabytes");
            Console.Write("8-- gigabytes a bytes");
            Console.Write("9-- kilobytes a gigabytes");
            Console.Write("10-- gigabytes a kilobytes");
            Console.Write("11-- megabytes a gigabytes");
            Console.Write("12-- gigabytes a megabytes");
            Console.Write("13-- bytes a terabytes");
            Console.Write("14-- terabytes a bytes");
            Console.Write("15-- kilobytes a terabytes");
            Console.Write("16-- terabytes a kilobytes");
            Console.Write("17-- megabytes a terabytes");
            Console.Write("18-- terabytes a megabytes");

            int opcion = int.Parse(Console.ReadLine()!);

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese la cantidad de bytes: ");
                    decimal bytes = decimal.Parse(Console.ReadLine()!);
                    decimal kilobytes = bytes / 1024;
                    Console.WriteLine($"La cantidad en kilobytes es: {kilobytes}");
                    break;
                case 2:
                    Console.Write("Ingrese la cantidad de kilobytes: ");
                    kilobytes = decimal.Parse(Console.ReadLine()!);
                    bytes = kilobytes * 1024;
                    Console.WriteLine($"La cantidad en bytes es: {bytes}");
                    break;
                case 3:
                    Console.Write("Ingrese la cantidad de bytes: ");
                    bytes = decimal.Parse(Console.ReadLine()!);
                    decimal megabytes = bytes / (1024 * 1024);
                    Console.WriteLine($"La cantidad en megabytes es: {megabytes}");
                    break;
                case 4:
                    Console.Write("Ingrese la cantidad de megabytes: ");
                    megabytes = decimal.Parse(Console.ReadLine()!);
                    bytes = megabytes * (1024 * 1024);
                    Console.WriteLine($"La cantidad en bytes es: {bytes}");
                    break;
                case 5:
                    Console.Write("Ingrese la cantidad de kilobytes: ");
                    kilobytes = decimal.Parse(Console.ReadLine()!);
                    megabytes = kilobytes / 1024;
                    Console.WriteLine($"La cantidad en megabytes es: {megabytes}");
                    break;
                case 6:
                    Console.Write("Ingrese la cantidad de megabytes: ");
                    megabytes = decimal.Parse(Console.ReadLine()!);
                    kilobytes = megabytes * 1024;
                    Console.WriteLine($"La cantidad en kilobytes es: {kilobytes}");
                    break;
                case 7:
                    Console.Write("Ingrese la cantidad de bytes: ");
                    bytes = decimal.Parse(Console.ReadLine()!);
                    decimal gigabytes = bytes / (1024 * 1024 * 1024);
                    Console.WriteLine($"La cantidad en gigabytes es: {gigabytes}");
                    break;
                case 8:
                    Console.Write("Ingrese la cantidad de gigabytes: ");
                    gigabytes = decimal.Parse(Console.ReadLine()!);
                    bytes = gigabytes * (1024 * 1024 * 1024);
                    Console.WriteLine($"La cantidad en bytes es: {bytes}");
                    break;
                case 9:
                    Console.Write("Ingrese la cantidad de kilobytes: ");
                    kilobytes = decimal.Parse(Console.ReadLine()!);
                    gigabytes = kilobytes / (1024 * 1024);
                    Console.WriteLine($"La cantidad en gigabytes es: {gigabytes}");
                    break;
                case 10:
                    Console.Write("Ingrese la cantidad de gigabytes: ");
                    gigabytes = decimal.Parse(Console.ReadLine()!);
                    kilobytes = gigabytes * (1024 * 1024);  
                    Console.WriteLine($"La cantidad en kilobytes es: {kilobytes}");
                    break;
                case 11:
                    Console.Write("Ingrese la cantidad de megabytes: ");
                    megabytes = decimal.Parse(Console.ReadLine()!);
                    gigabytes = megabytes / 1024;
                    Console.WriteLine($"La cantidad en gigabytes es: {gigabytes}");
                    break;
                case 12:
                    Console.Write("Ingrese la cantidad de gigabytes: ");
                    gigabytes = decimal.Parse(Console.ReadLine()!);
                    megabytes = gigabytes * 1024;
                    Console.WriteLine($"La cantidad en megabytes es: {megabytes}");
                    break;
                case 13:
                    Console.Write("Ingrese la cantidad de bytes: ");
                    bytes = decimal.Parse(Console.ReadLine()!);
                    gigabytes = bytes / (1024 * 1024 * 1024);
                    Console.WriteLine($"La cantidad en gigabytes es: {gigabytes}");
                    break;
                case 14:
                    Console.Write("Ingrese la cantidad de gigabytes: ");
                    gigabytes = decimal.Parse(Console.ReadLine()!);
                    bytes = gigabytes * (1024 * 1024 * 1024);
                    Console.WriteLine($"La cantidad en bytes es: {bytes}");
                    break;
                case 15:
                    Console.Write("Ingrese la cantidad de kilobytes: ");
                    kilobytes = decimal.Parse(Console.ReadLine()!);
                    decimal terabytes = kilobytes / (1024 * 1024 * 1024);
                    Console.WriteLine($"La cantidad en terabytes es: {terabytes}");
                    break;
                case 16:
                    Console.Write("Ingrese la cantidad de terabytes: ");
                    terabytes = decimal.Parse(Console.ReadLine()!);
                    kilobytes = terabytes * (1024 * 1024 * 1024);
                    Console.WriteLine($"La cantidad en kilobytes es: {kilobytes}");
                    break;
                case 17:
                    Console.Write("Ingrese la cantidad de megabytes: ");
                    megabytes = decimal.Parse(Console.ReadLine()!);
                    terabytes = megabytes / (1024 * 1024);
                    Console.WriteLine($"La cantidad en terabytes es: {terabytes}");
                    break;
                case 18:
                    Console.Write("Ingrese la cantidad de terabytes: ");
                    terabytes = decimal.Parse(Console.ReadLine()!);
                    megabytes = terabytes * (1024 * 1024);
                    Console.WriteLine($"La cantidad en megabytes es: {megabytes}");
                    break;
            }
        }
    }
}