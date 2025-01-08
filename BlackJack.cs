namespace Casino
{
    public class CardStack
    {
        private Stack<Card> package;
        private Random random;
        private const byte MAX_COUNT = 52;
        private byte Desired_Count { get => MAX_COUNT-1; }
        public CardStack()
        {
            package = new();
            random = new();

            int symbols = Enum.GetNames(typeof(Symbol)).Length;
            int values = Enum.GetNames(typeof(Value)).Length;

            for (int i = 0; i < symbols; i++)
                for (int ii = 0; ii < values; ii++)
                    package.Push(new Card((Symbol)i,(Value)ii));

            Shuffle();
        }
        public void Shuffle()
        {
            List<int> order = new();
            Dictionary<int, Card> newDic = new();

            try {

            while (order.Count < package.Count)
            {                
                int r = random.Next(0, MAX_COUNT);
                if (!order.Contains(r))
                    order.Add(r);
            }
            for (int i = 0; i < order.Count; i++)
                newDic.Add(order[i], package.Pop());

            for (int i = 0; i < order.Count; i++)
                package.Push(newDic[i]);
            } catch (Exception ex) {
                string newD = "", ord = "";
                newDic.Keys.ToList().ForEach(k => newD += k + " ");
                order.Sort();order.ForEach(k => ord += k + " ");
                Console.WriteLine($"Desired_Count= {Desired_Count}" +
                    $"\norder.Count= {order.Count}\nnewDic.Count= {newDic.Count}"+
                    $"\nnewDic= {newD}\norder= {ord}"+
                    $"\npackage.Count= {package.Count}\nExeption= {ex.Message}");
            }
        }
        public Card PickCard()
        {
            return package.Pop();
        }
    }
    public class Hand
    {
        protected List<Card> cards;
        public virtual bool CanPlay { get => 0 < cards.Count; }

        public Hand()
        {
            cards = new();
        }
        public virtual void Add(Card card)
        {
            cards.Add(card);
        }
        public virtual void WriteOut()
        {
            CardRenderer.MultiCardGrafic(cards);
        }
    }
    public class BlackHand : Hand
    {
        public override bool CanPlay    { get => GetSum() < MAX_SUM; }
        public Action? Victory;
        private const byte MAX_SUM = 21;
        public BlackHand()
        {
            
        }
        public byte GetSum()
        {
            byte    sum = 0,
                    aces = 0;
            foreach (Card card in cards)
            {
                if (card.AValue > 0)
                    sum += (byte)card.Value;
                else
                    aces++;
            }

            for (int i = 0; i < aces; i++)
            {
                if (i + 11 <= MAX_SUM)
                    sum += 11;
                else
                    sum += 1;
            }

            return sum;
        }
        public override void Add(Card card)
        {
            base.Add(card);
            if (GetSum() == MAX_SUM)
            {

            }
        }
    }
    public class Card : IEquatable<Card>
    {
        public Symbol Symbol    { get => symbol; }
        public Value Value      { get => value;}
        public byte AValue      { get => (byte)value;}
        public bool Readable    
        { 
            get => readable; 
            set => readable = value;
        }
        private readonly Symbol symbol;
        private readonly Value value;
        private bool readable;
        public Card (Symbol s, Value v, bool r = false)
        {
            symbol = s;
            value = v;
            readable = r;
        }
        public override string ToString()
        {
            string r = value.ToString();
            r = r.PadRight(6) + "|  ";
            //r += Enum.GetName(typeof (Value),   value);
            r += symbol;

            return r;
        }
        public override int GetHashCode()
        {
            return 10*(int)value + (int)symbol;
        }
        public bool Equals(Card? other)
        {
            return other != null && value == other.value && other.symbol == symbol;
        }
    }
    public enum Symbol { Clubs, Diamonds, Hearts, Spades/*, Back*/ }
    public enum Value  { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Quuen, King }
}