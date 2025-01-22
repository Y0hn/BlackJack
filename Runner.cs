using Casino;

namespace Program
{
    internal class Program
    {
        public static void Main()
        {
            while (true)
            {
                BlackGame.WithDealer();
                Console.ReadKey();
            }            
        }
    }
}
