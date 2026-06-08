namespace Tarea1.tarea
{
    public class Tarea1unidad()
    {
       public void tarea1 ()
        {
        
        decimal peso = decimal.Parse(Console.ReadLine()!);
        decimal altura = decimal.Parse(Console.ReadLine()!);

        decimal imc = peso / (altura * altura);


        if (imc < 18.5m)
        {
            Console.WriteLine("Bajo peso");
        }
        else if (imc >= 18.5m && imc < 25m)
        {
            Console.WriteLine("Peso normal");
        }
        else if (imc >= 25m && imc < 30m)
        {
            Console.WriteLine("Sobrepeso");
        }
        else
        {
            Console.WriteLine("Obesidad");
        }
        }

        
        
    }
}