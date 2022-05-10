﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public delegate void MyDelegate(string str);
    internal class EventsEg2
    {
        public event MyDelegate MyEvent; 
        public EventsEg2()
        {
            this.MyEvent += new MyDelegate(this.WelcomeUser);
            this.MyEvent += new MyDelegate(this.DisplayName);
        }
        public void WelcomeUser(string username)
        {
            Console.WriteLine("Welcome" + " " + username);
        }
        public void DisplayName(string name)
        {
            Console.WriteLine(name);
        }
        static void Main()
        {
            EventsEg2 ec2 = new EventsEg2();
            ec2.MyEvent("Banurekha");
            Console.Read();
        }
    }
}


