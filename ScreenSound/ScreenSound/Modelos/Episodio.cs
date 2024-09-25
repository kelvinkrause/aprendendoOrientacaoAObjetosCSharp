namespace ScreenSound.Modelos
{
    public class Episodio
    {


        public int Duracao { get; }
        public int Ordem { get; }
        public string Titulo { get; }
        public string Resumo => $"{Ordem}. {Titulo} ({Duracao}min)  - {string.Join(", ", convidados)}";
        private List<string> convidados = new List<string>();


        public Episodio(int ordem, int duracao, string titulo)
        {
            Ordem = ordem;
            Duracao = duracao;
            Titulo = titulo;
        }

        public void AdicionarConvidados(string convidado)
        {
            convidados.Add(convidado);
        }

    }
}