using NUnit.Framework;


namespace Poker.Tests
{
    [TestFixture]
    public class PokerGameTests
    {

        [Test]
        public void Caso1()
        {
            
            var game = new PokerGame();

            var jugador = new Jugador { Id = 1, Nombre = "Oscar" };

            game.RegistrarJugador(new Jugador { Id = 1, Nombre = "Oscar" });
            game.RegistrarJugador(new Jugador { Id = 2, Nombre = "Eduardo" });

            game.Lanzar(1); 
            game.Lanzar(2); 
        

            var numeroJugador1 = game.GetNumeroJugador(1);
            var numeroJugador2 = game.GetNumeroJugador(2);
            var numeroJugador3 = game.GetNumeroJugador(1);
            var numeroJugador4 = game.GetNumeroJugador(2);
            var numeroJugador5 = game.GetNumeroJugador(2);

            Assert.AreEqual(2, numeroJugador1);
            Assert.AreEqual(2, numeroJugador2);

        }
        [Test]
        public void Caso2()
        {

            var game = new PokerGame();

            var jugador = new Jugador { Id = 1, Nombre = "Oscar" };

            game.RegistrarJugador(new Jugador { Id = 1, Nombre = "Oscar" });
            game.RegistrarJugador(new Jugador { Id = 2, Nombre = "Eduardo" });

            game.Lanzar(1);
            game.Lanzar(2);


            var numeroJugador1 = game.GetNumeroJugador(1);
            var numeroJugador2 = game.GetNumeroJugador(3);
            var numeroJugador3 = game.GetNumeroJugador(4);
            var numeroJugador4 = game.GetNumeroJugador(4);
            var numeroJugador5 = game.GetNumeroJugador(2);

            Assert.AreEqual(2, numeroJugador1);
            Assert.AreEqual(2, numeroJugador2);

        }
        [Test]
        public void Caso3()
        {

            var game = new PokerGame();

            var jugador = new Jugador { Id = 1, Nombre = "Oscar" };

            game.RegistrarJugador(new Jugador { Id = 1, Nombre = "Oscar" });
            game.RegistrarJugador(new Jugador { Id = 2, Nombre = "Eduardo" });

            game.Lanzar(1);
            game.Lanzar(2);

            var numeroJugador3 = game.GetNumeroJugador(1);
            var numeroJugador4 = game.GetNumeroJugador(2);
            var numeroJugador5 = game.GetNumeroJugador(2);
            var numeroJugador1 = game.GetNumeroJugador(1);
            var numeroJugador2 = game.GetNumeroJugador(2);

            Assert.AreEqual(2, numeroJugador1);
            Assert.AreEqual(2, numeroJugador2);

        }
        [Test]
        public void Caso4()
        {

            var game = new PokerGame();

            var jugador = new Jugador { Id = 1, Nombre = "Oscar" };

            game.RegistrarJugador(new Jugador { Id = 1, Nombre = "Oscar" });
            game.RegistrarJugador(new Jugador { Id = 2, Nombre = "Eduardo" });


            game.Lanzar(1);
            game.Lanzar(2);

            var numeroJugador3 = game.GetNumeroJugador(5);
            var numeroJugador4 = game.GetNumeroJugador(6);
            var numeroJugador5 = game.GetNumeroJugador(7);
            var numeroJugador1 = game.GetNumeroJugador(1);
            var numeroJugador2 = game.GetNumeroJugador(2);

            Assert.AreEqual(2, numeroJugador1);
            Assert.AreEqual(2, numeroJugador2);

        }
        [Test]
        public void Caso5()
        {

            var game = new PokerGame();

            var jugador = new Jugador { Id = 1, Nombre = "Oscar" };

            game.RegistrarJugador(new Jugador { Id = 1, Nombre = "Oscar" });
            game.RegistrarJugador(new Jugador { Id = 2, Nombre = "Eduardo" });

            game.Lanzar(1);
            game.Lanzar(2);


            var numeroJugador1 = game.GetNumeroJugador(1);
            var numeroJugador2 = game.GetNumeroJugador(2);
            var numeroJugador3 = game.GetNumeroJugador(10);
            var numeroJugador4 = game.GetNumeroJugador(12);
            var numeroJugador5 = game.GetNumeroJugador(3);

            Assert.AreEqual(2, numeroJugador1);
            Assert.AreEqual(2, numeroJugador2);

        }
        [Test]
        public void Caso6()
        {

            var game = new PokerGame();

            var jugador = new Jugador { Id = 1, Nombre = "Oscar" };

            game.RegistrarJugador(new Jugador { Id = 1, Nombre = "Oscar" });
            game.RegistrarJugador(new Jugador { Id = 2, Nombre = "Eduardo" });

            game.Lanzar(1);
            game.Lanzar(2);


            var numeroJugador1 = game.GetNumeroJugador(1);
            var numeroJugador2 = game.GetNumeroJugador(2);
            var numeroJugador3 = game.GetNumeroJugador(6);
            var numeroJugador4 = game.GetNumeroJugador(7);
            var numeroJugador5 = game.GetNumeroJugador(8);

            Assert.AreEqual(2, numeroJugador1);
            Assert.AreEqual(2, numeroJugador2);

        }
        [Test]
        public void Caso7()
        {

            var game = new PokerGame();

            var jugador = new Jugador { Id = 1, Nombre = "Oscar" };

            game.RegistrarJugador(new Jugador { Id = 1, Nombre = "Oscar" });
            game.RegistrarJugador(new Jugador { Id = 2, Nombre = "Eduardo" });

            game.Lanzar(1);
            game.Lanzar(2);


            var numeroJugador1 = game.GetNumeroJugador(1);
            var numeroJugador2 = game.GetNumeroJugador(1);
            var numeroJugador3 = game.GetNumeroJugador(1);
            var numeroJugador4 = game.GetNumeroJugador(2);
            var numeroJugador5 = game.GetNumeroJugador(2);

            Assert.AreEqual(2, numeroJugador1);
            Assert.AreEqual(2, numeroJugador2);

        }
        [Test]
        public void Caso8()
        {

            var game = new PokerGame();

            var jugador = new Jugador { Id = 1, Nombre = "Oscar" };

            game.RegistrarJugador(new Jugador { Id = 1, Nombre = "Oscar" });
            game.RegistrarJugador(new Jugador { Id = 2, Nombre = "Eduardo" });

            game.Lanzar(1);
            game.Lanzar(2);


            var numeroJugador1 = game.GetNumeroJugador(1);
            var numeroJugador2 = game.GetNumeroJugador(2);
            var numeroJugador3 = game.GetNumeroJugador(8);
            var numeroJugador4 = game.GetNumeroJugador(9);
            var numeroJugador5 = game.GetNumeroJugador(10);

            Assert.AreEqual(2, numeroJugador1);
            Assert.AreEqual(2, numeroJugador2);

        }
        [Test]
        public void Caso9()
        {

            var game = new PokerGame();

            var jugador = new Jugador { Id = 1, Nombre = "Oscar" };

            game.RegistrarJugador(new Jugador { Id = 1, Nombre = "Oscar" });
            game.RegistrarJugador(new Jugador { Id = 2, Nombre = "Eduardo" });

            game.Lanzar(1);
            game.Lanzar(2);


            var numeroJugador1 = game.GetNumeroJugador(1);
            var numeroJugador2 = game.GetNumeroJugador(2);
            var numeroJugador3 = game.GetNumeroJugador(10);
            var numeroJugador4 = game.GetNumeroJugador(12);
            var numeroJugador5 = game.GetNumeroJugador(12);

            Assert.AreEqual(2, numeroJugador1);
            Assert.AreEqual(2, numeroJugador2);

        }
        [Test]
        public void Caso11()
        {

            var game = new PokerGame();

            var jugador = new Jugador { Id = 1, Nombre = "Oscar" };

            game.RegistrarJugador(new Jugador { Id = 1, Nombre = "Oscar" });
            game.RegistrarJugador(new Jugador { Id = 2, Nombre = "Eduardo" });

            game.Lanzar(1);
            game.Lanzar(2);


            var numeroJugador1 = game.GetNumeroJugador(1);
            var numeroJugador2 = game.GetNumeroJugador(2);
            var numeroJugador3 = game.GetNumeroJugador(3);
            var numeroJugador4 = game.GetNumeroJugador(4);
            var numeroJugador5 = game.GetNumeroJugador(5);

            Assert.AreEqual(2, numeroJugador1);
            Assert.AreEqual(2, numeroJugador2);

        }

