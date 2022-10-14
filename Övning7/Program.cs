namespace Övning7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ränta, instatsMål, instats;

            int år = 0;

            Console.Write("Vad vill du sätta in på banken?: ");
            instats  = double.Parse(Console.ReadLine());

            Console.Write("Vad är ränttan i procent?: ");
            ränta = double.Parse(Console.ReadLine()) / 100;

            Console.Write("Vilket slutmål vill du nå med din insättning?: ");
            instatsMål = double.Parse(Console.ReadLine());

            for (; instats < instatsMål; år++)
            {
                instats *= (1 + ränta);
            }

            Console.WriteLine($"Du kommer att ha uppnåt eller överstigit ditt mål på {instatsMål}kr efter {år}år. Värdet på banken kommer då att vara {instats}kr");
            Console.ReadKey();

        }
    }
}