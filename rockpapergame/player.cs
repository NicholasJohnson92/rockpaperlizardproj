using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpapergame
{
   abstract class player
    {//member variables
        public string name;
        public string name2;
        public int winCounter1;
        public int winCounter2;
        public List<gestures> glist;

        public int choice1;
        public int choice2;
        public int roundCounter=1;
        //constructor


        public player() 
        {


            glist = new List<gestures>();
            glist.Add(new gestures("Rock"));
            glist.Add(new gestures("Paper"));
            glist.Add(new gestures("Scissors"));
            glist.Add(new gestures("Lizard"));
            glist.Add(new gestures("Spock"));


            winCounter1 = 0;
            winCounter2 = 0;
        
        
        
        
        
        
        
        
        }



        //member asbtract methods


        public abstract void PickAGesture();
            
        
        
        
        
        




















    }
}
