using Produtos.Entities;
using System;
using System.Globalization;
using System.Collections.Generic;



namespace Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a Quantidade de Produtos: ");
            int qt = int.Parse(Console.ReadLine());

            List<Produto> produto = new List<Produto>();

            for (int i = 1; i <= qt; i++)
            {
                Console.WriteLine($"Informação do #{i} Produto :");
                Console.Write("Produto é Usado ou Importado (c/u/i)?");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (tipo == 'c')
                {
                    produto.Add(new Produto(nome, preco));
                }
                else if (tipo == 'i')
                {
                    Console.Write("Valor Taxa Alfandega: ");
                    double taxa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    produto.Add(new ProdutoImportado(nome, preco, taxa));
                }
                if (tipo == 'u')
                {
                    Console.Write("Data da Fabricação: (DD/MM/YYYY)");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    produto.Add(new ProdutoUsado(nome, preco, data));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Preçao Etiquetas: ");
            foreach  (Produto prod in produto)
            {
                Console.WriteLine(prod.EtiquetaPreco());
            }
            

        }
    }
}
