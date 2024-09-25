using ScreenSound.Modelos;

namespace ScreenSound
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            //new MainExercicios();
            //new FuncoesLambdas();
            //new MenuScreenSound();


            Episodio episodio1 = new Episodio(1, 60, "Piloto");
            episodio1.AdicionarConvidados("Giovana");
            episodio1.AdicionarConvidados("Martina");
            Episodio episodio2 = new Episodio(2, 120, "Dia-a-Dia");
            episodio2.AdicionarConvidados("Lourdes");
            episodio2.AdicionarConvidados("Cesar");
            Episodio episodio3 = new Episodio(3, 240, "Weekend");
            episodio3.AdicionarConvidados("Family Born");

            Podcast podKa = new Podcast("Kelvin Krause", "PodeKaCast");

            podKa.AdicionarEpisodios(episodio3);
            podKa.AdicionarEpisodios(episodio1);
            podKa.AdicionarEpisodios(episodio2);

            podKa.ExibirDetalhes();


        }
    }
}