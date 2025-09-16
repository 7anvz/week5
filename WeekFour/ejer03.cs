using System;

public class CONVERSIONMONEDAS
{
    public static void Main(string[] args)
    {
        //https://www.programiz.com/csharp-programming/online-compiler/
        Console.Write("Ingrese un monto en soles: ");
        double soles = double.Parse(Console.ReadLine());
        Console.WriteLine("\n SELECCIONE UNA OPCION: ");
        Console.WriteLine("[1] Dolares");
        Console.WriteLine("[2] Euros");
        int opcion = int.Parse(Console.ReadLine());

        switch(opcion)
        {
            case 1:
            Console.WriteLine($"USD: {(soles/3.75):F2}"); break;
            case 2:
            Console.WriteLine($"EUR: {(soles/4.05):F2}"); break;
            default:
            Console.WriteLine("Opcion incorrecta"); break;
        }

    }
}