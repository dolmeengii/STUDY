class Program
{
    static void Main()
    {
        // 정수 리스트를 만든다. 리스트를 작은 수부터 큰 수 순서로 정렬한다.    

        List<int> a = new List<int>();

        a.Add(21);
        a.Add(12);
        a.Add(3);
        a.Add(34);
        a.Add(65);
        a.Add(16);
        a.Add(87);
        a.Add(98);
        a.Add(9);
        a.Add(10);

        for (int i = 0; i < a.Count; i++)
        {
            for (int j = 0; j < a.Count - 1; j++)
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
