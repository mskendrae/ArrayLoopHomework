using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLoopHomework
{
    class Program
    {
        static void Main(string[] args)
        {

            int winNumber = int.Parse(Console.ReadLine());

            while (!(winNumber % 3 == 0))
              { Console.WriteLine("you lost! please try again");
            winNumber = int.Parse(Console.ReadLine());
              }
                Console.WriteLine("You WON!!!");

        
         }
    }
}
