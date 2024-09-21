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

            Musica musica1 = new Musica(bandaACDC);
            musica1.Nome = "T.N.T.";
            musica1.Duracao = 210;
            musica1.Disponivel = true;

            Musica musica2 = new Musica(bandaACDC);
            musica2.Nome = "High Voltage";
            musica2.Duracao = 249;
            musica2.Disponivel = true;

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