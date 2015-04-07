using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipACoin
{
    class Program
    {
        static Random rng = new Random();
        static int headsCounter = 0;
        static int tailsCounter = 0;

        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Flipped: " + FlipACoin());
            }
            Console.WriteLine("#Heads: " + headsCounter);
            Console.WriteLine("#Tails: " + tailsCounter);

            Console.WriteLine("It took " + FlipForHeads() + " times to get a head");

            Console.ReadKey();
        }

        public static int FlipForHeads()
        {
            int counter = 1;
            // Flip while it is not a Head
            while (rng.Next(2) != 0)
            {
                counter++;
            }
            return counter;
        }
        public static string FlipACoin()
        {
            if (rng.Next(2) == 0)
            {
                // heads
                headsCounter++;
                return "Heads";
            }
            else
            {
                //tails
                tailsCounter++;
                return "Tails";
            }
        }
    }
}
