namespace ДР_13_1
{
    internal class Program
    {
        static void Main()
        {
            Console.SetWindowSize(80, 40);
            Console.CursorVisible = false;

            Matrix instance;

            for (int i = 0; i < 30; i++)
            {
                instance = new Matrix(i * 2);
                new Thread(instance.Move).Start();
            }

            Console.ReadKey();
        }
    }
}