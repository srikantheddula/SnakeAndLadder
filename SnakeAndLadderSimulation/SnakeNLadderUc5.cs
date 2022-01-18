using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadderSimulation
{
    internal class SnakeNLadderUc5
    {
        public const int No_Play = 3;
        public const int Ladder = 2;
        public const int Snake = 1;
        
        public void Game()
        {
            int position = 1;
            int count = 0;
            Random random = new Random();

            while (position <= 100)
            {
                int dice = random.Next(1, 7);
                int options = random.Next(1, 4);
                Console.WriteLine("dice: {0} Options1: {1}", dice, options);

                if (position < 0)
                {
                    position = 0;
                }

                count++;

                switch (options)
                {
                    case No_Play:
                        position = position + 0;
                        Console.WriteLine("No moves");
                        break;

                    case Ladder:
                        position = position + dice;
                        Console.WriteLine("Player Climb");
                        break;

                    case Snake:
                        position = position - dice;
                        Console.WriteLine("Player Dies");
                        break;

                    default:
                        Console.WriteLine("wrong values");
                        break;
                }

                if (position > 100)
                {
                    position = position - dice;
                }
                else if (position == 100)
                {
                    break;
                }
            }
                Console.WriteLine("Game finished  "+ position);
                Console.WriteLine("Total Times played: " + count);
            
        }
    }
}
