using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part1
{
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
                Console.Write( A[i]);
            }
            Console.WriteLine(  );
            for (int i = 0; i < 20; i++)
            {
                Console.Write( B[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                Console.Write( C[i]);
            }

            Console.ReadKey();
        }
    }
}
