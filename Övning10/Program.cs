namespace Övning10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "Ta det lunnnnnnnnnnngt";
            
            foreach (char lol in message)
            {
                Thread.Sleep(1000);
                Console.Write(lol);
            }
        }
    }
}