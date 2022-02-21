using System;
using TicTacToe;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********Welcome to TIC TAC TOE ****************\n");

            //creating object of the class
            TicTacToeGame2 obj = new TicTacToeGame2();

            //calling method with the obj variable
            obj.CreateBoard();
        }
    }
}