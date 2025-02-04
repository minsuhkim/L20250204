namespace L20250204
{
    internal class Program
    {
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

        static void Main(string[] args)
        {
            //int size = 52;
            //int[] numbers = new int[size];
            //Random rnd = new Random();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = i + 1;
            //}

            //int[] rndNums = new int[8];
            //int index = 0;
            //for (int i = 0; i < 8; i++)
            //{
            //    //랜덤한 정수 생성
            //    int rndNum = numbers[rnd.Next(numbers.Length)];
            //    //중복 체크
            //    /*
            //     * 최적화 >> 이중 반복으로 중복을 체크하는 것보다는 중복 체크용 bool 배열을 하나 만들어서 체크하는 게 시간이 덜 걸릴 듯 함
            //     *        >> Random.Shuffle 함수를 사용해서 배열을 섞어서 출력하는 방법도 있음
            //     */
            //    bool check = false;
            //    for (int j = 0; j < index; j++)
            //    {
            //        if (rndNums[j] == rndNum)
            //        {
            //            check = true;
            //            break;
            //        }
            //    }
            //    //만약 중복한다면 다시 반복
            //    if (check)
            //    {
            //        i--;
            //    }
            //    //중복하지 않는다면 넘어감
            //    else
            //    {
            //        rndNums[index++] = rndNum;
            //    }
            //}
            ////출력
            //for (int i = 0; i < 8; i++)
            //{
            //    Console.WriteLine(rndNums[i]);
            //}

            // 1-13 >> Heart 1 A 2~10은 숫자 11 J 12 Q 13 K
            // 14-26 >> Diamond 
            // 27-39 >> Clover
            // 40-52 >> Spade

            int[] deck = new int[52];

            for (int i = 0; i < deck.Length; i++)
            {
                deck[i] = i;
            }

            Random random = new Random();
            random.Shuffle(deck);

            int pickNum = deck[0];
            int number = pickNum % 13 + 1;
            string shape = Shape(pickNum);
            Console.WriteLine($"뽑은 숫자: {pickNum + 1}");
            Console.Write(shape + " ");
            if(number >0 && number < 10)
            {
                Console.WriteLine(number);
            }
            else
            {
                if(number == 1)
                {
                    Console.WriteLine("Ace");
                }
                else if(number == 11)
                {
                    Console.WriteLine("Junior");
                }
                else if (number == 12)
                {
                    Console.WriteLine("Queen");
                }
                else if (number == 13)
                {
                    Console.WriteLine("King");
                }
            }
        }
    }
}
