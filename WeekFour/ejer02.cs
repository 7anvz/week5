using System;

public class AÑOBISIESTOYPAR
{
    public static void Main(string[] args)
    {
        //https://www.programiz.com/csharp-programming/online-compiler/
        Console.Write("Ingrese un año: ");
        int annio = int.Parse(Console.ReadLine());
        if (annio % 4 == 0 && annio % 100 != 0 || annio % 400 == 0) 
        Console.WriteLine("Año bisiesto");
        else {
        Console.WriteLine("Año no bisiesto");
        }
        if (annio % 2 == 0) Console.WriteLine("Año par");
        else {
        Console.WriteLine("Año impar");
        }
        Console.ReadKey();
    }
}