using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadderSimulation
{

    internal class SnakeNLadderUc3
    {
        public const int No_Play = 1;
        public const int Ladder = 2;
        public const int Snake = 3;
        public void Game()
        {
            int position = 0;
            Random random = new Random();
            

             int dice = random.Next(1, 7);
             int options = random.Next(1, 4);
             Console.WriteLine("dice: {0} Options1: {1}", dice, options);
      
                switch (options)
                {
                    case No_Play:
                        position = position + 0;
                        Console.WriteLine("No play");
                        break;

                    case Ladder:
                        position = position + dice;
                        Console.WriteLine("Player Climes");
                        break;

                    case Snake:
                        position = position - dice;
                        Console.WriteLine("Player Dies");
                        break;

                    default:
                        Console.WriteLine("wrong values");
                        break;
                }

            Console.WriteLine("position of player"+position);
           
        }
    }
}
