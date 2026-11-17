using System;

class Programa {
    static void Main()
    {
        Console.Write("Dgite um número: ");

        int num1 =  int.Parse(Console.ReadLine()!);

        Console.Write("Digite outro: ");

        int num2 = int.Parse(Console.ReadLine()!);

        static int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        int resultado = Somar(num1, num2);

        Console.Write($"O resultado de {num1} + {num2} e = {resultado}");
    }
}