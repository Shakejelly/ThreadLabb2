namespace ThreadLabb2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press N to get information");

            Car car1 = new Car("Speedy McZoomZoom");
            Car car2 = new Car("Vroom Vroom Veggie Mobile");
            Car car3 = new Car("RaceLord Von Drifty");

            Thread thread1 = new Thread(car1.Move);
            Thread thread2 = new Thread(car2.Move);
            Thread thread3 = new Thread(car3.Move);

            thread1.Start();
            thread2.Start();
            thread3.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();

            
            

        }


    }
}