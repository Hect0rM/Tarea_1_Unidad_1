using System;
using System.Diagnostics.Contracts;

namespace Tarea1.tarea
{
    public class Tarea20
    {
        public void tarea20()
        {
            bool contrasenaCorrecta = false;

            while (contrasenaCorrecta == false) {
                Console.WriteLine("Ingrese su contraseña:");
                string contrasena = Console.ReadLine();

                bool tieneLargoValido = false;
                bool tieneMayuscula = false;
                bool tieneMinuscula = false;
                bool tieneNumero = false;
                bool tieneEspecial = false;

                if (contrasena.Length >= 8) 
                {
                    tieneLargoValido = true;
                }

                for (int i = 0; i < contrasena.Length; i++) 
                {
                    char letraActual = contrasena[i];

                    if (char.IsUpper(letraActual)) 
                    {
                        tieneMayuscula = true;
                    }
                    if (char.IsLower(letraActual)) 
                    {
                        tieneMinuscula = true;
                    }
                    if (char.IsDigit(letraActual)) 
                    {
                        tieneNumero = true;
                    }
                    if (char.IsLetterOrDigit(letraActual) == false) 
                    {
                        tieneEspecial = true;
                    }
                }

                if (tieneLargoValido == true && tieneMayuscula == true && tieneMinuscula == true && tieneNumero == true && tieneEspecial == true) 
                {
                    Console.WriteLine("¡Felicidades! La contraseña es válida.");
                    contrasenaCorrecta = true;
                }
                else 
                {
                    Console.WriteLine("Contraseña incorrecta. Te falta lo siguiente:");

                    if (tieneLargoValido == false) {
                        Console.WriteLine("- Debe tener mínimo 8 caracteres.");
                    }
                    if (tieneMayuscula == false) {
                        Console.WriteLine("- Debe tener al menos una mayúscula.");
                    }
                    if (tieneMinuscula == false) {
                        Console.WriteLine("- Debe tener al menos una minúscula.");
                    }
                    if (tieneNumero == false) {
                        Console.WriteLine("- Debe tener al menos un número.");
                    }
                    if (tieneEspecial == false) {
                        Console.WriteLine("- Debe tener al menos un carácter especial (ej: * o #).");
                    }
                    
                    Console.WriteLine("---------------------------------------------");
                }
            }
        }
    }
}
