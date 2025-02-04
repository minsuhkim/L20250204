namespace L20250204
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "김민서";
            string message = string.Format("{0} Hi", name);

            string datas = "10.3, 20, 30, 40";

            string[] data = datas.Split(',');

            Console.WriteLine(message.ToUpper());
            Console.WriteLine(message.Replace("Hi", "By"));

            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i].Trim());//Trim: 공백을 없애줌
            }

            //(int),(float),(char) 형변환/캐스팅
            int A = 2;
            float B = 3.50f;
            B = (float)A; // int >> float 은 명시적인 캐스팅 불필요
            A = (int)B;  // float >> int 는 명시적인 캐스팅 필요(의도적인지 아닌지 알 수 없기 때문)

            char C = (char)65;
            int.TryParse(data[1], out A);
            Console.WriteLine(A.ToString());

            Console.WriteLine(Convert.ToInt16(C));
        }
    }
}