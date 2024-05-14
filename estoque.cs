using System;
using System.Collections.Generic;

class Program
{
    static List<Produto> estoque = new List<Produto>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("======= Aplicativo de Controle de Estoque =======");
            Console.WriteLine("1. Adicionar Produto");
            Console.WriteLine("2. Atualizar Estoque");
            Console.WriteLine("3. Listar Produtos");
            Console.WriteLine("4. remover do estoque");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    AdicionarProduto();
                    break;
                case "2":
                    AtualizarEstoque();
                    break;
                case "3":
                    ListarProdutos();
                    break;
                case "4":
                    remover();
                    break;
                case "5":
                    Console.WriteLine("Saindo do aplicativo. Até logo!");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    static void AdicionarProduto()
    {
        Console.WriteLine("======= Adicionar Produto =======");

        Console.Write("Nome do Produto: ");
        string nome = Console.ReadLine();

        Console.Write("Quantidade em Estoque: ");
        int quantidade = int.Parse(Console.ReadLine());

        Produto produto = new Produto(nome, quantidade);
        estoque.Add(produto);

        Console.WriteLine($"Produto '{nome}' adicionado ao estoque com {quantidade} unidades.");
    }

    static void AtualizarEstoque()
    {
        Console.WriteLine("======= Atualizar Estoque  =======");

        ListarProdutos();

        Console.Write("Digite o índice do produto que deseja atualizar: ");
        int indice = int.Parse(Console.ReadLine());

        if (indice >= 0 && indice < estoque.Count)
        {
            Console.Write("Digite a quantidade atualizada: ");
            int novaQuantidade = int.Parse(Console.ReadLine());

            estoque[indice].Quantidade = novaQuantidade;
            Console.WriteLine($"Estoque do produto '{estoque[indice].Nome}' atualizado para {novaQuantidade} unidades.");
        }
        else
        {
            Console.WriteLine("Índice inválido. Produto não encontrado.");
        }
    }

    static void remover()
    {
        Console.WriteLine("=======remover produto======");

        ListarProdutos();

    


    }

    static void ListarProdutos()
    {
        Console.WriteLine("======= Lista de Produtos =======");

        for (int i = 0; i < estoque.Count; i++)
        {
            Console.WriteLine($"{i}. {estoque[i].Nome} - Estoque: {estoque[i].Quantidade} unidades");
        }
    }
}

class Produto
{
    public string Nome { get; set; }
    public int Quantidade { get; set; }

    public Produto(string nome, int quantidade)
    {
        Nome = nome;
        Quantidade = quantidade;
    }
}
