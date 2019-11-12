using System;// change from pc
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part1
{
   /// <summary>
   ///  The program will randomly choose numbers betwenn 18 and 122 and put those numbers in two arrays that the size of each one is 20.
   ///  And then the program will create a third array which is the difference between the numbers of the two arrays.
   /// </summary>
    class Program
    {
        static Random r = new Random(DateTime.Now.Millisecond);
        static void Main(string[] args)
        {
            int[] A = new int[20];
            int[] B = new int[20];
            int[] C = new int[20];


            for (int i = 0; i < 20; i++)
            {
                A[i] = r.Next(18, 123);
                B[i] = r.Next(18, 123);
            }
            for (int i = 0; i < 20; i++)
            {
                C[i] = Math.Abs(A[i] - B[i]);
            }

            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0,-4}", A[i]);
            }
            Console.WriteLine(  );
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0,-4}", B[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0,-4}", C[i]);
            }
            Console.ReadKey();
        }
    }
}
