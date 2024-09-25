namespace ScreenSound.Modelos
{
    public class Podcast
    {
        public string Host { get; }
        public string Nome { get; }
        public int TotalEpisodios => episodios.Count;
        private List<Episodio> episodios = new List<Episodio>();


        public Podcast(string host, string nome)
        {
            Host = host;
            Nome = nome;
        }

        public void AdicionarEpisodios(Episodio episodio)
        {
            episodios.Add(episodio);
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Podcast {Nome} apresentado por {Host}");
            episodios.OrderBy(episodio => episodio.Ordem)
                .ToList()
                .ForEach(episodio => Console.WriteLine($"{episodio.Resumo}"));
            Console.WriteLine($"Esse Podcast posssui {this.TotalEpisodios} episódios.");
        }


    }
}