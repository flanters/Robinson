using Exercicio4;
using System.Collections.Generic;

int opcao = 0;
List<Aluno> listaDeAluno = new List<Aluno>();


do
{
    Console.WriteLine("1-Cadastrar um aluno(com RA único");
    Console.WriteLine("2 -Listar todos os alunos cadastrados");
    Console.WriteLine("3 -Alterar dados de um aluno existente(localizado pelo RA");
    Console.WriteLine("4 -Remover um aluno pelo RA");
    Console.WriteLine("0 -Encerrar o programa");

    Console.Write("Digite a Opção:");
    opcao = int.Parse(Console.ReadLine());
    Console.Clear();
    switch (opcao)
    {
        case 1:
            CadastrarAluno();
            break;
        case 2:
            ListarDados();
            break;
        case 3:
            AlterarDados();
            break;
        case 4:
            RemoverAluno();
            break;
        case 0:
            opcao = 0;    
            break;
        default:
            Console.WriteLine("Opção não existe!");
            break;
    }
} while (opcao != 0);


void CadastrarAluno()
{
    Aluno _aluno = new Aluno();
    Console.Write("Digite o nome:");
    _aluno.Nome = Console.ReadLine();

    Console.Write("Digite o RA:");
    _aluno.RA = Console.ReadLine();

    Console.Write("Digite a idade:");
    _aluno.Idade = int.Parse(Console.ReadLine());

    listaDeAluno.Add(_aluno);
}

void ListarDados()
{   
    foreach (Aluno paluno in listaDeAluno)
    {
        paluno.MostrarDados();
    }
}
void AlterarDados()
{
    Console.Write("Digite o RA a ser localizado:");
    string RA;
    RA = Console.ReadLine();
    bool encontrado = false;

    foreach (Aluno paluno in listaDeAluno)
    {
        if (paluno.RA == RA)
        {

            Console.Write("Digite o nome:");
            paluno.Nome = Console.ReadLine();

            Console.Write("Digite o RA:");
            paluno.RA = Console.ReadLine();

            Console.Write("Digite a idade:");
            paluno.Idade = int.Parse(Console.ReadLine());

            encontrado = true;
            break;
        }
    }
}
void RemoverAluno()
        {
          bool encontrado = false;
    Console.Write("Digite o RA do aluno a ser removido:");
            string RA;
            RA = Console.ReadLine();
            foreach (Aluno paluno in listaDeAluno)
            {
                if (paluno.RA == RA)
                {
                    listaDeAluno.Remove(paluno);
                    Console.WriteLine("Aluno removido com sucesso!");
                    encontrado = true;
                    break;
                }
            }
            if (encontrado == false)
            {
                Console.WriteLine("Dados não encontrados!");
            }
}


