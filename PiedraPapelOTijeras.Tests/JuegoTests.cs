using PiedraPapelOTijeras.Dominio;

namespace PiedraPapelOTijeras.Tests
{
    public class JuegoTests
    {
        private readonly Jugador _jugador1;
        private readonly Jugador _jugador2;

        public JuegoTests()
        {
            _jugador1 = new Jugador("Ana");
            _jugador2 = new Jugador("Luis");
        }
            
        [Theory]
        [InlineData(Juego.Jugada.Piedra, Juego.Jugada.Tijeras, "Ana")]

        public void ObtenerGanadorDevuelvealGanadorCrorrecto(Juego.Jugada jugada1, Juego.Jugada jugada2, string nombreGanadorEsperado)
        {
            // Arranges
            Juego juego = new Juego(_jugador1, _jugador2, 1); 

            // Act
            juego.JugarRonda(jugada1, jugada2);
            Jugador? ganador = juego.ObtenerGanador();

            // Assert
            if (ganador == null || ganador.Nombre != nombreGanadorEsperado) throw new Exception("El ganador no es el esperado.");
        }
    }

}
