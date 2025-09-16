// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
                   double MAP, INCR = 0.0, DSC = 0.0;

            Console.Write("METODO DE PAGO");
            Console.Write("[1] EFECTIVO");
            Console.Write("[2] TARJETA");
            int MP = int.Parse(Console.ReadLine());
            Console.Write("TOTAL A PAGAR");
            Console.Write("Ingrese el monto aqui >>> ");
            double TP = double.Parse(Console.ReadLine());

            if (MP == 1) DSC = 0.07 * TP;
            else if (MP == 2)
            {

                Console.Write("TIPO DE TARJETA: ");
                Console.Write("[1] DEBITO");
                Console.Write("[2] CREDITO");
                int NTT = int.Parse(Console.ReadLine());
                Console.Write("¿CUANTOS PRODUCTOS LLEVA?");
                int CANT = int.Parse(Console.ReadLine());
                if (NTT == 1 && CANT > 10) DSC = 0.05 * TP;
                else
                    INCR = 0.05 * TP;
            }
            else { if (TP == 100) DSC = 10; } 

        MAP = TP + INCR - DSC;

            Console.Write("EL TOTAL A PAGAR: " , TP);
            if (DSC != 0) Console.Write("EL DESCUENTO ES: ", DSC);
            else Console.Write("EL INCREMENTO ES: ", INCR); 
        Console.Write("EL MONTO A PAGAR ES: ", MAP);
    }
}