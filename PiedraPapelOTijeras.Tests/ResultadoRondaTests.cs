using PiedraPapelOTijeras.Dominio;

namespace PiedraPapelOTijeras.Tests
{
    public class ResultadoRondaTests
    {
        private readonly Jugador _jugador1;
        private readonly Jugador _jugador2;

        public ResultadoRondaTests()
        {
            _jugador1 = new Jugador("Jugador1");
            _jugador2 = new Jugador("Jugador2");
        }

        [Fact]
        public void PiedraDeberiaGanarleALatijera()
        {
            //arrange
            ResultadoRonda resultado = new ResultadoRonda(_jugador1, Juego.Jugada.Piedra, _jugador2, Juego.Jugada.Tijeras);

            //act y assert
            if (resultado.Ganador != _jugador1) throw new Exception("La piedra debería ganarle a tijera");
        }

        [Fact]
        public void TijeraPierdeConPiedra()
        {
            //arrange
            ResultadoRonda resultado = new ResultadoRonda(_jugador1, Juego.Jugada.Tijeras, _jugador2, Juego.Jugada.Piedra);

            //act y assert
            if (resultado.Ganador != _jugador2) throw new Exception("La tijera debería perder con la piedra");
        }

        [Fact]
        public void PapelLeGanaAPiedra()
        {
            //arrange
            ResultadoRonda resultado = new ResultadoRonda(_jugador1, Juego.Jugada.Papel, _jugador2, Juego.Jugada.Piedra);

            //act y assert
            if (resultado.Ganador != _jugador1) throw new Exception("Papel le tiene que ganar a la piedra");
        }

        [Fact]
        public void PiedraPierdeConPapel()
        {
            //arrange
            ResultadoRonda resultado = new ResultadoRonda(_jugador1, Juego.Jugada.Piedra, _jugador2, Juego.Jugada.Papel);

            //act y assert
            if (resultado.Ganador != _jugador2) throw new Exception("La piedra debería perder con el papel");
        }

        [Fact]
        public void SiJuegaLoMismoDaEmpate()
        {
            //arrange
            ResultadoRonda resultado = new ResultadoRonda(_jugador1, Juego.Jugada.Piedra, _jugador2, Juego.Jugada.Piedra);

            //act y assert
            if (!resultado.EsEmpate) throw new Exception("Si ls jugadores hacen la misma jugada deberia dar empate");
        }

        [Fact]
        public void TijeraDeberiaGanarleAPapel()
        {
            //arrange
            ResultadoRonda resultado = new ResultadoRonda(_jugador1, Juego.Jugada.Tijeras, _jugador2, Juego.Jugada.Papel);

            //act y assert
            if (resultado.Ganador != _jugador1) throw new Exception("Tijera debería ganarle al papel");
        }
    }
}