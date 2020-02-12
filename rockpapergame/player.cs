using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpapergame
{
    class player
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


        public virtual void ReadGesutures(int choice1, int choice2)
        {
             
                  
            if (glist[choice1] == glist[choice2])
            {
                Console.WriteLine(" Round " + roundCounter);
                Console.WriteLine(" There was a tie !! " +
                    " Replay Round!!"); roundCounter++; Console.ReadLine();
            }
            else if (glist[choice1].name == "Rock" && glist[choice2].name == "Paper")
            {
                winCounter2++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 2 won this round!!  Score is now " +
                 " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2); Console.ReadLine();
            }

            else if (glist[choice1].name == "Rock" && glist[choice2].name == "Scissors")
            {
                winCounter1++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 1 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2); Console.ReadLine();
            }
            else if (glist[choice1].name == "Rock" && glist[choice2].name == "Lizard")
            {
                winCounter1++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 1 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2); Console.ReadLine();
            }
            else if (glist[choice1].name == "Rock" && glist[choice2].name == "Spock")
            {
                winCounter2++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 2 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2); Console.ReadLine();
            }
            else if (glist[choice1].name == "Paper" && glist[choice2].name == "Rock")
            {
                winCounter1++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 1 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2); Console.ReadLine();
            }
            else if (glist[choice1].name == "Paper" && glist[choice2].name == "Scissors")
            {
                winCounter2++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 2 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2);
                Console.ReadLine();
            }
            else if (glist[choice1].name == "Paper" && glist[choice2].name == "Lizard")
            {
                winCounter2++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 2 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2);
                Console.ReadLine();
            }
            else if (glist[choice1].name == "Paper" && glist[choice2].name == "Spock")
            {
                winCounter1++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 1 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2);
                Console.ReadLine();
            }
            else if (glist[choice1].name == "Scissors" && glist[choice2].name == "Spock")
            {
                winCounter1++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 1 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2);
                Console.ReadLine();
            }
            else if (glist[choice1].name == "Scissors" && glist[choice2].name == "Rock")
            {
                winCounter2++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 2 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2);
                Console.ReadLine();
            }
            else if (glist[choice1].name == "Scissors" && glist[choice2].name == "Paper")
            {
                winCounter1++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 1 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2);
                Console.ReadLine();
            }
            else if (glist[choice1].name == "Scissors" && glist[choice2].name == "Lizard")
            {
                winCounter1++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 1 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2);
                Console.ReadLine();
            }
            else if (glist[choice1].name == "Lizard" && glist[choice2].name == "Spock")
            {
                winCounter1++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 1 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2);
                Console.ReadLine();
            }
            else if (glist[choice1].name == "Lizard" && glist[choice2].name == "Rock")
            {
                winCounter2++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 2 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2);
                Console.ReadLine();
            }
            else if (glist[choice1].name == "Lizard" && glist[choice2].name == "Paper")
            {
                winCounter1++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 1 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2);
                Console.ReadLine();
            }
            else if (glist[choice1].name == "Lizard" && glist[choice2].name == "Scissors")
            {
                winCounter2++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 2 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2);
                Console.ReadLine();
            }
            else if (glist[choice1].name == "Spock" && glist[choice2].name == "Lizard")
            {
                winCounter2++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 2 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2);
                Console.ReadLine();
            }
            else if (glist[choice1].name == "Spock" && glist[choice2].name == "Rock")
            {
                winCounter1++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 1 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2);
                Console.ReadLine();
            }
            else if (glist[choice1].name == "Spock" && glist[choice2].name == "Paper")
            {
                winCounter2++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 2 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2);
                Console.ReadLine();
            }
            else if (glist[choice1].name == "Spock" && glist[choice2].name == "Scissor")
            {
                winCounter1++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 1 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2);
                Console.ReadLine();
            }

            


        }
        public virtual int PickAGesture()
        {
            Console.WriteLine(name + " Please choose an gesture to play Rock = 0 " +
            " Paper = 1 " +
               " Scissors = 2 " +
                 " Lizard = 3 " +
          " Spock = 4 ");
            string ans = Console.ReadLine().ToLower();
            if (ans == "1" || ans == "2" || ans == "3" || ans == "4" || ans == "0") { choice1 = int.Parse(ans); return choice1; }
            else { Console.WriteLine(" INCORRECT INPUT "); PickAGesture(); return choice1; }
        }



























        }
}
