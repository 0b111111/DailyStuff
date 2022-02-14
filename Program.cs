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
        static Int64 Pow(Int64 a,Int64 b=2)
        {
            Int64 sum=1;
            for(int x=0;x<b;x++)
            {
                sum*=a;
            }
            return sum;
        }
        static void Square(out int x)
        {
            x*=x;
        }
        static void Upgrade(out String a,out String b)
        {
            a="Lamborghini";
            b="Porsche";
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor=ConsoleColor.Green;
            Console.BackgroundColor=ConsoleColor.Black;
            //Console.Write("Enter a natural number: ");
            //var smthing=Convert.ToUInt64(Console.ReadLine());
            /*var smthing=5;
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
            ulong e=3;//Convert.ToUInt64(Console.ReadLine());
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
            }*/
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
            else Console.WriteLine("\nTrue\nx: {0}\ny: {1}",x,y);
            do
            {
                try
                {
                    Console.Write("Enter a number: ");
                    String str=Console.ReadLine();
                    Int64 c;
                    //str=="exit" ? break : Int64 c=Convert.ToInt64(str);
                    if(str=="exit")
                    {
                        break;
                    }
                    else
                    {
                        c=Convert.ToInt64(str);
                    }
                    Console.WriteLine("{0}+2={1}",c,c+2);
                }
                catch(Exception E)
                {
                    //Console.WriteLine("Console.WriteLine(E): "+E);
                    //Console.WriteLine("Console.WriteLine(E.ToString()): "+E.ToString());
                    Console.WriteLine("Console.WriteLine(E.Message): "+E.Message);
                }
            }while(true);*/
            //Console.WriteLine(Pow(5));

            int x=4;
            //Console.WriteLine(x);
            Square(out x);
            Console.WriteLine(x);

            /*string fcar,scar;
            Console.WriteLine("Your old carse are: "+fcar+' '+scar);
            Upgrade(out fcar,out scar);
            Console.WriteLine($"Your new cars are: "+fcar+' '+scar);*/

            Over();
        }
    }
}
