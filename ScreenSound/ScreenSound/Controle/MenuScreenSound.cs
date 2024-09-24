using System.Collections;
using System.Diagnostics;
using ScreenSound.Modelos;

namespace ScreenSound.Controle
{
    public class MenuScreenSound
    {

        private List<Banda> listaDeBandas = new List<Banda>();

        public MenuScreenSound()
        {

            listaDeBandas = new CarregaDados().ListaDeBandas();

            OpcoesMenu();

        }

         void OpcoesMenu()
        {
            Console.WriteLine("Digite 1 para ver as bandas disponíveis do Screen Sound");
            Console.WriteLine("Digite 2 para criar uma criar uma playlist");
            Console.WriteLine("Digite 0 para sair");
            Opcoes();
        }

         void Opcoes()
        {
            Console.Write("\nDigite sua opção: ");
            int opcao = int.Parse(Console.ReadLine()!);
            switch (opcao)
            {
                case 0: 
                    Console.Clear();
                    Console.WriteLine("Saindooo...");
                    Thread.Sleep(500);
                    Console.Clear();
                    break;
                case 1: 
                    ExibeBandas();
                    break;
                case 2: 
                    Console.WriteLine("Opção 2");
                    break;
                default: 
                    Console.WriteLine("Opção desconhecida");
                    break;
             
            }
        }

        void ExibeBandas()
        {
            Console.Clear();
            foreach (Banda banda in listaDeBandas)
            {
                Console.WriteLine($"Banda: {banda.Nome}");
                List<Album> albuns = banda.ExibirAlbuns();
                foreach (Album album in albuns)
                {
                    Console.WriteLine($"  Album: {album.Nome}");
                }
            }
            RetornoMenu();
        }

        void RetornoMenu()
        {
            Console.Write("\nTecle enter para voltar ao menu principal: ");
            Console.ReadKey(true);
            Console.Clear();
            OpcoesMenu();
        }

    }
}