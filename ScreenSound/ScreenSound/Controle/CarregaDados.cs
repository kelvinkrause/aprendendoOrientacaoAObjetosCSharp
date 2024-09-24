using ScreenSound.Modelos;

namespace ScreenSound.Controle
{
    public class CarregaDados
    {

        List<Banda> listaDeBandas = new List<Banda>();

        public CarregaDados()
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

            Musica prey = new Musica(bandaTheNeighbourhood, "Prey")
            {
                Duracao = 300,
                Disponivel = true
            };

            Musica cryBaby = new Musica(bandaTheNeighbourhood, "Cry Baby");
            Musica theBeach = new Musica(bandaTheNeighbourhood, "The Beach");

            Album albumHighVoltageACDC = new Album("High Voltage");
            Album albumILoveYouTNeigh = new Album("I Love You.");
            Album albumWipedOutTNeigh = new Album("Wiped Out!");

            albumHighVoltageACDC.AdicionaMusica(tnt);
            albumHighVoltageACDC.AdicionaMusica(highVoltage);

            albumILoveYouTNeigh.AdicionaMusica(sweaterWeather);
            albumILoveYouTNeigh.AdicionaMusica(afraid);

            albumWipedOutTNeigh.AdicionaMusica(afraid);
            albumWipedOutTNeigh.AdicionaMusica(cryBaby);
            albumWipedOutTNeigh.AdicionaMusica(theBeach);

            bandaACDC.AdicionarAlbuns(albumHighVoltageACDC);
            bandaTheNeighbourhood.AdicionarAlbuns(albumILoveYouTNeigh);
            bandaTheNeighbourhood.AdicionarAlbuns(albumWipedOutTNeigh);

            listaDeBandas.Add(bandaACDC);
            listaDeBandas.Add(bandaTheNeighbourhood);
        }

        public List<Banda> ListaDeBandas() { return listaDeBandas; }
        
    }
}