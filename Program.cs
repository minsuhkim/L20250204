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
            for(int i=0; i<8; i++)
            {
                Console.WriteLine($"{CheckCardType(deck[i])} {CheckCardName(deck[i])}" );
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
