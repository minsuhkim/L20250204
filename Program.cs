namespace L20250204
{
    internal class Program
    {
        static int[] deck = new int[52];
        static int[] playerPicks = new int[2];
        static int[] enemyPicks = new int[2];

        static void Initialize()
        {
            for (int i = 0; i < deck.Length; i++)
            {
                deck[i] = i + 1;
            }

            Random random = new Random();
            random.Shuffle(deck);
        }

        static string Shape(int pickNum)
        {
            string shape = "";
            if (pickNum / 13 == 0)
            {
                shape = "Heart";
            }
            else if (pickNum / 13 == 1)
            {
                shape = "Diamond";
            }
            else if (pickNum / 13 == 2)
            {
                shape = "Clover";
            }
            else if (pickNum / 13 == 3)
            {
                shape = "Spade";
            }

            return shape;
        }

        static void PrintCard(int pickNum)
        {
            //숫자 결정
            int number = pickNum % 13;
            if(number == 0)
            {
                number = 13;
            }
            //모양 결정
            string shape = Shape(pickNum - 1);
            //Console.WriteLine($"뽑은 숫자: {pickNum}");
            Console.Write(shape + " ");

            //숫자가 2~10이면 그대로 출력
            if (number > 0 && number < 10)
            {
                Console.Write(number);
            }
            //아니면 모양 출력
            else
            {
                if (number == 1)
                {
                    Console.Write("ace");
                }
                else if (number == 11)
                {
                    Console.Write("jack");
                }
                else if (number == 12)
                {
                    Console.Write("queen");
                }
                else if (number == 13)
                {
                    Console.Write("king");
                }
                else
                {
                    Console.Write(number);
                }
            }
        }

        static void PickCard()
        {
            playerPicks[0] = deck[0];
            playerPicks[1] = deck[1];
            enemyPicks[0] = deck[2];
            enemyPicks[1] = deck[3];
        }

        static void PrintPicks()
        {
            Console.Write("플레이어가 뽑은 카드: ");
            PrintCard(playerPicks[0]);
            Console.Write(" , ");
            PrintCard(playerPicks[1]);
            Console.WriteLine();

            Console.Write("상대가 뽑은 카드: ");
            PrintCard(enemyPicks[0]);
            Console.Write(" , ");
            PrintCard(enemyPicks[1]);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // 1-13 >> Heart 1 A 2~10은 숫자 11 J 12 Q 13 K
            // 14-26 >> Diamond 
            // 27-39 >> Clover
            // 40-52 >> Spade

            Initialize();
            PickCard();
            PrintPicks();
        }
    }
}
