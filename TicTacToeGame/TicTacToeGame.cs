using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class TicTacToeGame2
    {
        //declaring 1d array
        char[] board = new char[10];

        //adding empty spaces to each element
        public void CreateBoard()
        {
            for (int i = 1; i < board.Length; i++)
            {
                board[i] = ' ';
            }
        }
        public static void ChooseLetter()
        {
            Console.WriteLine("Enter 1 for--->X\nEnter 2 for--->O\nChoose your Letter--> ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                int playerletter = 'X';
                int computerLetter = 'O';
                Console.WriteLine("Player Letter is:" + playerletter);
                Console.WriteLine("Computer Letter is:" + computerLetter);
            }
            else if (choice == 2)
            {
                int PlayerLetter = 'O';
                int CompterLetter = 'X';
                Console.WriteLine("Player Letter is:" + PlayerLetter);
                Console.WriteLine("Computer Letter is:" + CompterLetter);
            }
            else
            {
                Console.WriteLine("Please enter 1 or 2 only");
            }
        }

    }
}
    

    

