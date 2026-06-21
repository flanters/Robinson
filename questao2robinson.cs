using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SIMULAÇÃO DE PAGAMENTO PIX ===");
        PagamentoPix pgPix = new PagamentoPix();
        pgPix.ReceberDadosPix();
        Console.Write("Processando: ");
        pgPix.ProcessarPagamento();

        Console.WriteLine("\n=== SIMULAÇÃO DE PAGAMENTO CARTÃO ===");
        PagamentoCartaoCredito pgCartao = new PagamentoCartaoCredito();
        pgCartao.ReceberDadosCartao();
        Console.Write("Processando: ");
        pgCartao.ProcessarPagamento();

        Console.WriteLine("\n=========================================");
        Console.WriteLine("          RESUMO DOS PAGAMENTOS          ");
        Console.WriteLine("=========================================");
        pgPix.MostrarPagamento();
        pgCartao.MostrarPagamento();

        Console.ReadKey();
    }
}


