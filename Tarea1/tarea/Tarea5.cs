namespace Tarea1.tarea
{
    public class Tarea5
    {
        public void tarea5()
        {
            Console.Write("Ingrese una Hora en formato 24 horas: ");
            int hora = int.Parse(Console.ReadLine()!);
            Console.Write("Ingrese los minutos: ");
            int minutos = int.Parse(Console.ReadLine()!);
            Console.Write("Ingrese los segundos: ");
            int segundos = int.Parse(Console.ReadLine()!);

            Console.Write("Ingrese una Hora en formato 24 horas: ");
            int hora2 = int.Parse(Console.ReadLine()!);
            Console.Write("Ingrese los minutos: ");
            int minutos2 = int.Parse(Console.ReadLine()!);
            Console.Write("Ingrese los segundos: ");
            int segundos2 = int.Parse(Console.ReadLine()!);

            int hora3 = (24 - hora) + hora2;
            int minutos3 = (60 - minutos) + minutos2;
            int segundos3 = (60 - segundos) + segundos2;

            Console.WriteLine($"La diferencia entre las horas es: {hora3} horas, {minutos3} minutos y {segundos3} segundos"); 

            

            
        }
    }
}