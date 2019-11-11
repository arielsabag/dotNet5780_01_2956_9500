using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2
{
    class Program
    {
        enum choice { requirment, schedule, occupied, exit };
        static void Main(string[] args)
        {
            
            bool exit = false;
            bool[,] Calendar = new bool[12, 31];
            for (int i = 0; i < Calendar.Length/31; i++)
            {
                for (int j = 0; j < Calendar.Length/12; j++)
                {
                    //Calendar[i, j] = false;
                }
            }

            do
            {
                Console.WriteLine("choose 1 for customers requirment for hospitality");
                Console.WriteLine("choose 2 to view the annual list of all accomadation periods");
                Console.WriteLine("choose 3 to display the total number of days occupied per year and the percentage of annual occupancy");
                Console.WriteLine("choose 4 to exit");
                int decision= Int32.Parse(Console.ReadLine());
                switch (decision)
                {
                    case (int)choice.requirment:
                        int month, day, length;
                        Console.WriteLine("enter day");
                        Console.WriteLine("enter month");
                        Console.WriteLine("enter length");
                        break;

                    case (int)choice.schedule:
                        break;

                    case (int)choice.occupied:
                        break;

                    case (int)choice.exit:
                        exit = true;
                        break;

                }
            } while (!exit);

            Console.ReadKey();
        }
    }
}
