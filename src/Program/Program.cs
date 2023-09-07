using System;
using System.IO;
using System.Text;
using System.Threading;
using Library;
namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Board.gameBoard()
                FileReader archivo = new FileReader(@"/./board.txt");
            }
        }
    }
}
