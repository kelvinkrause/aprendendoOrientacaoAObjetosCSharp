using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Exercicios.IntegrandoClassesEDefinindoRelacionamentos.Modelos
{
    public class Restaurante
    {
        private Dictionary<int, Mesa> mesas = new Dictionary<int, Mesa>();
        private List<Cardapio> cardapios = new List<Cardapio>();

        public void CadastrarMesa(int numero, Mesa mesa) => mesas.Add(numero, mesa);
        public void CadastrarCardapio(Cardapio cardapio) => cardapios.Add(cardapio);


        public Restaurante()
        {
            Prato laMinuta = new Prato();
            laMinuta.Nome = "La Minuta";
            laMinuta.Ingredientes = "Arroz, Feijão, Ovo Frito, Salada, Bife, Batata-Frita.";
            Prato xisSalada = new Prato();
            xisSalada.Nome = "Xis Salada";
            xisSalada.Ingredientes = "Sem Descrição por enquanto.";

            Cardapio cardapio = new Cardapio();
            cardapio.CadastrarPratos(laMinuta);
            cardapio.CadastrarPratos(xisSalada);

            CadastrarCardapio(cardapio);

            ExibirOpcoesMenu();

        }

        void ExibirOpcoesMenu()
        {
            CabecalhoOpcoes(" MENU ", "C");
            Console.WriteLine("Digite 1 para Exibir o Cardápio");
            Console.WriteLine("Digite 2 para fazer um Pedido");
            Console.WriteLine("Digite 3 para ver meus Pedidos");
            Console.WriteLine("Digite 0 para Sair");
            CabecalhoOpcoes("", "R");
            Opcoes();
        }

        void Opcoes()
        {
            Console.Write("\nDigite sua opção: ");
            int opcao = int.Parse(Console.ReadLine()!);
     
            switch (opcao)
            {
                case 0: 
                    Console.WriteLine("BYE BYE!");
                    Console.Clear();
                    break;
                case 1: 
                    ExibirCardapio("");
                    break;
                case 2:
                    CriarPedido();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }


        void CriarPedido()
        {
            Console.Clear();
            CabecalhoOpcoes(" CRIAR PEDIDO ", "C");
            Console.Write("Informe o numero da sua mesa: ");
            int mesa = int.Parse(Console.ReadLine()!);
            Mesa novaMesa = new Mesa(mesa);
            CadastrarMesa(mesa, novaMesa);
            Console.Clear();
            CabecalhoOpcoes(" CRIAR PEDIDO ", "C");
            CabecalhoOpcoes($" MESA Nº {mesas[mesa].numero} ", "R");
            //ExibirCardapio("E"); // Exibe cardápio
            Console.Write("Digite o prato que deseja: ");
            string prato = Console.ReadLine()!;


        }

        void ExibirCardapio(string apenasExibir)
        {
            if(apenasExibir != "E") Console.Clear();
            CabecalhoOpcoes(" CARDAPIO ", "C");
            foreach(Cardapio cardapio in cardapios)
            {
                cardapio.ExibirCardápio();
            }
            CabecalhoOpcoes("", "R");

            if (apenasExibir != "E")
                Console.Write("Digite uma tecla para voltar para o menu principal");
                Console.ReadKey(true);
                Console.Clear();
                ExibirOpcoesMenu();
        }

        void CabecalhoOpcoes(string titulo, string opcaoCabecalhoOuRodape)
        {
            int tamanho;

            if (titulo.Length % 2 == 0)
                tamanho = 42;
            else
                tamanho = 41;

            if (opcaoCabecalhoOuRodape == "C")
            {
                Console.WriteLine(asteriscos(tamanho));
                Console.WriteLine(asteriscos((tamanho - titulo.Length) / 2) + titulo + asteriscos((tamanho - titulo.Length) / 2));
                Console.WriteLine(asteriscos(tamanho) + "\n");
            }
            else if (opcaoCabecalhoOuRodape == "R")
            {
                if (titulo != "")
                {
                    Console.WriteLine(asteriscos((tamanho - titulo.Length) / 2) + titulo + asteriscos((tamanho - titulo.Length) / 2));
                } else 
                { 
                    Console.WriteLine("\n" + asteriscos(tamanho));
                }
            }

            string asteriscos(int quantidade)
            {
                string asteriscos = "";
                for (int i = 0; i < quantidade; i++)
                {
                    asteriscos += "*";
                }
                return asteriscos;
            }
        }
    }
}
