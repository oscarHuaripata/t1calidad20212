using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poker.Tests
{
    class PokerJuegoTests
    {

        [Test]
        public void Caso1() {

            var game = new PokerGame();

            var jugador = new Jugador { Id = 1, Nombre = "Oscar" };

            game.RegistrarJugador(new Jugador { Id = 1, Nombre = "Oscar" });
            game.RegistrarJugador(new Jugador { Id = 2, Nombre = "Eduardo" });

            game.Lanzar(1); // jugada del jugador 1
            game.Lanzar(1); // jugada del jugador 1
            

            var puntajeJugador1 = game.GetPuntajeJugador(1);
            var puntajeJugador2 = game.GetPuntajeJugador(2);

            Assert.AreEqual(2, puntajeJugador1);
            Assert.AreEqual(2, puntajeJugador2);


        }
    }
}
