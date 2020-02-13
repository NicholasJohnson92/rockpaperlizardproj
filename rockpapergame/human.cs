using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpapergame
{
    class human : player
    {
        
        public string ans2;
      

        public human()
        {
            Console.WriteLine(" Choose a name for your player ");
            
            name = Console.ReadLine().ToUpper();
            
          



          
           





        }
        public override int PickAGesture()
        {
            Console.WriteLine(name+ " Please choose an gesture to play Rock = 0 " +
                " Paper = 1 " +
                " Scissors = 2 " +
                " Lizard = 3 " +
                " Spock = 4 "); 
           string ans = Console.ReadLine().ToLower() ;
            if (ans == "1" || ans == "2" || ans == "3" || ans == "4" ||ans=="0") { choice1 = int.Parse(ans); return choice1 ; }
            else { Console.WriteLine(" INCORRECT INPUT "); PickAGesture(); return choice1; }

            



           
           












        }


    }
}
