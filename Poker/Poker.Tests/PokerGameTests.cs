using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poker.Tests
{
   public class PokerGameTests
    {

        [Test]
        public void Caso1()
        {
            
            var game = new PokerGame();

            var jugador = new Jugador { Id = 1, Nombre = "Oscar" };

            game.RegistrarJugador(new Jugador { Id = 1, Nombre = "Oscar" });
            game.RegistrarJugador(new Jugador { Id = 2, Nombre = "Eduardo" });

            game.Lanzar(1); // jugada del jugador 1
            game.Lanzar(1); // jugada del jugador 1
            //game.Lanzar(1); // jugada del jugador 2
            //game.Lanzar(1); // jugada del jugador 2

            var numJugador1 = game.GetNumJugador(1);
            var numJugador2 = game.GetNumJugador(2);

            Assert.AreEqual(2, numJugador1);
            Assert.AreEqual(2, numJugador2);

        }

    }
}
