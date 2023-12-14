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
            
            for (int i = 0; i < 1000; i++)
            {
                Random random = new Random(1 - 50);
                
                Console.WriteLine($@"{random}");
            }
            
        }
        
    }
}
