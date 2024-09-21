using ScreenSound.Modelos;
using ScreenSound.Exercicios;
using ScreenSound.Exercicios.ClasseEMetodosCSharp;
using ScreenSound.Exercicios.IntegrandoClassesEDefinindoRelacionamentos.Modelos;
using ScreenSound.Exercicios.IntegrandoClassesEDefinindoRelacionamentos;

namespace ScreenSound
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //new MainExercicios();
            //new FuncoesLambdas();
            
            /**/

            Console.ReadKey(true);
            Console.Clear();

            Banda bandaACDC = new Banda("AC/DC");

            Musica musica1 = new Musica(bandaACDC, "T.N.T.")
            {
                Duracao = 210,
                Disponivel = true
            };

            Musica musica2 = new Musica(bandaACDC, "High Voltage")
            {
                Duracao = 249,
                Disponivel = true
            };

            Console.WriteLine(musica1.DescricaoResumida);
            Console.WriteLine(musica2.DescricaoResumida);

            Album albumDoACDC = new Album("High Voltage");

            albumDoACDC.AdicionaMusica(musica1);
            albumDoACDC.AdicionaMusica(musica2);

            albumDoACDC.ExibirMusicasDoAlbum();

            bandaACDC.AdicionarAlbuns(albumDoACDC);

            bandaACDC.ExibirAlbuns();
            
        }
    }

}