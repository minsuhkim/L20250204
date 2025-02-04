namespace L20250204
{
    internal class Program
    {
        enum CardType
        {
            None = -1,
            Heart,
            Diamond,
            Clover,
            Spade
        }

        static CardType CheckCardType(int cardNumber)
        {
            int valueType = (cardNumber - 1) / 13;
            return (CardType)valueType;
        }

        static void Initialize(int[] deck)
        {
            for (int i = 0; i < deck.Length; i++)
            {
                deck[i] = i + 1;
            }
        }

        static void Shuffle(int[] deck)
        {
            Random random = new Random();
            random.Shuffle(deck);
        }

        static void Print(int[] deck)
        {
            int computerScore = GetCardNumber(deck[0]) + GetCardNumber(deck[1]) + GetCardNumber(deck[2]);
            int playerScore = GetCardNumber(deck[3]) + GetCardNumber(deck[4]) + GetCardNumber(deck[5]);

            Console.WriteLine("컴퓨터가 뽑은 카드");
            for(int i=0; i<3; i++)
            {
                Console.WriteLine($"{CheckCardType(deck[i])} {CheckCardName(deck[i])}" );
            }
            Console.WriteLine();

            Console.WriteLine("플레이어가 뽑은 카드");
            for (int i = 3; i < 6; i++)
            {
                Console.WriteLine($"{CheckCardType(deck[i])} {CheckCardName(deck[i])}");
            }
            Console.WriteLine();

            Console.WriteLine($"Computer Score: {computerScore} / Player Score: {playerScore}");
            Console.WriteLine();

            Verdict(computerScore, playerScore);
        }

        static void Verdict(int computerScore, int playerScore)
        {
            if (computerScore > 21)
            {
                Console.WriteLine("Player Win!");
            }
            else if (playerScore > 21)
            {
                Console.WriteLine("Computer Win!");
            }
            else
            {
                if (computerScore > playerScore)
                {
                    Console.WriteLine("Computer Win!");
                }
                else
                {
                    Console.WriteLine("Player Win!");
                }
            }
        }

        static string CheckCardName(int cardNumber)
        {
            int cardValue = (cardNumber - 1) % 13 + 1;
            string cardName;

            switch (cardValue)
            {
                case 1:
                    cardName = "A";
                    break;
                case 11: 
                    cardName = "J";
                    break;
                case 12:
                    cardName= "Q";
                    break;
                case 13:
                    cardName = "K";
                    break;
                default:
                    cardName = cardValue.ToString();
                    break;
            }
            return cardName;            
        }

        static int GetCardNumber(int cardNumber)
        {
            int cardValue = (cardNumber - 1) % 13 + 1;
            if(cardValue > 10)
            {
                cardValue = 10;
            }
            return cardValue;
        }

        static void Main(string[] args)
        {
            // 1-13 >> Heart 1 A 2~10은 숫자 11 J 12 Q 13 K
            // 14-26 >> Diamond 
            // 27-39 >> Clover
            // 40-52 >> Spade
            int[] deck = new int[52];

            Initialize(deck);
            Shuffle(deck);
            Print(deck);
        }
    
    }
}
