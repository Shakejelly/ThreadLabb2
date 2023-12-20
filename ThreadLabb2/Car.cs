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
        public double CurrentDistance { get; set; }
        public Car(string name)
        {
            Name = name;
        }
        public void Move()
        {

            double kmH = 110;

            double distance = 10;




            Random random = new Random();
            int i = 0;
            while (CurrentDistance < distance)
            {
                i++;
                if (i % 8 == 0)
                {
                    int randomValue = random.Next(1, 50);

                    if (randomValue == 1)
                    {
                        Console.WriteLine($"{Name} needed a pitstop to change oil. Estimated time: 30s!");
                        Thread.Sleep(30000);

                    }
                    else if (randomValue <= 3)
                    {
                        Console.WriteLine($"{Name} needed a pitstop to change tires. Estimated time: 20s.");
                        Thread.Sleep(20000);
                    }
                    else if (randomValue > 3 && randomValue < 10)
                    {
                        Console.WriteLine($"Ouch! {Name} just hit a bird! Estimated time: 10s ");
                        Thread.Sleep(10000);
                    }
                    else if (randomValue > 9 && randomValue < 21)
                    {
                        Console.WriteLine($"{Name} speed decreased!");
                        kmH = kmH - 1;
                    }
                    
                }

                Thread.Sleep(1000);
                CurrentDistance += kmH / (60 * 60); 
            }
            Console.WriteLine($"{Name} has reached the goal!" );
            //TODO
            //Visa roligare UI
            //Avsluta program n'r man har vunnit.
            //Skriva ut andra och tredjeplats.
            
        }
       
    }
}
