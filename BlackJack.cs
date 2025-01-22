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
    public abstract class Hand
    {
        protected string name;
        protected List<Card> cards;
        public virtual string Name => name;
        public virtual bool CanPlay { get => 0 < cards.Count; }
        public virtual bool Folded  
        { 
            get => folded; 
            set => folded = value; 
        }
        protected bool folded;
        public Hand(string n = "")
        {
            folded = false;
            cards = [];
            name = n;
        }
        public virtual void Add(Card card)
        {
            cards.Add(card);
        }
        public virtual void WriteOut()
        {
            CardRenderer.MultiCardGrafic(cards);
        }
        public virtual bool RevalNext()
        {
            Card? card = cards.Find(c => !c.Readable);
            bool find = card != null;

            if (card != null)
                card.Readable = true;

            return find;
        }
        public override string ToString()
        {
            string s = "";
            cards.ForEach(c => s += c.ToString());
            return s;
        }
    }
    public class BlackHand : Hand
    {
        public override bool CanPlay    => Sum <= MAX_SUM;
        public override bool Folded
        {
            get => base.Folded || Victory || !CanPlay;
            set => base.Folded = value;
        }
        public bool Victory             => Sum == MAX_SUM;
        private const byte MAX_SUM = 21;
        public virtual byte Sum
        {
            get {
                byte    sum = 0,
                        aces = 0;
                foreach (Card card in cards.FindAll(c => c.Readable))
                {
                    if (card.AValue > (byte)Value.Ten)
                        sum += 10;
                    else if (card.AValue > 0)
                        sum += (byte)(card.Value+1);
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
        }
        public BlackHand(string n) : base(n)
        {
            
        }
        public override void WriteOut()
        {
            base.WriteOut();

            Console.WriteLine($"Sucet: {Sum}");
        }
        public override void Add(Card card)
        {
            base.Add(card);
        }
        public static BlackHand? GetWinner(BlackHand hand1, BlackHand hand2)
        {
            BlackHand? wictor = null;
            if     (hand1.Victory 
                        || 
                    hand1.CanPlay && 
                        (!hand2.CanPlay
                            || 
                        hand2.Sum < hand1.Sum))
            {
                wictor = hand1;
            }
            else if (hand2.Victory
                        ||
                    hand2.CanPlay && 
                        (!hand1.CanPlay
                            || 
                        hand1.Sum < hand2.Sum))
            {
                wictor = hand2;
            }
            
            //Console.WriteLine($"H1: sum({hand1.Sum}) canPlay({hand1.CanPlay}) victor({hand1.Victory})");
            //Console.WriteLine($"H2: sum({hand2.Sum}) canPlay({hand2.CanPlay}) victor({hand2.Victory})");
            
            return wictor;
        }
    }
    public class BlackDealer : BlackHand
    {
        public override bool Folded 
        { 
            get => base.Folded || DealerLimit; 
            set => base.Folded = value; 
        }
        protected virtual bool DealerLimit => Sum > DEALER_WHANTED_SUM;
        const int DEALER_WHANTED_SUM = 16;
        public BlackDealer(string n = "Dealer") : base(n)
        {

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