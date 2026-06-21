using System;
using System.Collections.Generic; // Obrigatório para poder usar o List<>

class Program
{
    static void Main(string[] args)
    {
        // Criação da lista que guardará os 4 produtos
        List<Produto> listaProdutos = new List<Produto>();

        Console.WriteLine("=== CADASTRO DE PRODUTOS ===");

        // Laço de repetição para cadastrar exatamente 4 produtos
        for (int i = 1; i <= 4; i++)
        {
            Console.WriteLine($"\nProduto #{i}:");
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o preço do produto: R$ ");
            double preco = Convert.ToDouble(Console.ReadLine());

            // Cria o objeto produto com os dados digitados e adiciona na lista
            Produto novoProduto = new Produto(nome, preco);
            listaProdutos.Add(novoProduto);
        }

        Console.WriteLine("\n=========================================");
        Console.WriteLine("          RELATÓRIO DE PRODUTOS          ");
        Console.WriteLine("=========================================");

        double valorTotal = 0;

        // Percorre a lista para exibir os produtos e somar o total
        foreach (Produto prod in listaProdutos)
        {
            Console.WriteLine($"- {prod.Nome}: R$ {prod.Preco:F2}");
            valorTotal += prod.Preco; // Soma o preço do produto atual ao total
        }

        Console.WriteLine("-----------------------------------------");
        Console.WriteLine($"VALOR TOTAL DOS PRODUTOS: R$ {valorTotal:F2}");
        Console.WriteLine("=========================================");

        Console.ReadKey();
    }
}

