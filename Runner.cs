using Casino;

namespace Program
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CardStack cardStack= new();

            Hand hand = new();
            
            hand.Add(cardStack.PickCard());
            hand.Add(cardStack.PickCard());
            hand.Add(cardStack.PickCard());

            hand.WriteOut();

            Console.ReadKey();
        }
    }
}
