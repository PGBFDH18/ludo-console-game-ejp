using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class Player
    {
        public string Name;
        public Piece Piece;

    }

    public class Piece
    {
        public string Name;
        public int locationX;
        public int locationY;

    }

    public class Dice
    {
        public int rollDice()
        {
            Random num = new Random();
            int Number = num.Next(1, 7);

            return Number;
        }
    }

    public class Rules
    {
         
    }

    public class Board
    {
        static void Main(string[] args)
        {
            Console.WriteLine("            [ ][ ][ ]");
            Console.WriteLine("            [ ][ ][ ]");
            Console.WriteLine("            [ ][ ][ ]");
            Console.WriteLine("            [ ][ ][ ]");
            Console.WriteLine("[ ][ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            Console.WriteLine("[ ][ ][ ][ ][ ] # [ ][ ][ ][ ][ ]");
            Console.WriteLine("[ ][ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            Console.WriteLine("            [ ][ ][ ]");
            Console.WriteLine("            [ ][ ][ ]");
            Console.WriteLine("            [ ][ ][ ]");
            Console.WriteLine("            [ ][ ][ ]");
        }





    }


}
