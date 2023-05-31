namespace AmazingChess.GameInterface
{
    public class ConsoleWriter : IConsoleInterface
    {
        public string ReadLine()
        {
            return Console.ReadLine() ?? "";
        }

        public void WriteLine(string line)
        {
            Console.WriteLine(line);    
        }
    }
}
