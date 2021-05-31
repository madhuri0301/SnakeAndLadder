using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadderGame
{
    public class Game
    {
        const int NO_PLAY = 0;
        const int SNAKE = 1;
        const int LADDER = 2;
        public void Play()
        {
            Console.WriteLine("Let's Play");
            int start = 0;
            int win = 100;
            int count = 0;

            while (start < win)
            {

                Random random = new Random();
                int dice = random.Next(1, 7);  //dicerolled
                Console.WriteLine("The Number Is = " + dice);

                int check = random.Next(0, 3); //To Check it's Snake Or Ladder
                count++;
                switch (check)
                {
                    case NO_PLAY:
                        Console.WriteLine("No Play");
                        break;

                    //ladder
                    case LADDER:
                        Console.WriteLine("Heyy! You Found Ladder");
                        if (start + dice <= 100)
                            start = start + dice;
                        else
                            start = start + 0;
                        break;

                    //snake
                    case SNAKE:
                        Console.WriteLine("ohh No! Snake!");
                        start = start - dice;
                        if (start < 0)
                            start = 0;
                        break;

                    default:
                        break;
                }
                Console.WriteLine("You Are On Position " + start);
                dice = dice + 1;
            }
            Console.WriteLine("Congratulations! You Are Won!");
            Console.WriteLine("The Number Of Times Dice Played : " + count);
        }
    }
}
