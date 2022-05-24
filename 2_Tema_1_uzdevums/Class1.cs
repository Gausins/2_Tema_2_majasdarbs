using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Tema_1_uzdevums

{
    class Game
    {
        static string[] pos = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        static void DrawBoard()
        {
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[1], pos[2], pos[3]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[4], pos[5], pos[6]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[7], pos[8], pos[9]);
        }

        public string name1 { get; set; }
        public string name2 { get; set; }
        static void Main(string[] args)
        {
            string player1 = "", player2 = "";
            int choice = 0, turn = 1, score1 = 0, score2 = 0;
            bool winFlag = false, playing = true, correctInput = false;

            Console.WriteLine("What is the name of player 1?");
            string name1 = Console.ReadLine();
            Console.WriteLine($"Hi player1: {name1}!");
            Console.WriteLine("Very good. What is the name of player 2?");
            string name2 = Console.ReadLine();
            Console.WriteLine($"Hi player2: {name2}!"); ;
            Console.WriteLine($"Ok. {name1} is O and {name2} is X.");
            Console.WriteLine($" {name1} goes first.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Let's start a GAME!");
            Console.WriteLine();
            Console.WriteLine();
            DrawBoard();
            Console.WriteLine("");
        }

    }
}
