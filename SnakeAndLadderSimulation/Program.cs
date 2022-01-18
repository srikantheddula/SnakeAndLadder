using System;
using System.Collections.Generic;

namespace SnakeAndLadderSimulation
{
    class Program
    {

        const int board = 25;

        public static void Main(string[] args)
        {
            int i = 1;
            int stepsMoved = 0;
            string player = "player1";

            Random randomNumber = new Random();
            while (i < board && stepsMoved<=25)
            {
                int die = randomNumber.Next(1, 7);
                i++;

                switch (die)
                {
                    case 1:

                        Console.WriteLine("player:" + player + "\tRolled" + "\tdie1 " + i);
                        stepsMoved += 1;
                        break;
                    case 2:

                        Console.WriteLine("player:" + player + "\tRolled" + "\tdie2 " + i);

                        stepsMoved += 2;
                        break;
                    case 3:

                        Console.WriteLine("player:" + player + "\tRolled" + "\tdie3 " + i);

                        stepsMoved += 3;
                        break;
                    case 4:

                        Console.WriteLine("player:" + player + "\tRolled" + "\tdie4 " + i);
                        stepsMoved += 4;
                        break;
                    case 5:

                        Console.WriteLine("player:" + player + "\tRolled" + "\tdie5 " + i);
                        stepsMoved += 5;
                        break;
                    case 6:

                        Console.WriteLine("player:" + player + "\tRolled" + "\tdie6 " + i);
                        stepsMoved += 6;
                        break;
                    default:

                        Console.WriteLine("player :" + player + " rolled " + "something went wrong" + i);

                        break;
                }

                Console.WriteLine("player :" + player + " total steps: " + stepsMoved);
                


            }


            Console.WriteLine(player+"won");
        }
    }
}
                
                

            