        [Test]
        public void Caso12()
        {

            var game = new PokerGame();

            var jugador = new Jugador { Id = 1, Nombre = "Oscar" };

            game.RegistrarJugador(new Jugador { Id = 1, Nombre = "Oscar" });
            game.RegistrarJugador(new Jugador { Id = 2, Nombre = "Eduardo" });

            game.Lanzar(1);
            game.Lanzar(2);


            var numeroJugador1 = game.GetNumeroJugador(1);
            var numeroJugador2 = game.GetNumeroJugador(8);
            var numeroJugador3 = game.GetNumeroJugador(9);
            var numeroJugador4 = game.GetNumeroJugador(12);
            var numeroJugador5 = game.GetNumeroJugador(12);

            Assert.AreEqual(2, numeroJugador1);
            Assert.AreEqual(2, numeroJugador2);

        }
        [Test]
        public void Caso13()
        {

            var game = new PokerGame();

            var jugador = new Jugador { Id = 1, Nombre = "Oscar" };

            game.RegistrarJugador(new Jugador { Id = 1, Nombre = "Oscar" });
            game.RegistrarJugador(new Jugador { Id = 2, Nombre = "Eduardo" });

            game.Lanzar(1);
            game.Lanzar(2);


            var numeroJugador1 = game.GetNumeroJugador(13);
            var numeroJugador2 = game.GetNumeroJugador(1);

            var numeroJugador3 = game.GetNumeroJugador(1);
            var numeroJugador4 = game.GetNumeroJugador(2);
            var numeroJugador5 = game.GetNumeroJugador(2);
            Assert.AreEqual(2, numeroJugador1);
            Assert.AreEqual(2, numeroJugador2);

        }
        [Test]
        public void Caso14()
        {

            var game = new PokerGame();

            var jugador = new Jugador { Id = 1, Nombre = "Oscar" };

            game.RegistrarJugador(new Jugador { Id = 1, Nombre = "Oscar" });
            game.RegistrarJugador(new Jugador { Id = 2, Nombre = "Eduardo" });

            game.Lanzar(1);
            game.Lanzar(2);


            var numeroJugador1 = game.GetNumeroJugador(13);
            var numeroJugador2 = game.GetNumeroJugador(12);
            var numeroJugador3 = game.GetNumeroJugador(11);
            var numeroJugador4 = game.GetNumeroJugador(10);
            var numeroJugador5 = game.GetNumeroJugador(9);

            Assert.AreEqual(2, numeroJugador1);
            Assert.AreEqual(2, numeroJugador2);

        }
        [Test]
        public void Caso15()
        {

            var game = new PokerGame();

            var jugador = new Jugador { Id = 1, Nombre = "Oscar" };

            game.RegistrarJugador(new Jugador { Id = 1, Nombre = "Oscar" });
            game.RegistrarJugador(new Jugador { Id = 2, Nombre = "Eduardo" });

            game.Lanzar(1);
            game.Lanzar(2);


            var numeroJugador1 = game.GetNumeroJugador(1);
            var numeroJugador2 = game.GetNumeroJugador(1);
            var numeroJugador3 = game.GetNumeroJugador(1);
            var numeroJugador4 = game.GetNumeroJugador(2);
            var numeroJugador5 = game.GetNumeroJugador(2);

            Assert.AreEqual(2, numeroJugador1);
            Assert.AreEqual(2, numeroJugador2);

        }
        [Test]
        public void Caso16()
        {

            var game = new PokerGame();

            var jugador = new Jugador { Id = 1, Nombre = "Oscar" };

            game.RegistrarJugador(new Jugador { Id = 1, Nombre = "Oscar" });
            game.RegistrarJugador(new Jugador { Id = 2, Nombre = "Eduardo" });

            game.Lanzar(1);
            game.Lanzar(2);


            var numeroJugador1 = game.GetNumeroJugador(1);
            var numeroJugador2 = game.GetNumeroJugador(6);
            var numeroJugador3 = game.GetNumeroJugador(7);
            var numeroJugador4 = game.GetNumeroJugador(8);
            var numeroJugador5 = game.GetNumeroJugador(8);

            Assert.AreEqual(2, numeroJugador1);
            Assert.AreEqual(2, numeroJugador2);

        }
        [Test]
        public void Caso17()
        {

            var game = new PokerGame();

            var jugador = new Jugador { Id = 1, Nombre = "Oscar" };

            game.RegistrarJugador(new Jugador { Id = 1, Nombre = "Oscar" });
            game.RegistrarJugador(new Jugador { Id = 2, Nombre = "Eduardo" });

            game.Lanzar(1);
            game.Lanzar(2);


            var numeroJugador1 = game.GetNumeroJugador(3);
            var numeroJugador2 = game.GetNumeroJugador(9);
            var numeroJugador3 = game.GetNumeroJugador(9);
            var numeroJugador4 = game.GetNumeroJugador(9);
            var numeroJugador5 = game.GetNumeroJugador(9);

            Assert.AreEqual(2, numeroJugador1);
            Assert.AreEqual(2, numeroJugador2);

        }
        [Test]
        public void Caso18()
        {

            var game = new PokerGame();

            var jugador = new Jugador { Id = 1, Nombre = "Oscar" };

            game.RegistrarJugador(new Jugador { Id = 1, Nombre = "Oscar" });
            game.RegistrarJugador(new Jugador { Id = 2, Nombre = "Eduardo" });

            game.Lanzar(1);
            game.Lanzar(2);


            var numeroJugador1 = game.GetNumeroJugador(3);
            var numeroJugador2 = game.GetNumeroJugador(4);
            var numeroJugador3 = game.GetNumeroJugador(5);
            var numeroJugador4 = game.GetNumeroJugador(6);
            var numeroJugador5 = game.GetNumeroJugador(7);

            Assert.AreEqual(2, numeroJugador1);
            Assert.AreEqual(2, numeroJugador2);

        }
        [Test]
        public void Caso19()
        {

            var game = new PokerGame();

            var jugador = new Jugador { Id = 1, Nombre = "Oscar" };

            game.RegistrarJugador(new Jugador { Id = 1, Nombre = "Oscar" });
            game.RegistrarJugador(new Jugador { Id = 2, Nombre = "Eduardo" });

            game.Lanzar(1);
            game.Lanzar(2);


            var numeroJugador1 = game.GetNumeroJugador(2);
            var numeroJugador2 = game.GetNumeroJugador(3);
            var numeroJugador3 = game.GetNumeroJugador(4);
            var numeroJugador4 = game.GetNumeroJugador(5);
            var numeroJugador5 = game.GetNumeroJugador(6);

            Assert.AreEqual(2, numeroJugador1);
            Assert.AreEqual(2, numeroJugador2);

        }
        [Test]
        public void Caso20()
        {

            var game = new PokerGame();

            var jugador = new Jugador { Id = 1, Nombre = "Oscar" };

            game.RegistrarJugador(new Jugador { Id = 1, Nombre = "Oscar" });
            game.RegistrarJugador(new Jugador { Id = 2, Nombre = "Eduardo" });

            game.Lanzar(1);
            game.Lanzar(2);


            var numeroJugador1 = game.GetNumeroJugador(1);
            var numeroJugador2 = game.GetNumeroJugador(3);
            var numeroJugador3 = game.GetNumeroJugador(1);
            var numeroJugador4 = game.GetNumeroJugador(2);
            var numeroJugador5 = game.GetNumeroJugador(2);

            Assert.AreEqual(2, numeroJugador1);
            Assert.AreEqual(2, numeroJugador2);

        }
        [Test]
        public void Caso21()
        {

            var game = new PokerGame();

            var jugador = new Jugador { Id = 1, Nombre = "Oscar" };

            game.RegistrarJugador(new Jugador { Id = 1, Nombre = "Oscar" });
            game.RegistrarJugador(new Jugador { Id = 2, Nombre = "Eduardo" });

            game.Lanzar(1);
            game.Lanzar(2);


            var numeroJugador1 = game.GetNumeroJugador(10);
            var numeroJugador2 = game.GetNumeroJugador(11);
            var numeroJugador3 = game.GetNumeroJugador(12);
            var numeroJugador4 = game.GetNumeroJugador(2);
            var numeroJugador5 = game.GetNumeroJugador(2);

            Assert.AreEqual(2, numeroJugador1);
            Assert.AreEqual(2, numeroJugador2);

        }
        [Test]
        public void Caso22()
        {

            var game = new PokerGame();

            var jugador = new Jugador { Id = 1, Nombre = "Oscar" };

            game.RegistrarJugador(new Jugador { Id = 1, Nombre = "Oscar" });
            game.RegistrarJugador(new Jugador { Id = 2, Nombre = "Eduardo" });

            game.Lanzar(1);
            game.Lanzar(2);


            var numeroJugador1 = game.GetNumeroJugador(1);
            var numeroJugador2 = game.GetNumeroJugador(2);
            var numeroJugador3 = game.GetNumeroJugador(1);
            var numeroJugador4 = game.GetNumeroJugador(2);
            var numeroJugador5 = game.GetNumeroJugador(2);

            Assert.AreEqual(2, numeroJugador1);
            Assert.AreEqual(2, numeroJugador2);

        }
        [Test]
        public void Caso23()
        {

            var game = new PokerGame();

            var jugador = new Jugador { Id = 1, Nombre = "Oscar" };

            game.RegistrarJugador(new Jugador { Id = 1, Nombre = "Oscar" });
            game.RegistrarJugador(new Jugador { Id = 2, Nombre = "Eduardo" });

            game.Lanzar(1);
            game.Lanzar(2);


            var numeroJugador1 = game.GetNumeroJugador(1);
            var numeroJugador2 = game.GetNumeroJugador(8);
            var numeroJugador3 = game.GetNumeroJugador(8);
            var numeroJugador4 = game.GetNumeroJugador(8);
            var numeroJugador5 = game.GetNumeroJugador(2);

            Assert.AreEqual(2, numeroJugador1);
            Assert.AreEqual(2, numeroJugador2);

        }
        [Test]
        public void Caso24()
        {

            var game = new PokerGame();

            var jugador = new Jugador { Id = 1, Nombre = "Oscar" };

            game.RegistrarJugador(new Jugador { Id = 1, Nombre = "Oscar" });
            game.RegistrarJugador(new Jugador { Id = 2, Nombre = "Eduardo" });

            game.Lanzar(1);
            game.Lanzar(2);


            var numeroJugador1 = game.GetNumeroJugador(10);
            var numeroJugador2 = game.GetNumeroJugador(10);
            var numeroJugador3 = game.GetNumeroJugador(10;
            var numeroJugador4 = game.GetNumeroJugador(2);
            var numeroJugador5 = game.GetNumeroJugador(2);

            Assert.AreEqual(2, numeroJugador1);
            Assert.AreEqual(2, numeroJugador2);

        }
        [Test]
        public void Caso25()
        {

            var game = new PokerGame();

            var jugador = new Jugador { Id = 1, Nombre = "Oscar" };

            game.RegistrarJugador(new Jugador { Id = 1, Nombre = "Oscar" });
            game.RegistrarJugador(new Jugador { Id = 2, Nombre = "Eduardo" });

            game.Lanzar(1);
            game.Lanzar(2);


            var numeroJugador1 = game.GetNumeroJugador(1);
            var numeroJugador2 = game.GetNumeroJugador(3);
            var numeroJugador3 = game.GetNumeroJugador(6);
            var numeroJugador4 = game.GetNumeroJugador(7);
            var numeroJugador5 = game.GetNumeroJugador(9);

            Assert.AreEqual(2, numeroJugador1);
            Assert.AreEqual(2, numeroJugador2);

        }
        [Test]
        public void Caso27()
        {

            var game = new PokerGame();

            var jugador = new Jugador { Id = 1, Nombre = "Oscar" };

            game.RegistrarJugador(new Jugador { Id = 1, Nombre = "Oscar" });
            game.RegistrarJugador(new Jugador { Id = 2, Nombre = "Eduardo" });

            game.Lanzar(1);
            game.Lanzar(2);


            var numeroJugador1 = game.GetNumeroJugador(11);
            var numeroJugador2 = game.GetNumeroJugador(12);
            var numeroJugador3 = game.GetNumeroJugador(3);
            var numeroJugador4 = game.GetNumeroJugador(3);
            var numeroJugador5 = game.GetNumeroJugador(2);

            Assert.AreEqual(2, numeroJugador1);
            Assert.AreEqual(2, numeroJugador2);

        }
        [Test]
        public void Caso26()
        {

            var game = new PokerGame();

            var jugador = new Jugador { Id = 1, Nombre = "Oscar" };

            game.RegistrarJugador(new Jugador { Id = 1, Nombre = "Oscar" });
            game.RegistrarJugador(new Jugador { Id = 2, Nombre = "Eduardo" });

            game.Lanzar(1);
            game.Lanzar(2);


            var numeroJugador1 = game.GetNumeroJugador(10);
            var numeroJugador2 = game.GetNumeroJugador(2);
            var numeroJugador3 = game.GetNumeroJugador(1);
            var numeroJugador4 = game.GetNumeroJugador(2);
            var numeroJugador5 = game.GetNumeroJugador(10);

            Assert.AreEqual(2, numeroJugador1);
            Assert.AreEqual(2, numeroJugador2);

        }
        public void Caso28()
        {

            var game = new PokerGame();

            var jugador = new Jugador { Id = 1, Nombre = "Oscar" };

            game.RegistrarJugador(new Jugador { Id = 1, Nombre = "Oscar" });
            game.RegistrarJugador(new Jugador { Id = 2, Nombre = "Eduardo" });

            game.Lanzar(1);
            game.Lanzar(2);


            var numeroJugador1 = game.GetNumeroJugador(10);
            var numeroJugador2 = game.GetNumeroJugador(2);
            var numeroJugador3 = game.GetNumeroJugador(2);
            var numeroJugador4 = game.GetNumeroJugador(2);
            var numeroJugador5 = game.GetNumeroJugador(1);

            Assert.AreEqual(2, numeroJugador1);
            Assert.AreEqual(2, numeroJugador2);

        }
        public void Caso29()
        {

            var game = new PokerGame();

            var jugador = new Jugador { Id = 1, Nombre = "Oscar" };

            game.RegistrarJugador(new Jugador { Id = 1, Nombre = "Oscar" });
            game.RegistrarJugador(new Jugador { Id = 2, Nombre = "Eduardo" });

            game.Lanzar(1);
            game.Lanzar(2);


            var numeroJugador1 = game.GetNumeroJugador(10);
            var numeroJugador2 = game.GetNumeroJugador(2);
            var numeroJugador3 = game.GetNumeroJugador(10);
            var numeroJugador4 = game.GetNumeroJugador(10);
            var numeroJugador5 = game.GetNumeroJugador(10);

            Assert.AreEqual(2, numeroJugador1);
            Assert.AreEqual(2, numeroJugador2);

        }
        public void Caso30()
        {

            var game = new PokerGame();

            var jugador = new Jugador { Id = 1, Nombre = "Oscar" };

            game.RegistrarJugador(new Jugador { Id = 1, Nombre = "Oscar" });
            game.RegistrarJugador(new Jugador { Id = 2, Nombre = "Eduardo" });

            game.Lanzar(1);
            game.Lanzar(2);


            var numeroJugador1 = game.GetNumeroJugador(9);
            var numeroJugador2 = game.GetNumeroJugador(9);
            var numeroJugador3 = game.GetNumeroJugador(9);
            var numeroJugador4 = game.GetNumeroJugador(9);
            var numeroJugador5 = game.GetNumeroJugador(1);

            Assert.AreEqual(2, numeroJugador1);
            Assert.AreEqual(2, numeroJugador2);

        }
        
        
    }
}
