namespace Övning5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in ett nummer: ");
            double num = double.Parse(Console.ReadLine());

            int sum = Enumerable.Range(1,Convert.ToInt32(num)).Sum();

            double Fack(double n)
            {

                if (n == 1) 
                {
                    return 1;
                }

                return Fack(n - 1) * n;

            }

            Console.WriteLine($"Summan av 1 till {num} är lika med {sum} och fakulteten av {num}! är lika med {Fack(num)}");

        }
    }
}