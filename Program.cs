/*
Assignment: Unit 01 Prove: Developer
Author(s): Bradley Hunter
*/

// Import the namepaces that are called.
using System;
using System.Collections.Generic;

// Naming the namespace.
namespace TicTacToe
{
    // Defining the intial class.
    internal class Program
    {
        // Defining the main function
        static void Main(string[] args)
        {
            // Initialize the game board as a list of characters.
            List<char> board = new List<char>(){
                '1', '2', '3', '4', '5', '6', '7', '8', '9'
            };

            // Call the drawBoard function to draw the board.
            drawBoard(board);

            // Initialize the record of players turn and the win and draw booleans.
            char playerTurn = 'x';
            bool win = false;
            bool draw = false;

            // Start a while loop for the Tic Tac Toe game.
            while (!win && !draw)
            {
                // Print a message to the screen and turn the message into an integer.
                Console.Write($"\n{playerTurn}'s turn to choose a square (1-9): ");
                string choice = Console.ReadLine();
                int square = int.Parse(choice);     
                
                // An if statement to check to see if the users input is a valid input.
                if ((board[square - 1] == Convert.ToChar(choice)) && square >= 1 && square <= 9)
                {
                    // Updates the board list through the function updateBoard.
                    updateBoard(board, square, playerTurn);

                    // Draws the board again.
                    drawBoard(board);

                    // Checks the win status and then changes the done boolean accordingly.
                    win = checkWinStatus(board);

                    // Checks for a draw.
                    if (!win && board[0] != '1' && board[1] != '2' && 
                        board[2] != '3' && board[3] != '4' && board[4] != '5' && 
                        board[5] != '6' && board[6] != '7' && board[7] != '8' && 
                        board[8] != '9')
                            {
                                draw = true;
                            }
                    
                    // Changes the playerTurn variable to o if it is x's turn.
                    else if (!win && playerTurn == 'x')
                    {
                        playerTurn = 'o';
                    }

                    // Changes the playerTurn variable to x if it is o's turn.
                    else if (playerTurn == 'o' && !win)
                    {
                        playerTurn = 'x';
                    }
                
                }

                // Prints a message if the user didn't choose a valid input.
                else
                {
                    Console.WriteLine("Choose a valid square.");
                }
            }

            // If there is no draw prints who won.
            if (!draw)
            {
                Console.WriteLine($"\n{playerTurn} Wins!!!\n\n\n");
            }

            // If there is a draw prints a draw message.
            else if (draw)
            {
                Console.WriteLine("\nThere was a draw.\n\n\n");
            }
            
        }

        // This function checks to see if a player has won.
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

        // This function updates the board list based on the current user's selection and whose turn it is.
        static void updateBoard(List<char> board, int userSquare, char playerTurn)
        {
            board[userSquare - 1] = playerTurn;
        }
        
        // This function draws the board.
        static void drawBoard(List<char> board)
        {
            Console.WriteLine($"\n{board[0]}|{board[1]}|{board[2]}\n" +
                $"-+-+-\n{board[3]}|{board[4]}|{board[5]}\n" +
                $"-+-+-\n{board[6]}|{board[7]}|{board[8]}");
        }


    }
}