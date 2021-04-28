/*
ver: 0.1a  date: 2021.04.28
autor: Mikhail625@protonmail.com
*/

/* conditions :




templates ver.: 03
Add print array 2D

Tip(s): for formatting Ctrl + K, а затем Ctrl + D.

path of template :
C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\ProjectTemplates\CSharp\1033\SharedProject
*/



using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigureConsole(" Lesson #8  ver: 0.3a date: 2021.04.28");
            Task1();
            Task2();
            Task3();

            static void Task1()
            { // Task № 01
              // block declare init & vars
              // block executive
              // block output results and reports
              // block by and soft shutdown
              // end of  Task № 01
            }

            static void Task2()
            {
                // Task № 02
                // block declare init vars
                // block executive
                // block output results and reports
                // block by and soft shutdown
                // end of  Task № 02
            }

            static void Task3()
            {
                // Task № 03
                // block declare init vars
                // block executive
                // block output results and reports
                // block by and soft shutdown
                // end of  Task № 03
            }


            static void Task4()
            {
                // Task № 04
                // block declare init vars
                // block executive
                // block output results and reports
                // block by and soft shutdown
                // end of  Task № 04
            }


            static void Task5()
            {
                // Task № 05
                // block declare init vars
                // block executive
                // block output results and reports
                // block by and soft shutdown
                // end of  Task № 05
            }


            static void Task6()
            {
                // Task № 06
                // block declare init vars
                // block executive
                // block output results and reports
                // block by and soft shutdown
                // end of  Task № 06
            }

            static void TaskX()
            {
                // Task № xx
                // block declare init vars
                // block executive
                // block output results and reports
                // block by and soft shutdown
                // end of  Task № xx
            }


        }


        // under


        static void Print2DArray(int[,] arr)
        {
            // Display the array elements.
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    System.Console.WriteLine("Element({0},{1})={2}", i, j, arr[i, j]);
                }
            }
        }
        static string GetStrFromCons(string strQuestion, string strByDef)
        {
            string strResult;
            if (TestForNullOrEmpty(strQuestion) == true)
            { strQuestion = "   Enter value:"; }

            Console.WriteLine("   " + strQuestion);
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            strResult = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;

            // check/verife isNull Empty
            if (TestForNullOrEmpty(strResult) == true)
            {
                strResult = strByDef;
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("       " + "Not value, set by default: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(strResult);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("");

            }
            return strResult;
        }

        static bool TestForNullOrEmpty(string s)
        {
            bool result;
            result = (s == null || s == string.Empty);
            return result;
        }

        static void ClearScr(int countDown, int warningTimer)
        {
            bool bWarning = false;

            for (int i = (countDown + 1); i > 0; i--)
            {
                System.Threading.Thread.Sleep(1000);
                if (i == warningTimer) { bWarning = true; }
                if (bWarning == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("\r         ");
                Console.Write("\r     [{0}]", i);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();



        }

        static void ConfigureConsole(string headerConsWindow)
        {
            // Configure console.
            Console.Title = headerConsWindow;
            /*
             * Console.BufferWidth = 80;
            Console.WindowWidth = Console.BufferWidth;
            Console.TreatControlCAsInput = true;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Gray;
            */
        }


    }
}
