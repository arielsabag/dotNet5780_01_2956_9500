using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace part2
{
    class Program
    {
        enum choice { requirment = 1, schedule, occupied, exit };
        static void Main(string[] args)
        {
            int day1;
            bool exit = false;
            bool[,] Calendar = new bool[12, 31];
            for (int i = 0; i < Calendar.Length / 31; i++)
            {
                for (int j = 0; j < Calendar.Length / 12; j++)
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
                int decision = Int32.Parse(Console.ReadLine());


                switch (decision)
                {
                    case (int)choice.requirment:
                        addVacation(Calendar);
                        break;

                    case (int)choice.schedule:
                        printSchedule(Calendar);
                        break;

                    case (int)choice.occupied:
                        printOccupied(Calendar);

                        break;

                    case (int)choice.exit:
                        exit = true;
                        break;
                }

            } while (!exit);

            Console.ReadKey();
        }


        private static void printOccupied(bool[,] Calendar)
        {
            double countOccpiedDays = 0;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 31; j++)
                {
                    if (Calendar[i, j])
                    {
                        countOccpiedDays++;
                    }
                 
                }
            }
            Console.WriteLine("Occuied days in this year: " + countOccpiedDays);
            Console.WriteLine("Occupied year percentage : " + countOccpiedDays/372);

        }



        private static void printSchedule(bool[,] Calendar)
        {
            ArrayList tmpArr = new ArrayList();
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 31; j++)
                {
                    if (Calendar[i,j])
                    {
                       int  tempI = i + 1;
                        int tempJ = j + 1;

                        tmpArr.Add(tempJ + "/" + tempI);
                    }
                    else
                    {
                        tmpArr.Add("empty");
                    }
                }
            }
            int state = 0;
            for (int i = 0; i < tmpArr.Count; i++)
            {
                if ((i==0)&&(tmpArr[i].ToString()!="empty"))
                {
                    Console.Write(tmpArr[i].ToString() + " - ");
                    state++;
                }
                else if ((tmpArr[i].ToString()!="empty")&&(state%2==0))
                {
                    Console.Write(tmpArr[i].ToString() + " - ");
                    state++;
                }
                else if ((tmpArr[i].ToString() == "empty")&&(state %2 ==1))
                {
                    state++;
                    Console.WriteLine(tmpArr[i-1].ToString());
                }
            }
        }
    

    private static void addVacation(bool[,] Calendar)
    {
          
            int month, tmpMonth, day, tmpDay, length;
        bool occupied;

        occupied = false;
        Console.WriteLine("enter day");
        day = Int32.Parse(Console.ReadLine());
        tmpDay = day;

        Console.WriteLine("enter month");
        month = Int32.Parse(Console.ReadLine());
        tmpMonth = month;

        Console.WriteLine("enter length");
        length = Int32.Parse(Console.ReadLine());


        // If length = 1 and the first day is occiupied
        if ((1 == length) && (Calendar[month - 1, day - 1]))
        {
            if (32 == day + length)
            {
                if (Calendar[month, 0])
                {
                    occupied = true;
                }
            }
            else if (Calendar[month - 1, day])
            {
                occupied = true;
            }
        }
        else
        {
            for (int i = 0; i < length - 1; i++) // iterate on all days and check if available
            {
                if (tmpDay + i > 30)
                {
                    tmpMonth++;
                    tmpDay = (tmpDay + i) % 31;
                }
                if (Calendar[tmpMonth - 1, tmpDay])
                {
                    occupied = true;
                }
            }
        }
        if (occupied)
        {
            Console.WriteLine("the request was denied");
        }
        else
        {
            Console.WriteLine("your request has been approved");

            tmpDay = day;
            tmpMonth = month;
            Calendar[tmpMonth - 1, day - 1] = true;

            for (int i = 0, j = 0; i < length - 1; i++, j++) // iterate on all days and check if available
            {

                if (tmpDay + j > 30)
                {
                    tmpMonth++;
                        // tmpDay = (tmpDay + i) % 31;
                        tmpDay = 0;
                        j = 0;
                }
                Calendar[tmpMonth - 1, tmpDay + j] = true;
            }

        }
    }
}
}


 //for (int i = 0; i< 12; i++)
 //           {
 //               for (int j = 0; j< 31; j++)
 //               {
 //                   if (Calendar[i, j])
 //                   {

 //                       if ((i == 0) && (j == 0))
 //                       {

 //                           Console.Write("{0} {1} {2}", i, "/", j);

 //                       }
 //                       else if ((i == 11) && (j == 30))
 //                       {

 //                           Console.WriteLine(" - ");
 //                           Console.Write("{0} {1} {2}", i + 1, "/", j + 1);

 //                       }
 //                       else if ((i == 0))
 //                       {
 //                           if (!Calendar[i, j - 1])
 //                           {
 //                               Console.Write("{0} {1} {2}", i, "/", j);

 //                           }
 //                       }
 //                       else if ((i == 11))
 //                       {
 //                           if(!Calendar[i, j + 1])
 //                                       {
 //                               Console.WriteLine(" - ");
 //                               Console.Write("{0} {1} {2}", i + 1, "/", j + 1);
 //                           }
 //                       }
 //                       else
 //                       {


 //                           if (!Calendar[i - 1, 30])
 //                           {
 //                               Console.Write("{0} {1} {2}", i, "/", j);
 //                           }
 //                           else if (!Calendar[i + 1, 0])
 //                           {
 //                               Console.WriteLine(" ---- ");
 //                               Console.Write("{0} {1} {2}", i + 1, "/", j + 1);
 //                           }
 //                           else if (!Calendar[i, j - 1])
 //                           {
 //                               Console.Write("{0} {1} {2}", i, "/", j);

 //                           }
 //                           else if (!Calendar[i, j + 1])
 //                           {
 //                               Console.WriteLine(" - ");
 //                               Console.Write("{0} {1} {2}", i + 1, "/", j + 1);
 //                           }
 //                       }

 //                   }

 //               }

 //           }
 //           Console.WriteLine();