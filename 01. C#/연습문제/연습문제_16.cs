class Program
{
    static void Main()
    {
        // 1차원 정수 배열에 수를 채운다. 그 수를 작은수부터 큰 수 순서로 정렬한다.

        int[] a = new int[10] { 21, 12, 3, 34, 65, 16, 87, 98, 9, 10 };

        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a.Length - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    int save = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = save;
                }
            }
        }

        foreach (int number in a)
        {
            Console.WriteLine(number);
        }
    }
}