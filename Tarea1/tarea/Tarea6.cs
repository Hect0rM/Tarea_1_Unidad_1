namespace Tarea1.tarea
{
    public class Tarea6
    {
        public void tarea6()
        {
            Console.Write("1 -- Area de un Circulo\n");
            Console.Write("2 -- Area de un Triangulo\n");
            Console.Write("3 -- Area de un Rectangulo\n");

            int opcion = int.Parse(Console.ReadLine()!);

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el radio del Circulo: ");
                    decimal radio = decimal.Parse(Console.ReadLine()!);
                    decimal areaCirulo = 3.1416m * radio * radio;
                    Console.WriteLine($" El area del circulo es: {areaCirulo}");
                    break;
                case 2:
                    Console.Write("Ingrese la base del Triangulo: ");
                    decimal baseTriangulo = decimal.Parse(Console.ReadLine()!);
                    Console.Write("Ingrese la altura del Triangulo: ");
                    decimal alturaTriangulo = decimal.Parse(Console.ReadLine()!);
                    decimal areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
                    Console.WriteLine($" El area del triangulo es: {areaTriangulo}");
                    break;
                case 3:
                    Console.Write("Ingrese la base del Rectangulo: ");
                    decimal baseRectangulo = decimal.Parse(Console.ReadLine()!);
                    Console.Write("Ingrese la altura del Rectangulo: ");
                    decimal alturaRectangulo = decimal.Parse(Console.ReadLine()!);
                    decimal areaRectangulo = baseRectangulo * alturaRectangulo;
                    Console.WriteLine($" El area del rectangulo es: {areaRectangulo}");
                    break;
            }
        }
    }
}