class Program
{
    static void Main()
    {
        for (int i = 2; i < 10; i++)
        {
            Console.WriteLine("구구단 {0}단 시작", i);
            for (int j = 1; j < 10; j++)
            {
                Console.WriteLine(i + "*" + j + "=" + i*j);
            }
        }
    }
}