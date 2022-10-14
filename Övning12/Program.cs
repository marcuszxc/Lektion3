namespace Övning12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<double> talList = new List<double>();
            double sum = 0;

            while (true)
            {

                Console.WriteLine("Skriv in vilket tal du vill som ska lägas till i listan. (Skriv 'sluta' för att sluta skriva tal)");
                string tal = Console.ReadLine().ToLower();


                if (tal == "sluta")
                {
                    break;
                }

                talList.Add(double.Parse(tal));

            }

            foreach (double talDou in talList)
            {
                sum += talDou;
                Console.WriteLine(sum);
            }
        }
    }
}