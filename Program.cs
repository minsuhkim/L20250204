namespace L20250204
{
    internal class Program
    {
        static int[] deck = new int[52];
        static int[] playerPicks = new int[3];
        static int[] enemyPicks = new int[3];
        static void Initialize()
        {
            for (int i = 0; i < deck.Length; i++)
            {
                deck[i] = i + 1;
            }
        }
        
        static void Shuffle()
        {
            Random random = new Random();
            random.Shuffle(deck);
        }

        static string CheckCardShape(int pickNum)
        {
            string shape = "";
            if ((pickNum - 1) / 13 == 0)
            {
                shape = "Heart";
            }
            else if ((pickNum - 1) / 13 == 1)
            {
                shape = "Diamond";
            }
            else if ((pickNum - 1) / 13 == 2)
            {
                shape = "Clover";
            }
            else if ((pickNum - 1) / 13 == 3)
            {
                shape = "Spade";
            }

            return shape;
        }

        static string CheckCardNumber(int pickNum)
        {
            int number = (pickNum - 1) % 13 + 1;
            string cardNumber = "";

            if (number >=2 && number <= 10)
            {
                cardNumber = number.ToString();
            }
            //아니면 모양 출력
            else
            {
                if (number == 1)
                {
                    cardNumber = "A";
                }
                else if (number == 11)
                {
                    cardNumber = "J";
                }
                else if (number == 12)
                {
                    cardNumber = "Q";
                }
                else if (number == 13)
                {
                    cardNumber = "K";
                }
            }

            return cardNumber;
        }

        static int GetCardNumber(int pickNum)
        {
            int number = (pickNum - 1) % 13 + 1;

            if(number > 10)
            {
                number = 10;
            }

            return number;
        }

        static void PrintCard(int pickNum)
        {
            Console.WriteLine($"{CheckCardShape(pickNum)} {CheckCardNumber(pickNum)}");           
        }

        static void PickCard()
        {
            playerPicks[0] = deck[0];
            playerPicks[1] = deck[1];
            playerPicks[2] = deck[2];
            enemyPicks[0] = deck[3];
            enemyPicks[1] = deck[4];
            enemyPicks[2] = deck[5];
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

        static void PrintScore()
        {
            int enemyScore = GetCardNumber(enemyPicks[0]) + GetCardNumber(enemyPicks[1]) + GetCardNumber(enemyPicks[2]);
            int playerScore = GetCardNumber(playerPicks[0]) + GetCardNumber(playerPicks[1]) + GetCardNumber(playerPicks[2]);

            Console.WriteLine("Computer Cards");
            PrintCard(enemyPicks[0]);
            PrintCard(enemyPicks[1]);
            PrintCard(enemyPicks[2]);
            Console.WriteLine("--------------------------");

            Console.WriteLine("Player Cards");
            PrintCard(playerPicks[0]);
            PrintCard(playerPicks[1]);
            PrintCard(playerPicks[2]);
            Console.WriteLine("--------------------------");

            Console.WriteLine($"Computer Score: {enemyScore} / Player Score: {playerScore}");

            Verdict(enemyScore, playerScore);
        }

        static void Main(string[] args)
        {
            // 1-13 >> Heart 
            // 14-26 >> Diamond 
            // 27-39 >> Clover
            // 40-52 >> Spade
            //1 A 2~10은 숫자 11 J 12 Q 13 K

            Initialize();
            Shuffle();
            PickCard();
            PrintScore();
        }
    }
}