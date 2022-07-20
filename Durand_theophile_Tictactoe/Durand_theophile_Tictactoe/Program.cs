using System;
using System.Threading;
namespace Durand_Theophile_Tictactoe
{
    class Program
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1; 
        static int choice; 
        static int flag = 0;


       


        static void Main(string[] args)
        {
            Random rnd = new Random();
            do
            {
                Console.Clear();
                Console.WriteLine("Player:X and Computer:O");
                Console.WriteLine("\n");
                if (player % 2 == 0)
                {
                    Console.WriteLine("Computer Chance");
                }
                else
                {
                    Console.WriteLine("Player Chance");
                }
                Console.WriteLine("\n");
                Board();
                if (player % 2 == 0) //if chance is of player 2 then mark O else mark X
                {
                    Console.WriteLine("Computer Playing . . . .");
                    Thread.Sleep(1000);
                    choice = rnd.Next(1, 9);
                    Console.WriteLine("Computer choose {0}:",choice);
                    Thread.Sleep(1000);
               
                }
                else
                {
                    choice = int.Parse(Console.ReadLine());
                 
                }




                // I want to know if an a cell is already taken by a X or a 0
                // if the cell is available then we chane the value depending of the player
                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0) //if chance is of player 2 then mark O else mark X
                    {
                        arr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        
                        arr[choice] = 'X';
                        player++;
                    }
                }
                else
                //We need a "nope msg"
                {
                    if (player % 2 == 0) //if chance is of player 2 then mark O else mark X
                    {
                        Console.WriteLine("The computer need to recaculate.");
                        Thread.Sleep(2000);
                    }
                    else
                    {

                        Console.WriteLine("{0} is already marked with {1}", choice, arr[choice]);
                        Console.WriteLine("\n");
                        Console.WriteLine("Please select an other cell.");
                        Thread.Sleep(2000);
                    }
                   

                }
                flag = CheckWin(); // we need to check at each time if a player has win
            }
            while (flag != 1 && flag != -1);
            // This loop will be run until all cell of the grid is not marked
            //with X and O or some player is not win
            Console.Clear();// clearing the console
            Board();// getting filled board again
            if (flag == 1)
            // if flag value is 1 then someone has win or
            //means who played marked last time which has win
            {
                if (player % 2 == 0) //if chance is of player 2 then mark O else mark X
                {
                    Console.WriteLine("Computure has won , you are really bad");
                }
                else
                {

                    Console.WriteLine("Player has won");
                }
                
            }
            else// if flag value is -1 the match will be draw and no one is winner
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }
        // Board method which creats board
        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }
        //Checking that any player has won or not
        private static int CheckWin()
        {
            #region Horzontal Winning Condtion
            //I need to check every possibility
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }
            #endregion
            #region vertical Winning Condtion
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
        
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            #endregion
            #region Diagonal Winning Condition
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            #endregion
            #region Checking For Draw
            // We need to stop the match when ended
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            #endregion
            else
            {
                return 0;
            }
        }
    }
}