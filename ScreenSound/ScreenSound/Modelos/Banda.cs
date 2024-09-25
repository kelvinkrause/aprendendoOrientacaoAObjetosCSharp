namespace ScreenSound.Modelos
{
    public class Banda
    {
        List<Album> albunsBanda = new List<Album>();
        public string? Nome { get; }
    
        public Banda(string nome)
        {
            this.Nome = nome;
        }

        public void AdicionarAlbuns(Album album)
        {
            albunsBanda.Add(album);
        }

        public List<Album> ExibirAlbuns()
        {
            return albunsBanda;
        }

    }
}