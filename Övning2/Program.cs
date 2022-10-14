namespace Övning2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string lönSvar;
            string ålderSvar;

            Console.Write("Vad är din måndas lön?: ");
            int lön = int.Parse(Console.ReadLine());

            Console.Write("Vad är din ålder?: ");
            int ålder = int.Parse(Console.ReadLine());


            if (lön < 36100)
            {
                lönSvar = "Du tjänar mindre än medellönen.";
            }
            else if (lön > 36100)
            {
                lönSvar = "Du tjänar mer än medellönen.";
            }
            else
            {
                lönSvar = "Du tjänar lika mycket som medellönen.";
            }


            if (ålder < 39)
            {
                ålderSvar = "Du är yngre än medelåldern.";
            }
            else if (ålder > 39)
            {
                ålderSvar = "Du är äldre än medelåldern";
            }
            else
            {
                ålderSvar = "Du är lika gammal som medelåldern.";
            }

            Console.WriteLine($"{lönSvar} {ålderSvar}");

        }
    }
}