using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCadastroProduto
{
    public class Produto
    {
        public Produto(int codigo, string? nome, string? categoria, double preco, string datavencimento, string? observacao)
        {
            Codigo = codigo;
            Nome = nome;
            Categoria = categoria;
            Preco = preco;
            DataVencimento = datavencimento;
            Observacao = observacao;
        }
        public Produto() { }

        public static List<Produto> ListaProdutos = new List<Produto>();

        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Categoria { get; set; }
        public double Preco { get; set; }
        public string? DataVencimento { get; set; }
        public string? Observacao { get; set; }
    }
  
}
