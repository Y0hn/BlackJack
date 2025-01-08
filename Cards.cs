namespace Casino
{
    /* SOURCE
      _____ 
     |\ ~ /|
     |}}:{{|
     |}}:{{|  _____
     |}}:{{| |Joker|
     |/_~_\| |==%, |
             | \/>\|
ejm98        | _>^^|           _____
   _____     |/_\/_|    _____ |6    |
  |2    | _____        |5    || ^ ^ | 
  |  ^  ||3    | _____ | ^ ^ || ^ ^ | _____
  |     || ^ ^ ||4    ||  ^  || ^ ^ ||7    |
  |  ^  ||     || ^ ^ || ^ ^ ||____9|| ^ ^ | _____
  |____Z||  ^  ||     ||____S|       |^ ^ ^||8    | _____
         |____E|| ^ ^ |              | ^ ^ ||^ ^ ^||9    |
                |____h|              |____L|| ^ ^ ||^ ^ ^|
                            _____           |^ ^ ^||^ ^ ^|
                    _____  |K  WW|          |____8||^ ^ ^|
            _____  |Q  ww| | ^ {)|                 |____6|
     _____ |J  ww| | ^ {(| |(.)%%| _____
    |10 ^ || ^ {)| |(.)%%| | |%%%||A .  |
    |^ ^ ^||(.)% | | |%%%| |_%%%>|| /.\ |
    |^ ^ ^|| | % | |_%%%O|        |(_._)|
    |^ ^ ^||__%%[|                |  |  |
    |___0I|                       |____V|
                               _____
   _____                _____ |6    |
  |2    | _____        |5    || & & | 
  |  &  ||3    | _____ | & & || & & | _____
  |     || & & ||4    ||  &  || & & ||7    |
  |  &  ||     || & & || & & ||____9|| & & | _____
  |____Z||  &  ||     ||____S|       |& & &||8    | _____
         |____E|| & & |              | & & ||& & &||9    |
                |____h|              |____L|| & & ||& & &|
                            _____           |& & &||& & &|
                    _____  |K  WW|          |____8||& & &|
            _____  |Q  ww| | o {)|                 |____6|
     _____ |J  ww| | o {(| |o o%%| _____
    |10 & || o {)| |o o%%| | |%%%||A _  |
    |& & &||o o% | | |%%%| |_%%%>|| ( ) |
    |& & &|| | % | |_%%%O|        |(_'_)|
    |& & &||__%%[|                |  |  |
    |___0I|                       |____V|
                               _____
   _____                _____ |6    |
  |2    | _____        |5    || v v | 
  |  v  ||3    | _____ | v v || v v | _____
  |     || v v ||4    ||  v  || v v ||7    |
  |  v  ||     || v v || v v ||____9|| v v | _____
  |____Z||  v  ||     ||____S|       |v v v||8    | _____
         |____E|| v v |              | v v ||v v v||9    |
                |____h|              |____L|| v v ||v v v|
                            _____           |v v v||v v v|
                    _____  |K  WW|          |____8||v v v|
            _____  |Q  ww| |   {)|                 |____6|
     _____ |J  ww| |   {(| |(v)%%| _____
    |10 v ||   {)| |(v)%%| | v%%%||A_ _ |
    |v v v||(v)% | | v%%%| |_%%%>||( v )|
    |v v v|| v % | |_%%%O|        | \ / |
    |v v v||__%%[|                |  .  |
    |___0I|                       |____V|
                               _____
   _____                _____ |6    |
  |2    | _____        |5    || o o | 
  |  o  ||3    | _____ | o o || o o | _____
  |     || o o ||4    ||  o  || o o ||7    |
  |  o  ||     || o o || o o ||____9|| o o | _____
  |____Z||  o  ||     ||____S|       |o o o||8    | _____
         |____E|| o o |              | o o ||o o o||9    |
                |____h|              |____L|| o o ||o o o|
                            _____           |o o o||o o o|
                    _____  |K  WW|          |____8||o o o|
            _____  |Q  ww| | /\{)|                 |____6|
     _____ |J  ww| | /\{(| | \/%%| _____
    |10 o || /\{)| | \/%%| |  %%%||A ^  |
    |o o o|| \/% | |  %%%| |_%%%>|| / \ |
    |o o o||   % | |_%%%O|        | \ / |
    |o o o||__%%[|                |  .  |
    |___0I|                       |____V|

*/
    public class CardRenderer
    {
        public const string ORIGINAL_AUTOR = @"ejm98";
        public const string ORIGINAL_SOURCE = @"https://www.asciiart.eu/miscellaneous/playing-cards";
        private const int CARD_HEIGHT = 6;
        private static readonly string[] cardBack =
        {
            @" _____ ",
            @"|\ ~ /|",
            @"|}}:{{|",
            @"|}}:{{|",
            @"|}}:{{|",
            @"|/_~_\|",
        };
        private static readonly ConsoleColor BackColor = ConsoleColor.Magenta;
        private static readonly Dictionary<Card, string[]> grafiCards = new Dictionary<Card, string[]>()
        {
            // SPADES
            { new (Symbol.Spades, Value.Ace), new string[6] {
                @" _____ ", 
                @"|A .  |", 
                @"| /.\ |", 
                @"|(_._)|", 
                @"|  |  |", 
                @"|____V|"
            } }, { new (Symbol.Spades, Value.Two), new string[6] {
                @" _____ ",
                @"|2    |",
                @"|  ^  |",
                @"|     |",
                @"|  ^  |",
                @"|____Z|"
            } }, { new (Symbol.Spades, Value.Three), new string[6] {
                @" _____ ",
                @"|3    |",
                @"| ^ ^ |",
                @"|     |",
                @"|  ^  |",
                @"|____E|"
            } }, { new (Symbol.Spades, Value.Four), new string[6] {
                @" _____ ",
                @"|4    |",
                @"| ^ ^ |",
                @"|     |",
                @"| ^ ^ |",
                @"|____h|"
            } }, { new (Symbol.Spades, Value.Five), new string[6] {
                @" _____ ",
                @"|5    |",
                @"| ^ ^ |",
                @"|  ^  |",
                @"| ^ ^ |",
                @"|____S|"
            } }, { new (Symbol.Spades, Value.Six), new string[6] {
                @" _____ ",
                @"|6    |",
                @"| ^ ^ |",
                @"| ^ ^ |",
                @"| ^ ^ |",
                @"|____9|"
            } }, { new (Symbol.Spades, Value.Seven), new string[6] {
                @" _____ ",
                @"|7    |",
                @"| ^ ^ |",
                @"|^ ^ ^|",
                @"| ^ ^ |",
                @"|____L|"
            } }, { new (Symbol.Spades, Value.Eight), new string[6] {
                @" _____ ",
                @"|8    |",
                @"|^ ^ ^|",
                @"| ^ ^ |",
                @"|^ ^ ^|",
                @"|____8|"
            } }, { new (Symbol.Spades, Value.Nine), new string[6] {
                @" _____ ", 
                @"|9    |",
                @"|^ ^ ^|",
                @"|^ ^ ^|",
                @"|^ ^ ^|",
                @"|____6|"
            } }, { new (Symbol.Spades, Value.Ten), new string[6] {
                @" _____ ",
                @"|10 ^ |",
                @"|^ ^ ^|",
                @"|^ ^ ^|",
                @"|^ ^ ^|",
                @"|___0I|"     
            } }, { new (Symbol.Spades, Value.Jack), new string[6] {
                @" _____ ",
                @"|J  ww|",
                @"| ^ {)|",
                @"|(.)% |",
                @"| | % |",
                @"|__%%[|"
            } }, { new (Symbol.Spades, Value.Quuen), new string[6] {        
                @" _____ ",
                @"|Q  ww|",
                @"| ^ {(|",
                @"|(.)%%|",
                @"| |%%%|",
                @"|_%%%O|"
            } }, { new (Symbol.Spades, Value.King), new string[6] {  
                @" _____ ",
                @"|K  WW|",
                @"| ^ {)|",
                @"|(.)%%|",
                @"| |%%%|",
                @"|_%%%>|"      
            } },


            // DIAMONDS
            { new (Symbol.Diamonds, Value.Ace), new string[6] {
                @" _____ ", 
                @"|A ^  |",
                @"| / \ |",
                @"| \ / |",
                @"|  .  |", 
                @"|____V|"
            } }, { new (Symbol.Diamonds, Value.Two), new string[6] {
                @" _____ ",              
                @"|2    |",       
                @"|  o  |",
                @"|     |",
                @"|  o  |",
                @"|____Z|",             
            } }, { new (Symbol.Diamonds, Value.Three), new string[6] {
                @" _____ ",
                @"|3    |",
                @"| o o |",
                @"|     |",
                @"|  o  |",
                @"|____E|",
            } }, { new (Symbol.Diamonds, Value.Four), new string[6] {
                @" _____ ",
                @"|4    |",
                @"| o o |",
                @"|     |",
                @"| o o |",
                @"|____h|",
            } }, { new (Symbol.Diamonds, Value.Five), new string[6] {
                @" _____ ",
                @"|5    |",
                @"| o o |",
                @"|  o  |",
                @"| o o |",
                @"|____S|",
            } }, { new (Symbol.Diamonds, Value.Six), new string[6] {
                @" _____ ",     
                @"|6    |",             
                @"| o o |",                     
                @"| o o |",                         
                @"| o o |",
                @"|____9|",
            } }, { new (Symbol.Diamonds, Value.Seven), new string[6] {
                @" _____ ",
                @"|7    |",
                @"| o o |",
                @"|o o o|",
                @"| o o |",
                @"|____L|",
            } }, { new (Symbol.Diamonds, Value.Eight), new string[6] {
                @" _____ ",
                @"|8    |",
                @"|o o o|",
                @"| o o |",
                @"|o o o|",
                @"|____8|",
            } }, { new (Symbol.Diamonds, Value.Nine), new string[6] {
                @" _____ ",
                @"|9    |",
                @"|o o o|",
                @"|o o o|",
                @"|o o o|",
                @"|____6|",
            } }, { new (Symbol.Diamonds, Value.Ten), new string[6] {
                @" _____ ", 
                @"|10 o |",
                @"|o o o|",
                @"|o o o|",
                @"|o o o|",
                @"|___0I|",
            } }, { new (Symbol.Diamonds, Value.Jack), new string[6] {
                @" _____ ",
                @"|J  ww|",
                @"| /\{)|",
                @"| \/% |",
                @"|   % |",
                @"|__%%[|",
            } }, { new (Symbol.Diamonds, Value.Quuen), new string[6] {
                @" _____ ",
                @"|Q  ww|",
                @"| /\{(|",
                @"| \/%%|",
                @"|  %%%|",
                @"|_%%%O|",
            } }, { new (Symbol.Diamonds, Value.King), new string[6] {
                @" _____ ",
                @"|K  WW|",
                @"| /\{)|",
                @"| \/%%|",
                @"|  %%%|",
                @"|_%%%>|",
            } } ,


            // CLUBS
            { new (Symbol.Clubs, Value.Ace), new string[6] {
                @" _____ ",
                @"|A _  |",
                @"| ( ) |",
                @"|(_'_)|",
                @"|  |  |",
                @"|____V|",
            } }, { new (Symbol.Clubs, Value.Two), new string[6] {
                @" _____ ",              
                @"|2    |",
                @"|  &  |",
                @"|     |",
                @"|  &  |",
                @"|____Z|",                   
            } }, { new (Symbol.Clubs, Value.Three), new string[6] {
                @" _____ ",       
                @"|3    |",
                @"| & & |",
                @"|     |",
                @"|  &  |",
                @"|____E|",
            } }, { new (Symbol.Clubs, Value.Four), new string[6] {
                @" _____ ",
                @"|4    |",
                @"| & & |",
                @"|     |",
                @"| & & |",              
                @"|____h|",              
            } }, { new (Symbol.Clubs, Value.Five), new string[6] {
                @" _____ ",
                @"|5    |",
                @"| & & |",
                @"|  &  |",
                @"| & & |",
                @"|____S|",       
            } }, { new (Symbol.Clubs, Value.Six), new string[6] {
                @" _____ ",
                @"|6    |",
                @"| & & |", 
                @"| & & |",
                @"| & & |",
                @"|____9|",
            } }, { new (Symbol.Clubs, Value.Seven), new string[6] {
                @" _____ ",
                @"|7    |",
                @"| & & |",
                @"|& & &|",
                @"| & & |",
                @"|____L|",
            } }, { new (Symbol.Clubs, Value.Eight), new string[6] {
                @" _____ ",
                @"|8    |",
                @"|& & &|",
                @"| & & |",
                @"|& & &|",
                @"|____8|",
            } }, { new (Symbol.Clubs, Value.Nine), new string[6] {
                @" _____ ",
                @"|9    |",
                @"|& & &|",
                @"|& & &|",
                @"|& & &|",
                @"|____6|",
            } }, { new (Symbol.Clubs, Value.Ten), new string[6] {
                @" _____ ",
                @"|10 & |",
                @"|& & &|",
                @"|& & &|",
                @"|& & &|",
                @"|___0I|",   
            } }, { new (Symbol.Clubs, Value.Jack), new string[6] {                    
                @" _____ ", 
                @"|J  ww|", 
                @"| o {)|", 
                @"|o o% |", 
                @"| | % |", 
                @"|__%%[|",  
            } }, { new (Symbol.Clubs, Value.Quuen), new string[6] {              
                @" _____ ", 
                @"|Q  ww|", 
                @"| o {(|", 
                @"|o o%%|", 
                @"| |%%%|", 
                @"|_%%%O|",  
            } }, { new (Symbol.Clubs, Value.King), new string[6] {      
                @" _____ ",          
                @"|K  WW|",          
                @"| o {)|",                 
                @"|o o%%|",
                @"| |%%%|",
                @"|_%%%>|",
            } }, 
            

            // HEARTS
            { new (Symbol.Hearts, Value.Ace), new string[6] {
                @" _____ ", 
                @"|A_ _ |", 
                @"|( v )|", 
                @"| \ / |", 
                @"|  .  |", 
                @"|____V|"
            } }, { new (Symbol.Hearts, Value.Two), new string[6] {   
                @" _____ ",              
                @"|2    |",
                @"|  v  |",
                @"|     |",
                @"|  v  |",
                @"|____Z|",
            } }, { new (Symbol.Hearts, Value.Three), new string[6] {
                @" _____ ",       
                @"|3    |",
                @"| v v |",
                @"|     |",
                @"|  v  |",
                @"|____E|",
            } }, { new (Symbol.Hearts, Value.Four), new string[6] {
                @" _____ ",
                @"|4    |",
                @"| v v |",
                @"|     |",
                @"| v v |",              
                @"|____h|",              
            } }, { new (Symbol.Hearts, Value.Five), new string[6] {
                @" _____ ",
                @"|5    |",
                @"| v v |",
                @"|  v  |",
                @"| v v |",
                @"|____S|",       
            } }, { new (Symbol.Hearts, Value.Six), new string[6] {
                @" _____ ",
                @"|6    |",
                @"| v v |", 
                @"| v v |",
                @"| v v |",
                @"|____9|",
            } }, { new (Symbol.Hearts, Value.Seven), new string[6] {
                @" _____ ",
                @"|7    |",
                @"| v v |",
                @"|v v v|",
                @"| v v |",
                @"|____L|",
            } }, { new (Symbol.Hearts, Value.Eight), new string[6] {
                @" _____ ",
                @"|8    |",
                @"|v v v|",
                @"| v v |",
                @"|v v v|",
                @"|____8|",
            } }, { new (Symbol.Hearts, Value.Nine), new string[6] {
                @" _____ ",
                @"|9    |",
                @"|v v v|",
                @"|v v v|",
                @"|v v v|",
                @"|____6|",
            } }, { new (Symbol.Hearts, Value.Ten), new string[6] {
                @" _____ ",
                @"|10 v |",
                @"|v v v|",
                @"|v v v|",
                @"|v v v|",
                @"|___0I|", 
            } }, { new (Symbol.Hearts, Value.Jack), new string[6] {     
                @" _____ ", 
                @"|J  ww|", 
                @"|   {)|", 
                @"|(v)% |", 
                @"| v % |", 
                @"|__%%[|",             
            } }, { new (Symbol.Hearts, Value.Quuen), new string[6] {      
                @" _____ ", 
                @"|Q  ww|", 
                @"|   {(|", 
                @"|(v)%%|", 
                @"| v%%%|", 
                @"|_%%%O|",        
            } }, { new (Symbol.Hearts, Value.King), new string[6] {  
                @" _____ ",          
                @"|K  WW|",          
                @"|   {)|",                 
                @"|(v)%%|",
                @"| v%%%|",
                @"|_%%%>|",
            } }
        };
        private static readonly Dictionary<Symbol, ConsoleColor> colorPallete = new Dictionary<Symbol, ConsoleColor>()
        {
            { Symbol.Hearts,    ConsoleColor.Red},       
            { Symbol.Diamonds,  ConsoleColor.Red},
            { Symbol.Spades,    ConsoleColor.DarkGray},   
            { Symbol.Clubs,     ConsoleColor.DarkGray},

            /*{ Symbol.Back,      ConsoleColor.White},*/
        };
        public static void SingleCardGrafic(Card card)
        {
            ConsoleColor color = Console.ForegroundColor;

            if (card.Readable)
            {
                Console.ForegroundColor = colorPallete[card.Symbol];
                foreach (string line in grafiCards[card])
                    Console.WriteLine(line);
            }
            else
            {
                Console.ForegroundColor = BackColor;
                foreach (string line in cardBack)
                    Console.WriteLine(line);
            }
            Console.ForegroundColor = color;
        }
        public static void MultiCardGrafic(List<Card> cards, string space = " ")
        {
            ConsoleColor color = Console.ForegroundColor;
            for (int i = 0; i < CARD_HEIGHT; i++)
            {
                foreach (Card card in cards)
                {
                    if (card.Readable)
                    {

                        Console.ForegroundColor = colorPallete[card.Symbol];
                        Console.Write(grafiCards[card][i] + space);
                    }
                    else
                    {
                        Console.ForegroundColor = BackColor;
                        Console.Write(cardBack[i] + space);
                    }    
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = color;
        }
    }
}