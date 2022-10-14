namespace Övning4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Vad är din ålder?: ");
            int ålder = int.Parse(Console.ReadLine());

            if (65 < ålder || Enumerable.Range(10, 18).Contains(ålder))
            {
                Console.WriteLine("Du kommer att få biligare kaffe!!!");
            }
            else
            {
                Console.WriteLine("Du måste bettala vanligt pris för kaffe :(");
            }
        }
    }
}