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
        public override void PickAGesture()
        {
            Console.WriteLine(" Please choose an gesture to play Rock = 0 " +
                " Paper = 1 " +
                " Scissors = 2 " +
                " Lizard = 3 " +
                " Spock = 4 ");
            choice1 = int.Parse(Console.ReadLine());

            if (glist[choice1] == glist[choice2])
            {
                Console.WriteLine(" Round " + roundCounter);
                Console.WriteLine(" There was a tie !! " +
                    " Replay Round!!"); roundCounter++; Console.ReadLine();
            }
            if (glist[choice1].name == "Rock" && glist[choice2].name == "Paper")
            {
                winCounter2++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 2 won this round!!  Score is now " +
" Player 1 : " + winCounter1 + " Player 2 : " + winCounter2); Console.ReadLine();
            }

            if (glist[choice1].name == "Rock" && glist[choice2].name == "Scissors")
            {
                winCounter1++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 1 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2); Console.ReadLine();
            }
            if (glist[choice1].name == "Rock" && glist[choice2].name == "Lizard")
            {
                winCounter1++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 1 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2); Console.ReadLine();
            }
            if (glist[choice1].name == "Rock" && glist[choice2].name == "Spock")
            {
                winCounter2++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 2 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2); Console.ReadLine();
            }
            if (glist[choice1].name == "Paper" && glist[choice2].name == "Rock")
            {
                winCounter1++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 1 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2); Console.ReadLine();
            }
            if (glist[choice1].name == "Paper" && glist[choice2].name == "Scissors")
            {
                winCounter2++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 2 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2);
                Console.ReadLine();
            }
            if (glist[choice1].name == "Paper" && glist[choice2].name == "Lizard")
            {
                winCounter2++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 2 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2);
                Console.ReadLine();
            }
            if (glist[choice1].name == "Paper" && glist[choice2].name == "Spock")
            {
                winCounter1++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 1 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2);
                Console.ReadLine();
            }
            if (glist[choice1].name == "Scissors" && glist[choice2].name == "Spock")
            {
                winCounter1++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 1 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2);
                Console.ReadLine();
            }
            if (glist[choice1].name == "Scissors" && glist[choice2].name == "Rock")
            {
                winCounter2++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 2 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2);
                Console.ReadLine();
            }
            if (glist[choice1].name == "Scissors" && glist[choice2].name == "Paper")
            {
                winCounter1++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 1 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2);
                Console.ReadLine();
            }
            if (glist[choice1].name == "Scissors" && glist[choice2].name == "Lizard")
            {
                winCounter1++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 1 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2);
                Console.ReadLine();
            }
            if (glist[choice1].name == "Lizard" && glist[choice2].name == "Spock")
            {
                winCounter1++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 1 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2);
                Console.ReadLine();
            }
            if (glist[choice1].name == "Lizard" && glist[choice2].name == "Rock")
            {
                winCounter2++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 2 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2);
                Console.ReadLine();
            }
            if (glist[choice1].name == "Lizard" && glist[choice2].name == "Paper")
            {
                winCounter1++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 1 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2);
                Console.ReadLine();
            }
            if (glist[choice1].name == "Lizard" && glist[choice2].name == "Scissors")
            {
                winCounter2++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 2 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2);
                Console.ReadLine();
            }
            if (glist[choice1].name == "Spock" && glist[choice2].name == "Lizard")
            {
                winCounter2++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 2 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2);
                Console.ReadLine();
            }
            if (glist[choice1].name == "Spock" && glist[choice2].name == "Rock")
            {
                winCounter1++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 1 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2);
                Console.ReadLine();
            }
            if (glist[choice1].name == "Spock" && glist[choice2].name == "Paper")
            {
                winCounter2++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 2 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2);
                Console.ReadLine();
            }
            if (glist[choice1].name == "Spock" && glist[choice2].name == "Scissor")
            {
                winCounter1++; Console.WriteLine(" Player 1 played " + choice1 + " Player 2 chose " + choice2 + " Player 1 won this round!!  Score is now " +
                  " Player 1 : " + winCounter1 + " Player 2 : " + winCounter2);
                Console.ReadLine();

            }
        }
    }
}

