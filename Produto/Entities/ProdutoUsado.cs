using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Produtos.Entities
{
    class ProdutoUsado : Produto
    {
        public DateTime DataFrabricacao { get; set; }

        public ProdutoUsado()
        {
        }

        public ProdutoUsado(string nome, double preco, DateTime dataFrabricacao)
            : base(nome, preco)
        {
            DataFrabricacao = dataFrabricacao;
        }


        public override string EtiquetaPreco()
        {
            return Nome
                + " (Usado) $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " (Data da Fabricação: ) "
                + DataFrabricacao.ToString("dd/MM/yyyy")
                + ")";
            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine(Nome +  " (usado) $ " + EtiquetaPreco() + "(Data da Fabricação: " + DataFrabricacao + ")");
            //return sb.ToString();
        }
    }
}
