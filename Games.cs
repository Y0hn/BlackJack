namespace Casino
{
    public class BlackGame
    {
        public static void Play(int times = -1)
        {
            Dictionary<string, byte> winnerBoard = new();
            
            while (times != 0)  // default is relatively infinit
            {
                string winner = WithDealer();

                if (winnerBoard.ContainsKey(winner))
                    winnerBoard[winner]++;
                else
                    winnerBoard.Add(winner, 1);
                
                foreach (KeyValuePair<string, byte> row in winnerBoard)
                    Console.WriteLine($"{row.Key} won {row.Value} times");

                Console.ReadKey();
                times--;
            }
        }
        private static string WithDealer()
        {
            Console.ForegroundColor = ConsoleColor.White;
            CardStack cardStack= new();


            BlackHand player = new("Hrac");
            BlackDealer dealer = new();
            
            dealer.Add(cardStack.PickCard());
            dealer.Add(cardStack.PickCard());
            dealer.Add(cardStack.PickCard());
            dealer.RevalNext();

            player.Add(cardStack.PickCard());
            player.Add(cardStack.PickCard());
            player.RevalNext();
            player.RevalNext();

            bool loopCut = false;
            while (!(player.Folded && dealer.Folded))
            {
                Console.Clear();
                dealer.WriteOut();                
                Console.WriteLine();
                player.WriteOut();
                
                if (loopCut) break;
                if (!player.Folded && !dealer.Victory)
                {
                    // HRAC
                    Console.Write("\n\nChces tahat [Y/n] :");
                    string? s = Console.ReadLine()?.Trim().ToLower();
                    if (s != null && s == "n")
                    {
                        player.Folded = true;
                    }
                    else
                    {
                        //draw = true;
                        player.Add(cardStack.PickCard());
                        player.RevalNext();
                    }
                }
                
                Console.Clear();
                dealer.WriteOut();                
                Console.WriteLine();
                player.WriteOut();

                // DEALER
                if (!dealer.Folded)
                {
                    if (!player.Folded || player.CanPlay)
                    {
                        if (!dealer.RevalNext())
                        {                            
                            dealer.Add(cardStack.PickCard());
                            dealer.RevalNext();
                        } 
                    }
                    else
                        break;
                }
            }
            
            Console.Clear();
            dealer.WriteOut();                
            Console.WriteLine();
            player.WriteOut();

            string? r = BlackHand.GetWinner(player, dealer)?.Name;
            r ??= "";
            return r;
        }
    }
}