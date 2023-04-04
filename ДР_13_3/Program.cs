namespace ДР_13_3
{
    internal class Program
    {
        static int threadCount; 

        static public void Recursion()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} say \"Hello!\"");

            Thread.Sleep(500);

            Thread thread = new Thread(Recursion);
            threadCount++; 

            thread.Name = "Thread " + threadCount;
            thread.Start();
        }

        static void Main()
        {
            Thread thread = new Thread(Recursion);
            thread.Name = "Thread " + threadCount;

            thread.Start();
        }
    }
}