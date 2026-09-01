class Program
{
    static void Main ()
    {
        int year = 2024;

        if ( year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
        {
            Console.WriteLine("{0}년은 윤년입니다.", year);
        }
        else
        {
            Console.WriteLine("{0}년은 윤년이 아닙니다.", year);
        }
    }
}