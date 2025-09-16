using System;

public class ADULTOOMENOR
{
    public static void Main(string[] args)
    {
        //https://www.programiz.com/csharp-programming/online-compiler/
        Console.Write("Ingrese una edad: ");
        int edad = int.Parse(Console.ReadLine());
        if (edad < 18) Console.WriteLine("Menor de edad");
        else {
            if (edad <= 64) Console.WriteLine("Adulto");
            else Console.WriteLine("Adulto Mayor")
        } 
        Console.ReadKey();
    }
}