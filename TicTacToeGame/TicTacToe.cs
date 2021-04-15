using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    class TicTacToe
    {
        
            public static void PlayGame()
            {
                //// initialize the variable
                int count = 0, intChoice;
               char choice, player1, player2;
                bool isWin = false;
                //// create 3*3 char multidimension array
                char[,] board = new char[3, 3];
                //// create random object 
                Random random = new Random();
                //// create game object
                Game game = new Game();

             Console.WriteLine("Player 1 is You!");
             Console.WriteLine("Player 2 is Computer");

            {
                    //// take input choice in char type
                    Console.WriteLine( " enter your choice 'x' or '0':");
                    player1 = Convert.ToChar(Console.ReadLine());
                }

                {
                    Console.WriteLine("Invalid Choice");
                }
                //// assign player's symbol to player
                if (player1 == 'X' || player1 == 'x')
                {
                    player2 = '0';
                }
                else
                {
                    player2 = 'X';
                }
                //// declare the array 
                game.Initialize(board);
                game.Display(board);
                //// do while loop for executing 1st iteration without any condition
                do
                 { 
                    {
                        Console.WriteLine("Now, select your choice:");
                        intChoice = Convert.ToChar(Console.ReadLine());
                    }

                    {
                        Console.WriteLine("Invalid Choice");
                    }

                    if (intChoice >= 48 && intChoice <= 56)
                    {
                        choice = Convert.ToChar(intChoice);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Choice");
                    }

                    bool valid = game.Replace(board, choice, player1);
                    if (!valid)
                    {
                        Console.WriteLine("Invalid Choice");
                    }

                    game.Display(board);

                    isWin = game.WinCheck(board);
                    if (isWin)
                    {
                        Console.Write("you won the game ");
                        break;
                    }

                    count++;
                    if (count == 5)
                    {
                        Console.WriteLine("****Draw****");
                        break;
                    }

                    Console.WriteLine("Computer's turn:");
                    int computerChoice = (int)random.Next(9);
                    Console.WriteLine(computerChoice);
                    char computerChoose = (char)(computerChoice + '0');
                    bool computerValid = game.Replace(board, computerChoose, player2);
                    if (!computerValid)
                    {
                        Console.WriteLine("Invalid Choice");
 
                    }

                    game.Display(board);
                    isWin = game.WinCheck(board);
                    if (isWin)
                    {
                        Console.Write("Computer won the game");
                        break;
                    }
                }
                while (isWin == false || count < 5);
                Console.ReadKey();
            }
        }
    }

