using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {

            //Deklaration av variabl
            int i = 1;

            //for-satsen 
            for (int x = 0; x < 26; x++)
            {

                switch (i)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        i++;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        i++;
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        i = 1;
                        break;
                }
                if (x % 2 != 0)
                {
                    Console.Write(" ");
                }
                for (int y = 0; y < 39; y++)
                {

                    Console.Write("* ");
                }
                Console.ResetColor();
                Console.WriteLine();
            }



        }
    }
}
