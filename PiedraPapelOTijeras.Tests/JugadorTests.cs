using PiedraPapelOTijeras.Dominio;

namespace PiedraPapelOTijeras.Tests
{
    public class JugadorTests
    {

        [Fact]

        public void NombreJugadorNoDebeEstarVacio()
        {
            // Arrange
            string nombreQueNoFunca = "";

            // Act y assert
            Exception exception = Assert.Throws<ArgumentException>(() => new Jugador(nombreQueNoFunca));


            Assert.Equal("El nombre del jugador no puede estar vacío (Parameter 'nombre')", exception.Message);
        }

        [Fact]

        public void IncrementarPuntajeAumentaEnUno()
        {
            // Arrange
            Jugador jugador = new Jugador("Ignacio");

            // Act
            jugador.IncrementarPuntaje();

            // Assert
            if (jugador.Puntaje != 1) throw new Exception("El puntaje debería ser 1 cuando incremento.");
        }
    }
}
