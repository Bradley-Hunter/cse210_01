﻿/*
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
            Console.Write($"{playerTurn}'s turn to choose a square (1-9): ");
            string choice = Console.ReadLine();
            int square = int.Parse(choice);      
            if (board[square - 1] == Convert.ToChar(choice))
            {
                updateBoard(board, square, playerTurn);
            }
            drawBoard(board);

            
        }

        static void updateBoard(List<char> board, int userSquare, char playerTurn)
        {
            board[userSquare - 1] = playerTurn;
        }

        static void drawBoard(List<char> board)
        {
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}\n" +
                $"-+-+-\n{board[3]}|{board[4]}|{board[5]}\n" +
                $"-+-+-\n{board[6]}|{board[7]}|{board[8]}");
        }


    }
}