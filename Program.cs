using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DailyStuff
{
    internal class Program
    {
        static void Over()
        {
            Console.ForegroundColor=ConsoleColor.DarkGreen;
            Console.Write("\nPress any key to continue...");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor=ConsoleColor.Green;
            Console.BackgroundColor=ConsoleColor.Black;
            //Console.Write("Enter a natural number: ");
            //var smthing=Convert.ToUInt64(Console.ReadLine());
            var smthing=5;
            if(smthing++==8)
            {
                Console.WriteLine("It's 8");
            }
            else if(++smthing==9)
            {
                Console.WriteLine("It's 9");
            }
            else if(++smthing==10)
            {
                Console.WriteLine("It's 10");
            }
            else if(++smthing==11)
            {
                Console.WriteLine("It's something else");
            }
            Console.WriteLine("smthing: "+smthing);
            Console.Write("Enter a switch number: ");
            ulong e=Convert.ToUInt64(Console.ReadLine());
            switch(e)
            {
                case 1:
                    Console.WriteLine("no idea yet but case 1");
                    break;
                default:
                    Console.WriteLine("outside of cases hence it's the default case");
                    break;
                case 2:
                    Console.WriteLine("case 2 it was");
                    break;
                case 0:
                    Console.WriteLine("default");
                    break;
            }
            /*UInt64 x=0;
            while(true)
            {
                if(x%1E7==0)Console.WriteLine(x);
                x++;
            }
            Console.Write("Please Enter A number for table generation: ");
            int userValue=Convert.ToInt32(Console.ReadLine());
            Console.Write("How Long it should be: ");
            int userValue2=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= userValue2; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", userValue, i, userValue*i);
            }*/
            //Console.WriteLine("some text {0} and {1} but {5} why {3} not {4}","and another","why not","you know",5,2,"yes?");
            /*int x=5,y=10;
            if(x>3|++y<5)
            {
                Console.WriteLine("\nTrue\nx: {0}\ny: {1}",x,y);
            }
            else Console.WriteLine("\nTrue\nx: {0}\ny: {1}",x,y);*/

            Over();
        }
    }
}
