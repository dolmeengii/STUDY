class Program
{
    static void Main ()
    {
        int a = 10;

        if (a > 0)
        {
            Console.WriteLine("a는 양수입니다.");
        }
        else if (a < 0)
        {
            Console.WriteLine("a는 음수입니다.");
        }
        else
        {
            Console.WriteLine("a는 0입니다.");
        }
    }
}