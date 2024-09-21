using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Modelos
{
    public class Musica
    {
        public string? Nome { get; set; }
        public Banda? Artista { get;  }
        public int Duracao { get; set; }
        public bool Disponivel { get; set; }
        public Genero? Genero { get; set; }

        public Musica (Banda artista)
        {
            this.Artista = artista;
        }

        //Get com Lambda
        public string DescricaoResumida
        {
            get
            {
                return $"A música {Nome} pertence banda {Artista}";
            }
        }

        // Mesma ideia que em cima, porém escrito com menos linhas (Lambda);
        public string Descricao => $"Alguma descrição";


    }
}
