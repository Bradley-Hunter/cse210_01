/*
Assignment: Unit 01 Prove: Developer
Author(s): Bradley Hunter
*/

using System;
using System.Collections.Generic;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> board = new List<char>(){
                '1', '2', '3', '4', '5', '6', '7', '8', '9'
            };

            drawBoard(board);

            char playerTurn = 'x';
            bool done = false;
            bool draw = false;
            while (!done && !draw)
            {
                Console.Write($"\n{playerTurn}'s turn to choose a square (1-9): ");
                string choice = Console.ReadLine();
                int square = int.Parse(choice);      
                if ((board[square - 1] == Convert.ToChar(choice)) && square >= 1 && square <= 9)
                {
                    updateBoard(board, square, playerTurn);
                    drawBoard(board);
                    done = checkWinStatus(board);
                    if (!done && board[0] != '1' && board[1] != '2' && 
                        board[2] != '3' && board[3] != '4' && board[4] != '5' && 
                        board[5] != '6' && board[6] != '7' && board[7] != '8' && 
                        board[8] != '9')
                            {
                                draw = true;
                            }
                    else if (!done && playerTurn == 'x')
                    {
                        playerTurn = 'o';
                    }
                    else if (playerTurn == 'o' && !done)
                    {
                        playerTurn = 'x';
                    }
                
                }
                else
                {
                    Console.WriteLine("Choose a valid square.");
                }
            }
            if (!draw)
            {
                Console.WriteLine($"\n{playerTurn} Wins!!!\n\n\n");
            }
            else if (draw)
            {
                Console.WriteLine("\nThere was a draw.\n\n\n");
            }
            
        }

        static bool checkWinStatus(List<char> board)
        {
            bool win = false;
            if (board[0] == board[1] && board[1] == board[2] || 
                board[0] == board[3] && board[3] == board[6] || 
                board[0] == board[4] && board[4] == board[8] ||
                board[1] == board[4] && board[4] == board[7] ||
                board[2] == board[5] && board[5] == board[8] ||
                board[2] == board[4] && board[4] == board[6] ||
                board[3] == board[4] && board[4] == board[5] ||
                board[6] == board[7] && board[7] == board[8])
                {
                    win = true;
                }

            return win;
        }
        static void updateBoard(List<char> board, int userSquare, char playerTurn)
        {
            board[userSquare - 1] = playerTurn;
        }

        static void drawBoard(List<char> board)
        {
            Console.WriteLine($"\n{board[0]}|{board[1]}|{board[2]}\n" +
                $"-+-+-\n{board[3]}|{board[4]}|{board[5]}\n" +
                $"-+-+-\n{board[6]}|{board[7]}|{board[8]}");
        }


    }
}