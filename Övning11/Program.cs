namespace Övning11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur många sporter vill du skriva in? :");
            int listnum = int.Parse(Console.ReadLine());

            string[] sporter = new string[listnum];

            for (int i = 0; i < sporter.Length; i++)
            {
                Console.Write($"{i+1} - Sport: ");
                sporter[i] = Console.ReadLine();
            }

            for (int n = 0; n < sporter.Length; n++)
            {
                Console.WriteLine($"{sporter[n]}");
            }
        }
    }
}