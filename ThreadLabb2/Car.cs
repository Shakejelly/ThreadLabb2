using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadLabb2
{
    internal class Car
    {
        public string Name { get; set; }
        public Car(string name)
        {
            Name = name;
        }
        public void Move()
        {

            for (int i = 0; i <= 14000; i++)
            {
                Thread.Sleep(140);
                


                //if (i == 14000)
                //{
                //    Console.WriteLine("=================================");
                //    Console.WriteLine($"140km! {Name} reached the goal!");
                //    Console.WriteLine("=================================");
                //    Environment.Exit(0);
                //}

            }
        }
    }
}
