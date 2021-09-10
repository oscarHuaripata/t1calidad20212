using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker
{

    public class Jugador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int TotalJugador { get; set; }
    }

    public class Lanzamiento
    {
        public int Cartas { get; set; }
        public int JugadorId { get; set; }
    }

    public class PokerGame
    {
        private List<Jugador> Jugadores = new List<Jugador>();
        private List<Lanzamiento> Lanzamientos = new List<Lanzamiento>();
        private int turno = 0;

        public object GetNumeroJugador(int v)
        {
            throw new NotImplementedException();
        }

        public void Lanzar(int v)
        {
            Lanzamientos.Add(new Lanzamiento { Cartas = v, JugadorId = Jugadores.ElementAt(turno).Id });
        }

        public int[] GetNumeroJugadores()
        {
            throw new NotImplementedException();
        }

        public void RegistrarJugador(Jugador jugador)
        {
            Jugadores.Add(jugador);
        }
    }
}
    





