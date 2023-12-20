namespace ThreadLabb2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Car car1 = new Car("Speedy McZoomZoom");
                Car car2 = new Car("Vroom Vroom Veggie Mobile");
                Car car3 = new Car("RaceLord Von Drifty");

                Thread thread1 = new Thread(car1.Move);
                Thread thread2 = new Thread(car2.Move);
                Thread thread3 = new Thread(car3.Move);

                thread1.Start();
                thread2.Start();
                thread3.Start();

              while (true)
               {
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"{car1.Name} - Current distance: {Math.Round(car1.CurrentDistance * 100, 0)} m.");
                Console.WriteLine($"{car2.Name} - Current distance: {Math.Round(car2.CurrentDistance * 100, 0)} km.");
                Console.WriteLine($"{car3.Name} - Current distance: {Math.Round(car3.CurrentDistance * 100, 0)} km.");
                Thread.Sleep(100);
               }

                thread1.Join();
                thread2.Join();
                thread3.Join();


            


        }


    }
}