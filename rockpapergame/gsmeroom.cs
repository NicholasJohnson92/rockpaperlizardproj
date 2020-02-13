using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpapergame
{
    class gsmeroom
    {


        player player1;
        player player2;
       int player1Score;
        int player2score;


        public gsmeroom()
        {
            StartGame();
            CharacterSelect();
            this.player1.winCounter1 = player1Score;
            this.player1.winCounter2 = player2score;
            
            
            while (player1.winCounter1<2&&player1.winCounter2<2) { int choice1 = player1.PickAGesture();Console.ReadLine();
                int choice2 = player2.PickAGesture();
                player1.ReadGesutures(choice1, choice2); ChooseAWinner();
            }

            
            











        }


        public void StartGame() { Console.WriteLine(" Welcome to Rock Paper Sciccors Lizard Spock!! ");
            Console.WriteLine(" These are the rules : Each Player picks a gesture to playing a best of three match!! ");
            Console.WriteLine(" Rock crushes Scissors ");
            Console.WriteLine(" Scissors cuts Paper ");
            Console.WriteLine(" Paper covers Rock ");
            Console.WriteLine(" Rock crushes Lizard ");
            Console.WriteLine(" Lizard poisons Spock ");
            Console.WriteLine(" Spock smashes Scissors ");
            Console.WriteLine(" Scissors decapitates Lizard ");
            Console.WriteLine(" Lizard eats Paper ");
            Console.WriteLine(" Paper disproves Spock ");
            Console.WriteLine(" Spock vaporizes Rock ");
            Console.ReadLine(); 
        }
        public void CharacterSelect()
        {
            Console.WriteLine(" Would you like to play?? (Y/N) ");
            string ans = Console.ReadLine().ToLower();
            switch (ans)
            {
                case "yes":
                case "y":
                case "yeah":
                    Console.WriteLine(" Excellent choice!! Would You like zero, one, or two players??");

                    string ans2 = Console.ReadLine().ToLower();
                    switch (ans2)
                    {
                        case "0":
                        case "zero":
                        case "oh":
                            player1 = new computer();
                            player2 = new computer();
                            break;

                        case "1":
                        case "one":
                            player1 = new human();
                            player2 = new computer(); break;
                        case "2":
                        case "two":
                            player1 = new human();
                            player2 = new human(); break;
                        default: Console.WriteLine(" There seems to some confusion please pick 1 or 2 players "); CharacterSelect(); break;
                    }
                    break;
                case "no":
                case "nope":
                case "n":
                    Console.WriteLine(" Fine then Goodbye "); EndGame(); break;
                default:
                    Console.WriteLine(" There seems to some confusion please pick 1 or 2 players "); CharacterSelect();  while (player1.winCounter1<2&&player1.winCounter2<2) { int choice1 = player1.PickAGesture();Console.ReadLine();
                int choice2 = player2.PickAGesture();
                player1.ReadGesutures(choice1, choice2); ChooseAWinner();
            } break;
            }
        }


































        public void ChooseAWinner()
        {
            if (player1.winCounter1 < 2 && player1.winCounter2 < 2) { Console.WriteLine(" No Clear Winner !! Continue!! "); }
            else if (player1.winCounter1 >= 2 || player1.winCounter2 >= 2)
            {
                if (player1.winCounter1 >= 2)
                {
                    Console.WriteLine(player1.name + " Won!!! "); Console.ReadLine();
                }
                else if (player1.winCounter2 >= 2) { Console.WriteLine(player2.name + " Won !!! "); Console.ReadLine(); }
                Console.WriteLine(" Would You like to play again? (Y/N) ");
                string ans = Console.ReadLine().ToLower();
                switch (ans)
                {
                    case "yes":
                    case "y":
                    case "yeah":

                        StartGame(); CharacterSelect();
                        this.player1.winCounter1 = player1Score;
                        this.player1.winCounter2 = player2score; while (player1.winCounter1 < 2 && player1.winCounter2 < 2)
                        {
                            int choice1 = player1.PickAGesture(); Console.ReadLine();
                            int choice2 = player2.PickAGesture();
                            player1.ReadGesutures(choice1, choice2); ChooseAWinner();
                        }
                        break;


                    case "no":
                    case "nope":
                    case "n":
                        Console.WriteLine("Fine then Goodbye "); Console.ReadLine(); EndGame(); break;
                    default:
                        Console.WriteLine(" There seems to some confusion game will restart "); StartGame(); CharacterSelect();
                        this.player1.winCounter1 = player1Score;
                        this.player1.winCounter2 = player2score; while (player1.winCounter1 < 2 && player1.winCounter2 < 2)
                        {
                            int choice1 = player1.PickAGesture(); Console.ReadLine();
                            int choice2 = player2.PickAGesture();
                            player1.ReadGesutures(choice1, choice2); ChooseAWinner();
                        }
                        break;
                }
            }
           
            
           
        } 
        public void EndGame() { Environment.Exit(0); }

























            
        
        
        








    }
}
