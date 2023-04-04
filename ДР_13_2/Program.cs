namespace ДР_13_1
{
    internal class Program
    {
        static void Main()
        {
            Console.SetWindowSize(80, 40);
            Console.CursorVisible = false;

            Matrix instance;

            for (int i = 0; i < 26; i++)
            {   
                instance = new Matrix(i * 3, true);
                new Thread(instance.Move).Start();
            }

            Console.ReadKey();
        }
    }
}