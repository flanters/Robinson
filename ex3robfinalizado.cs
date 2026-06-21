using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== CADASTRO - CARRO ===");
        Carro carro = new Carro();
        carro.ReceberDados();

        Console.WriteLine("\n=== CADASTRO - MOTO ===");
        Moto moto = new Moto();
        moto.ReceberDados();

        Console.WriteLine("\n=== CADASTRO - CAMINHÃO ===");
        Caminhao caminhao = new Caminhao();
        caminhao.ReceberDados();

        Console.WriteLine("\n=========================================");
        Console.WriteLine("          RELATÓRIO DE MANUTENÇÃO        ");
        Console.WriteLine("=========================================");

        // O polimorfismo acontece aqui ao exibir os dados e calcular as taxas de cada um
        carro.MostrarDados();
        moto.MostrarDados();
        caminhao.MostrarDados();

        Console.ReadKey();
    }
}

