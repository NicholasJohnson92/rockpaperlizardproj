using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpapergame
{
    class computer : player
    {





        public void AIPlayer() {
            Console.WriteLine();
        
        
        
        
        
        
        
        }

        public override int PickAGesture()
        { Random random = new Random();
            int compchoice = random.Next(0, 4);
           
            Console.WriteLine(" Computer chose to play " + compchoice);
            return compchoice;

        }
    }
}

