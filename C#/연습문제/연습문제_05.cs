class Program
{
    static void Main()
    {
        // for (int i = 0; i < 10; i++)
        // {
        //     string str = "*";

        //     for (int j = 0; j < i; j ++)
        //     {
        //         str += "**";
        //     }

        //     Console.WriteLine(str);
        // }
    
        for (int i = 0; i < 10; i++)
        {
            string str = "";

            for (int j = 0; j < i*2 +1; j ++)
            {
                str += "*";
            }

            Console.WriteLine(str);
        }
    }
}