class Program
{
    static void Main()
    {
        // 5*5 크기의 boolean 2차원 배열을 만든다. 
        // a[i,j] 라고 했을때, i가 더 클때에는 true, j가 더 클때에는 false 를 반환하는 배열을 만든다. 

        bool[,] array = new bool[5, 5];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (i > j)
                    array[i, j] = true;
                else if (i < j)
                    array[i, j] = false;
            }
        }
    }
}