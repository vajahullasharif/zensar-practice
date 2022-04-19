using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter user name");
            string username = Console.ReadLine();
            Console.WriteLine("Hi! " + username + " Welcome to the world of C#");

            int num;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("It is even number");
            else
                Console.WriteLine("It is  odd number");

            Console.WriteLine("enter the num1");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the num2");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the num3");
            int n3 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("the largest " + n1);
            }
            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine("the largest" + n2);
            }
            else
            {
                Console.WriteLine("the largest" + n3);
            }
            
            Console.Read();
        }
    }
}
