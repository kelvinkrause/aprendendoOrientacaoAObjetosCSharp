using ScreenSound.Exercicios.ClasseEMetodosCSharp.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Exercicios.IntegrandoClassesEDefinindoRelacionamentos.Modelos
{
    public class EstoqueProdutos
    {
        private List<Produto> produtos = new List<Produto>();

        public void ExibirTodosProdutos()
        {
            Console.WriteLine("Produtos em Estoque");
            foreach (Produto produto in produtos){
                Console.WriteLine($"{produtos.IndexOf(produto) + 1}: {produto.Nome}, Quantidade: {produto.Estoque} ");
            }
        }

        public void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
        }

    }
}
