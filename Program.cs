namespace L20250204
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 52;
            int[] numbers = new int[size];
            System.Random rnd = new System.Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i+1;
            }

            int[] rndNums = new int[8];
            int index = 0;
            for(int i=0; i<8; i++)
            {
                //랜덤한 정수 생성
                int rndNum = numbers[rnd.Next(numbers.Length)];
                //중복 체크
                bool check = false;
                for(int j=0; j<index; j++)
                {
                    if(rndNums[j] == rndNum)
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
            for(int i=0; i<8;i++)
            {
                Console.WriteLine(rndNums[i]);
            }
        }
    }
}
