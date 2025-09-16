using System;

public class FORMASGEOMETRICAS
{
    public static void Main(string[] args)
    {
        //https://www.programiz.com/csharp-programming/online-compiler/
        Console.WriteLine("Bienvenidos al calculo de areas");
        Console.WriteLine("[1] CUADRADO");
        Console.WriteLine("[2] RECTANGULO");
        Console.WriteLine("[3] TRIANGULO");
        Console.WriteLine("[4] CIRCULO");
        Console.Write("\n INGRESE UNA OPCION: ");
        int opcion = int.Parse(Console.ReadLine());

        switch(opcion)
        {
            case 1:
            Console.Write("Ingrese lado >> ");
            int lado = int.Parse(Console.ReadLine());
            Console.WriteLine($"\n Área: {lado * lado}"); break;
            case 2:
            Console.Write("Ingrese la base >> ");
            int bse = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la altura >> ");
            int altura = int.Parse(Console.ReadLine());
            Console.WriteLine($"\n Área: {bse * altura}"); break;
            case 3:
            Console.Write("Ingrese la base >> ");
            int bse2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura >> ");
            int altura2 = int.Parse(Console.ReadLine());
            Console.Write($"\n Área: {(bse2 * altura2)/2}"); break;
            case 4:
            Console.Write("Ingrese el radio >> ");
            double radio = double.Parse(Console.ReadLine());
            Console.WriteLine($"\n Área: {Math.PI * (radio*radio):F2}"); break;
            default:
            Console.WriteLine("OPCION INCORRECTA"); break;
        }

    }
}