using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    class Game
    {
        //Initialize the board.
        public void Initialize(char[,] board)
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = (char)(count++ + '0');
                }
            }
        }

        
        /// Displays the specified board.
        public void Display(char[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" " + board[i, j]);
                }

                Console.WriteLine();
            }
        }

        
        /// Replaces the specified element of board.
        public bool Replace(char[,] board, char choice, char player1)
        {
            bool valid = false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == choice)
                    {
                        board[i, j] = player1;
                        valid = true;
                        return valid;
                    }
                }
            }

            return valid;
        }

       
        /// checks the win.
         public bool WinCheck(char[,] board)
        {
            Game game = new Game();
            return game.CheckRow(board) || game.CheckColumn(board) || game.CheckDiagonal(board);
        }

       
        /// Checks the row.
        public bool CheckRow(char[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    return true;
                }
            }

            return false;
        }

        
        /// Checks the column.
        public bool CheckColumn(char[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                {
                    return true;
                }
            }

            return false;
        }

   
        /// Checks the diagonal.
        public bool CheckDiagonal(char[,] board)
        {
            if ((board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2]) || (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
    

