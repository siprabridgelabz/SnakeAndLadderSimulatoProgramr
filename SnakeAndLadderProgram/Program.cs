using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Snake and Ladder Program");
            SnakeAndLadder snakeLadder = new SnakeAndLadder();
            snakeLadder.RollingDice();
            Console.ReadLine();
        }
    }
}
