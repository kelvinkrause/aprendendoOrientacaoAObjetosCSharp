using System.Collections;
using System.Diagnostics;
using ScreenSound.Modelos;

namespace ScreenSound.Controle
{
    public class MenuScreenSound
    {
        public MenuScreenSound()
        {
            Banda bandaACDC = new Banda("AC/DC");

            Musica tnt = new Musica(bandaACDC, "T.N.T.")
            {
                Duracao = 210,
                Disponivel = true
            };

            Musica highVoltage = new Musica(bandaACDC, "High Voltage")
            {
                Duracao = 249,
                Disponivel = true
            };

            Banda bandaTheNeighbourhood = new Banda("The Neighbourhood");

            Musica sweaterWeather = new Musica(bandaTheNeighbourhood, "Sweater Wheater")
            {
                Duracao = 240,
                Disponivel = true
            };

            Musica afraid = new Musica(bandaTheNeighbourhood, "Afraid")
            {
                Duracao = 276,
                Disponivel = true
            };

            //Console.WriteLine(musica1.DescricaoResumida);
            //Console.WriteLine(musica2.DescricaoResumida);

            Album albumDoACDC = new Album("High Voltage");
            Album albumDoTheNeighbourhood = new Album("I Love You");

            albumDoACDC.AdicionaMusica(tnt);
            albumDoACDC.AdicionaMusica(highVoltage);

            albumDoTheNeighbourhood.AdicionaMusica(sweaterWeather);
            albumDoTheNeighbourhood.AdicionaMusica(afraid);

            //albumDoACDC.ExibirMusicasDoAlbum();

            bandaACDC.AdicionarAlbuns(albumDoACDC);
            bandaTheNeighbourhood.AdicionarAlbuns(albumDoTheNeighbourhood);

            //bandaACDC.ExibirAlbuns();

            OpcoesMenu();

        }

        public void OpcoesMenu()
        {
            Console.WriteLine("Digite 1 para ver as bandas disponíveis do Screen Sound");
            Console.WriteLine("Digite 2 para criar uma criar uma playlist");
            //Console.WriteLine("");
            //Console.WriteLine("");
            Console.WriteLine("Digite 0 para sair");
            Opcoes();
        }

        public void Opcoes()
        {
            int opcao = int.Parse(Console.ReadLine()!);
            switch (opcao)
            {
                case 0: 
                    Console.WriteLine("Saindooo...");
                    Thread.Sleep(200);
                    Console.Clear();
                    break;
                case 1: 
                    Console.WriteLine("Opcao 1");
                    break;
                case 2: 
                    Console.WriteLine("Opção 2");
                    break;
                default: 
                    Console.WriteLine("Opção desconhecida");
                    break;
             
            }
        }

    }
}