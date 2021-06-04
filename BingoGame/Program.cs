using System;

namespace BingoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = 10;
            var bingoBoard = new BingoBoard(rows);
            
            Console.WriteLine("Hello World!");
        }
    }

    public class BingoBoard
    {
        private int _rows;

        public BingoBoard(int rows)
        {
            _rows = rows;
        }
    }
}