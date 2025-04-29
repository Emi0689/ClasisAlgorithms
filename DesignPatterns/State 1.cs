using System;

namespace DesignPatterns.State1
{
    //El patrón State permite que un objeto cambie su comportamiento cuando su estado interno cambia.
    //El objeto parecerá cambiar su clase.
    //Es muy útil para evitar múltiples if o switch basados en estados.

    public interface IPlayerState
    {
        void Play(Player player);
        void Pause(Player player);
        void Stop(Player player);
    }

    public class PlayingState : IPlayerState
    {
        public void Play(Player player)
        {
            Console.WriteLine("Ya está reproduciendo.");
        }

        public void Pause(Player player)
        {
            Console.WriteLine("Pausando reproducción...");
            player.SetState(new PausedState());
        }

        public void Stop(Player player)
        {
            Console.WriteLine("Deteniendo reproducción...");
            player.SetState(new StoppedState());
        }
    }

    public class PausedState : IPlayerState
    {
        public void Play(Player player)
        {
            Console.WriteLine("Reanudando reproducción...");
            player.SetState(new PlayingState());
        }

        public void Pause(Player player)
        {
            Console.WriteLine("Ya está pausado.");
        }

        public void Stop(Player player)
        {
            Console.WriteLine("Deteniendo desde pausa...");
            player.SetState(new StoppedState());
        }
    }

    public class StoppedState : IPlayerState
    {
        public void Play(Player player)
        {
            Console.WriteLine("Iniciando reproducción...");
            player.SetState(new PlayingState());
        }

        public void Pause(Player player)
        {
            Console.WriteLine("No puedes pausar. Está detenido.");
        }

        public void Stop(Player player)
        {
            Console.WriteLine("Ya está detenido.");
        }
    }

    public class Player
    {
        private IPlayerState _state;

        public Player()
        {
            _state = new StoppedState(); // Initial state
        }

        public void SetState(IPlayerState state)
        {
            _state = state;
        }

        public void Play()
        {
            _state.Play(this);
        }

        public void Pause()
        {
            _state.Pause(this);
        }

        public void Stop()
        {
            _state.Stop(this);
        }
    }

    class ProgramState1
    {
        static void Main(string[] args)
        {
            var player = new Player();

            player.Play();   // Iniciando reproducción...
            player.Pause();  // Pausando reproducción...
            player.Play();   // Reanudando reproducción...
            player.Stop();   // Deteniendo reproducción...
            player.Pause();  // No puedes pausar. Está detenido.
        }
    }
}
