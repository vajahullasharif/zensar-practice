using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handon_day_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Accounts accounts = new Accounts();

            accounts.credit(4000.00f);
            //accounts.debit(3000.00f);
            accounts.showdetails();
            Console.ReadLine();
        }
    }
}
       
