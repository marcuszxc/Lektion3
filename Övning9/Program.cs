namespace Övning9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in höjden på kvadraten du vill ha.: ");
            int höjd = int.Parse(Console.ReadLine());
            Console.Write("Skriv in bredden på kvadraten du vill ha.: ");
            int bredd = int.Parse(Console.ReadLine());

            for (int z = 0; z != 2; z++)
            {

                for (int x = 0; x < bredd; x++)
                {
                    Console.Write("*");
                }

                if (z == 0)
                {
                    for (int y = 0; y < höjd - 2; y++)
                    {
                        Console.Write("\n");

                        for (int a = 0; a < bredd; a++)
                        {
                            if (a == bredd - 1 && y == höjd - 3)
                            {
                                Console.WriteLine("*");
                            }

                            else
                            {
                                if (a == 0 || a == bredd - 1)
                                {
                                    Console.Write("*");
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}