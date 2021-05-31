using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadderGame
{
    public class Game
    {
        public void Play()
        {
            Console.WriteLine("Let's Play");
            int start = 0;

            Random random = new Random();
            int dice = random.Next(1, 7);  //dicerolled
            Console.WriteLine("The Number Is = " + dice);
        }
    }
}
