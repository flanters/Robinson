using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Cliente> listaClientes = new List<Cliente>();
        int opcao = 0;

        // Laço de repetição do Menu Principal
        while (opcao != 4)
        {
            Console.Clear();
            Console.WriteLine("=== SISTEMA DE GERENCIAMENTO DE CLIENTES ===");
            Console.WriteLine("1 - Cadastrar Cliente");
            Console.WriteLine("2 - Listar Clientes");
            Console.WriteLine("3 - Simular Compra com Desconto");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                opcao = 0;
            }

            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("--- CADASTRAR NOVO CLIENTE ---");
                    Console.Write("Digite o nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Digite o email: ");
                    string email = Console.ReadLine();
                    Console.Write("Digite o tipo (Comum ou VIP): ");
                    string tipo = Console.ReadLine();

                    // Cria e adiciona o cliente na lista
                    Cliente novoCliente = new Cliente(nome, email, tipo);
                    listaClientes.Add(novoCliente);

                    Console.WriteLine("\nCliente cadastrado com sucesso!");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("--- LISTA DE CLIENTES CADASTRADOS ---");
                    if (listaClientes.Count == 0)
                    {
                        Console.WriteLine("Nenhum cliente cadastrado ainda.");
                    }
                    else
                    {
                        foreach (Cliente c in listaClientes)
                        {
                            c.ExibirDados();
                        }
                    }
                    Console.ReadKey();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("--- SIMULAR COMPRA COM DESCONTO ---");
                    if (listaClientes.Count == 0)
                    {
                        Console.WriteLine("Cadastre pelo menos um cliente primeiro!");
                        Console.ReadKey();
                        break;
                    }

                    // Lista os clientes para o usuário escolher pelo índice
                    Console.WriteLine("Selecione o cliente para a compra:");
                    for (int i = 0; i < listaClientes.Count; i++)
                    {
                        Console.Write($"[{i}] ");
                        listaClientes[i].ExibirDados();
                    }

                    Console.Write("\nDigite o número do cliente: ");
                    int indice = Convert.ToInt32(Console.ReadLine());

                    if (indice >= 0 && indice < listaClientes.Count)
                    {
                        Cliente selecionado = listaClientes[indice];
                        Console.Write("Digite o valor total da compra: R$ ");
                        double valorCompra = Convert.ToDouble(Console.ReadLine());

                        // Polimorfismo por interface em ação:
                        double desconto = selecionado.CalcularDesconto(valorCompra);
                        double valorFinal = valorCompra - desconto;

                        Console.WriteLine($"\nDesconto aplicado: R$ {desconto:F2}");
                        Console.WriteLine($"Valor final a pagar: R$ {valorFinal:F2}");
                    }
                    else
                    {
                        Console.WriteLine("Cliente inválido!");
                    }
                    Console.ReadKey();
                    break;

                case 4:
                    Console.WriteLine("\nSaindo do sistema... Até logo!");
                    break;

                default:
                    Console.WriteLine("\nOpção inválida! Pressione qualquer tecla para tentar novamente.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
