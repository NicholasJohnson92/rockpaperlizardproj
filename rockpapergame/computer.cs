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
            name = "Hal";
            Console.WriteLine( name+ " chose to play " + compchoice);
            return compchoice;

        }
    }
}

