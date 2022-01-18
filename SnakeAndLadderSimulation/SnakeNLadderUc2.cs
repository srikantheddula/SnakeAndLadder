using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadderSimulation
{
    class SnakeNLadderUc2
    {
        int Position = 0;


        public void start()
        {

          Console.WriteLine("player at start position" + Position);
            Random random = new Random();
            int dice = random.Next(1, 7);
            Console.WriteLine("dice :" + dice);
            
        }

    }
    
 }
