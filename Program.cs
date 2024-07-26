namespace Lotery2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lotery(20, 0, 99);
            Console.ReadKey();
        }
        public static void Lotery(int wieVielZahlen, int bereichBegin, int bereichEnde)
        {
            string? b = "";
            for (int i = 0; i < wieVielZahlen; i++)
            {
                Random r = new Random();
                int c = r.Next(bereichBegin, bereichEnde);
                Console.WriteLine("Zahl " + (i + 1) + "=" + c);
            }

        }
    }
}
