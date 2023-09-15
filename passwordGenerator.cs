using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Generador de Contraseñas");
        Console.Write("Longitud de la Contraseña: ");
        int longitud = int.Parse(Console.ReadLine());

        string contraseñaGenerada = GenerarContraseña(longitud);

        Console.WriteLine("Contraseña Generada: " + contraseñaGenerada);
    }

    static string GenerarContraseña(int longitud)
    {
        const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+";

        StringBuilder contraseña = new StringBuilder();
        Random random = new Random();

        for (int i = 0; i < longitud; i++)
        {
            int indice = random.Next(caracteres.Length);
            contraseña.Append(caracteres[indice]);
        }

        return contraseña.ToString();
    }
}
