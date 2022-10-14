namespace Övning6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Vad vill du göra?\n1 - Omvandla meter till kilometer.\n2 - Omvandla kilometer till meter.\n3 - Avsluta programet.\n\n");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Meter: ");
                        double meter = double.Parse(Console.ReadLine());
                        Console.WriteLine($"{meter} meter är lika med {meter / 1000}km\n");
                        break;

                    case 2:
                        Console.Write("Kilometer: ");
                        double kilometer = double.Parse(Console.ReadLine());
                        Console.WriteLine($"{kilometer} kilometer är lika med {kilometer * 1000}m\n");
                        break;

                    case 3:
                        return;

                    default:
                        Console.WriteLine("Skriv in ett nummer från 1 till 3.");
                        break;
                }
                
            }
        }
    }
}