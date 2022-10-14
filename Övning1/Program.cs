namespace Övning1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Vilket land vann fotbolls-VM för damer år 2015?");
            string svar = Console.ReadLine().ToLower();

            if (svar == "usa")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{svar.ToUpper()} var rätt svar!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{svar.ToUpper()} var inte rätt svar!");
            }
        }
    }
}