namespace Övning3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vad är dit namn?: ");
            string namn = Console.ReadLine().ToLower();
            Console.Write("Vad är din ålder?: ");
            int ålder = int.Parse(Console.ReadLine());
            int grupp;     

            if (ålder > 75)
            {
                grupp = 2;
            }
            else if (ålder >= 18 && ålder <= 25)
            {
                grupp = 3;
            } 
            else
            {
                grupp = 4;
            }


            if (namn == "felicia" || namn == "felix")
            {
                grupp = 1;
            }

            Console.WriteLine($"Flygbolaget placerar dig i grupp {grupp}.");

        }
    }
}