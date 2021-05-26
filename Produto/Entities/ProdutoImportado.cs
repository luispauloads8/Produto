using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Produtos.Entities
{
    class ProdutoImportado : Produto
    {
        public double TaxaTransporte { get; set; }

        public ProdutoImportado()
        {
        }

        public ProdutoImportado(string nome, double preco, double taxaTransporte)
            : base(nome, preco)
        {
            TaxaTransporte = taxaTransporte;
        }

        public double TotalPreco()
        {
            return Preco + TaxaTransporte;
        }

        public override string EtiquetaPreco()
        {
            return Nome
                + " $ "
                + TotalPreco().ToString("F2", CultureInfo.InvariantCulture)
                + " (Preço da Alfandega: $ "
                + TaxaTransporte.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
          //  StringBuilder sb = new StringBuilder();
          //  sb.AppendLine(Nome + " $ " + TotalPreco().ToString("F2", CultureInfo.InvariantCulture) + " $ " + "(Preco da altandega:  $" + TaxaTransporte.ToString("F2", CultureInfo.InvariantCulture) +")");
          //  return sb.ToString();
        }
    }
}
