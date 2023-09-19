// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace testConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int waittime = 90;
            Console.CursorVisible = false;
            while (true)
            {

                Console.Write("/");
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                System.Threading.Thread.Sleep(waittime);
                Console.Write("-");
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                System.Threading.Thread.Sleep(waittime);
                Console.Write("\\");
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                System.Threading.Thread.Sleep(waittime);
                Console.Write("|");
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                System.Threading.Thread.Sleep(waittime);
            }
        }
    }
}