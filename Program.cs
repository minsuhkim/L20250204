namespace L20250204
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 52;
            int[] numbers = new int[size];
            Random rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            int[] rndNums = new int[8];
            int index = 0;
            for (int i = 0; i < 8; i++)
            {
                //랜덤한 정수 생성
                int rndNum = numbers[rnd.Next(numbers.Length)];
                //중복 체크
                /*
                 * 최적화 >> 이중 반복으로 중복을 체크하는 것보다는 중복 체크용 bool 배열을 하나 만들어서 체크하는 게 시간이 덜 걸릴 듯 함
                 *        >> Random.Shuffle 함수를 사용해서 배열을 섞어서 출력하는 방법도 있음
                 */
                bool check = false;
                for (int j = 0; j < index; j++)
                {
                    if (rndNums[j] == rndNum)
                    {
                        check = true;
                        break;
                    }
                }
                //만약 중복한다면 다시 반복
                if (check)
                {
                    i--;
                }
                //중복하지 않는다면 넘어감
                else
                {
                    rndNums[index++] = rndNum;
                }
            }
            //출력
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(rndNums[i]);
            }
        }
    }
}
