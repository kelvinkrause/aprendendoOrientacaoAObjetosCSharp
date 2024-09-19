using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Modelos
{
    public class Album
    {
        private List<Musica> musicas = new List<Musica>();

        public string Nome { get; set; }
        public int DuracaoTotal => musicas.Sum(musicas => musicas.Duracao);
        // para cada musica na lista de musica, somar a duracao

        public void AdicionaMusica(Musica musica)
        {
            musicas.Add(musica);
        }

        
        public void ExibirMusicasDoAlbum()
        {
            Console.WriteLine($"********** {Nome} **********\n");
            foreach(var musicas in musicas)
            {
                Console.WriteLine("Musica: " + musicas.Nome);
            }
            Console.WriteLine($"\nPara ouvir este album você precisa de {DuracaoTotal} seguntos");
        }

    }
}
