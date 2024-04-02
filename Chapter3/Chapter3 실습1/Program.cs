/*
9세 이상이면서, 키가 130cm 이상인 어린이는 "고속 롤러코스트 입장 가능",
9세 이상이면서, 키가 130cm 미만인 어린이는 "저속 롤러코스트 입장 가능",
9세 미만인 어린이는 "입장 불가!"를 출력하는 프로그램 작성
*/
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("나이 입력 : ");
        int age = int.Parse(Console.ReadLine());

        if (age >= 9)
        {
            Console.Write("키 입력 : ");
            int height = int.Parse(Console.ReadLine());

            if (height >= 130)
            {
                Console.WriteLine("고속 롤러코스트 입장 가능");
            }
            else
            {
                Console.WriteLine("저속 롤러코스트 입장 가능");
            }
        }
        else
        {
            Console.WriteLine("입장불가!");
        }

    }
}