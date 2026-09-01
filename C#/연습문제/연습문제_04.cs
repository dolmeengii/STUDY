class Program
{
    static void Main()
    {
        int a = 2;
        int b = 3;

        int count = 0;

        while (a <= 1000)
        {
            a *= b;
            count++;
        }

        Console.WriteLine("횟수는 {0} 번 입니다.", count);
    }
}