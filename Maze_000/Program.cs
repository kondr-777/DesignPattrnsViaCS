using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zame0;

namespace Maze_000
{
    class Program
    {
        static void Main(string[] args)
        {

            MazeGame mg = new MazeGame();
            Maze m = mg.CreateMaze();
            while(true)
            {
                ConsoleKeyInfo k = Console.ReadKey(false);
                Console.WriteLine(k.Key);
                if(k.Key == ConsoleKey.UpArrow || k.Key == ConsoleKey.DownArrow || k.Key == ConsoleKey.LeftArrow || k.Key == ConsoleKey.RightArrow)
                {
                    
                }
                else
                {
                    Console.WriteLine("Press key arrows.");
                }
                
            }
        }
    }
}
