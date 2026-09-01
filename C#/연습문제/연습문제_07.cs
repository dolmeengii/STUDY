class Program
{
    static void Main()
    {

        // 변수 a 에 초기값, 변수 b에 공비를 저장한 후 등비수열 10항을 출력한다. 
        int a = 2;
        int b = 5;


        for(int i = 0; i < 10; i++)
        {
            a *= b;
        }

        Console.WriteLine(a);
    }
}