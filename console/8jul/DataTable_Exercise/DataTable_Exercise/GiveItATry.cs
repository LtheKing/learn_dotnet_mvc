using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTable_Exercise
{
    public class GiveItATry
    {

        public void reverseTriangle() {
            Console.WriteLine("Character: ");
            string symbol = (Console.ReadLine());
            Console.WriteLine("Peak of Triangle: ");
            int peak = Int32.Parse(Console.ReadLine()); // spaces for triangle
            int i = 0;
            int n = 1;
            while (i != -1) // do it until i is negative
            {
                Console.WriteLine(" ");

                int z = 1;

                while (z <= i) // Symbols for triangle
                {
                    Console.Write(symbol);
                    z++;
                }

                i += n; // increments when n = 1. decrements when n = -1

                if (i >= peak) // reverse counter when it reaches peak
                {
                    n = -1;
                }
            }
        } // end of reverseTriangle

        public void madeByAldi() {
            int i = 0;
            int b = 5;
            int n = 1;
            string symbol = "*";
            do
            {
                //Console.WriteLine(" ");
                Console.Write(symbol);
                int z = 0;
                if (i <= b)
                {
                    i += n;
                }

                if (i >= b)
                {
                    n = -1;
                    z -= 1;
                }

              
            } while (i != -1);
        }
    }
}
