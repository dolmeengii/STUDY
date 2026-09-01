using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1부터 1000까지의 수 중에서 0과 5로만 이루어진 수를 찾아 리스트에 넣고 출력한다.

        List<int> list = new List<int>();

        for (int i = 1; i <= 1000; i++)
        {
            int number = i;
            bool consistsOfZeroAndFive = true;

            while (number > 0)
            {
                int digit = number % 10;

                if (digit != 0 && digit != 5)
                {
                    consistsOfZeroAndFive = false;
                    break;
                }

                number /= 10;
            }

            if (consistsOfZeroAndFive)
            {
                list.Add(i);
            }
        }

        foreach (int number in list)
        {
            Console.WriteLine(number);
        }
    }
}
