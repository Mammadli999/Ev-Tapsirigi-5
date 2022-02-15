using System;

namespace ClassLibrary1
{
    public class Monitor
    {
        public static string ReadString(string caption)
        {
            Console.Write(caption);
            Console.ForegroundColor = ConsoleColor.Magenta;
            string aStr = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            return aStr;
        }
        public static int ReadInteger(string caption)
        {
        l1:
            Console.Write(caption);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string astr = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            int a;

            try
            {
                a = Convert.ToInt32(astr);
            }
            catch (Exception)
            {
                Monitor.PrintError("Yanlsihdir,Zehmet Olmasa Yeniden Daxil Edin.");
                goto l1;
            }
            return a;
        }
        public static double ReadDouble(string caption)
        {
        l1:
            Console.Write(caption);
            Console.ForegroundColor = ConsoleColor.Green;
            string aStr = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            double a;

            try
            {
                a = Convert.ToDouble(aStr);
            }
            catch
            {
                Monitor.PrintError("Yanlsihdir,Zehmet Olmasa Yeniden Daxil Edin.");
                goto l1;
            }

            return a;
        }
        public static void Print(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void PrintError(string msn)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msn);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
