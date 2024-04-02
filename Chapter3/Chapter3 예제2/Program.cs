// 2자리의 정수(10~99 사이)를 입력 받아 십의 자리와 1의 자리가 같은지  판별하여 출력
internal class Program
{
    private static void Main(string[] args)
    { 
        Console.Write("2자리 정수 입력 (10 ~ 99) : ");
        int num = int.Parse(Console.ReadLine());

        if (num >= 10)
        {
            if (num < 100)
            {
                if (num % 11 == 0)
                {
                    Console.WriteLine("Yes! 10의 자리와 1의 자리가 같습니다.");
                }
                else
                {
                    Console.WriteLine("No! 10의 자리와 1의 자리가 다릅니다.");
                }
            }
            else
            {
                Console.WriteLine("10 ~ 99 사이의 정수만 입력하세요.");
            }

        }
        else
        {
            Console.WriteLine("10 ~ 99 사이의 정수만 입력하세요.");
        }
    }
}