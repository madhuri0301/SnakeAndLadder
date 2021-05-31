using System;

namespace SnakeAndLadderGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Game");

            Game game = new Game();
            game.Play();
        }
    }
}
