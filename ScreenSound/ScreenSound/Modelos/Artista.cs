using System.Linq.Expressions;

namespace ScreenSound.Modelos
{
    public class Artista
    {
        public string Nome { get; set; }
        public string? Biografia { get; set; }
        private List<Album> albums = new List<Album>();

        public Artista(string nome)
        {
            Nome = nome; 
        }

        public void AdicionarAlbum(Album album)
        {
            albums.Add(album);
        }    

        public void ExibirAlbuns()
        {
            string cabecalho = $"Albuns do Artista: {this.Nome}";

            Console.WriteLine(cabecalho);
            albums.ForEach(album => Console.WriteLine(album.Nome));
            for (int i = 0; i < cabecalho.Length; i++) Console.Write("*");

        }

    }
}