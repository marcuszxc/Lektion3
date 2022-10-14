namespace Övning8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            string rättsvar = "tyskland";
            
            for (; i < 5; i++)
            {   
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Vilket är Europas folkrikasteland?");
                string svar = Console.ReadLine();

                if (svar == rättsvar)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Du svarade rätt :)");
                    break;
                }

                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Du svarade fel :(\n");

            }

            if (i == 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Du har misslykats");
            }
        }
    }
}