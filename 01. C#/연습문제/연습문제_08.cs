using System.Runtime.Serialization;

class Program
{
    static void Main()
    {
        // 2차원 가변배열을 만들어 정수를 저장한다.
        // 그 가변배열에 저장된 수 중, 10이 넘는 수만을 골라 리스트에 채운다.

        int[,] array = new int[5, 5];
        List<int> numbers = new List<int>();

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                array[i, j] = i * j;

                if (array[i, j] > 10)
                    numbers.Add(array[i, j]);
            }
        }
        

        foreach(int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}