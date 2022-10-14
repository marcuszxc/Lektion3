namespace Övning13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] karta = { {"Ö", "Hav", "Hav", "Skog"}, {"Hav", "Hav", "Skog", "Skog"} };
            int xKord = 0;
            int yKord = 0;

            Console.Write("Skriv in en X-kordinat: ");
            xKord = int.Parse(Console.ReadLine());
            Console.Write("Skriv in en Y-kordinat: ");
            yKord = int.Parse(Console.ReadLine());

            Console.WriteLine($"På korddinaterna du angav finns {karta[xKord,yKord]}");

        }
    }
}