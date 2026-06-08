namespace Tarea1.tarea
{
    public class Tarea9
    {
        public void tarea9()
        {
            Console.Write("Ingrese los 3 angulos de un triangulo: ");
            decimal angulo1 = decimal.Parse(Console.ReadLine()!);
            decimal angulo2 = decimal.Parse(Console.ReadLine()!);
            decimal angulo3 = decimal.Parse(Console.ReadLine()!);

            if ( angulo1 == angulo2 && angulo1 == angulo3)
            {
                Console.Write("Es un Triangulo Equilatero");
            }
            else if ( angulo1 == angulo2 || angulo1 == angulo3 || angulo2 == angulo3)
            {
                Console.Write("Es un Triangulo Isosceles");
            }
            else
            {
                Console.Write("Es un Triangulo Escaleno");
            }
           
        }
    }
}