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

            SnakeAndLadder dice = new SnakeAndLadder();
            dice.Game();
            Console.ReadLine();
        }
    }
}
