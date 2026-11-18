using System;

class Aula03
{
    // aula 03 de formatação de saída no console 
    static void Main()
    {
        double valorCompra, valorVenda, lucro;

        valorCompra = 5.10;
        lucro = 0.1;
        valorVenda = valorCompra+(valorCompra*lucro);
        string produto = "pastel";

        Console.WriteLine($"Produto.........{produto}");
        Console.WriteLine($"val.compra......{valorCompra:c}");
        Console.WriteLine($"Lucro...........{lucro:p}");
        Console.WriteLine($"val.venda.......{valorVenda:c}");
    }
}
