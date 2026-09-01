class Program
{
    static void Main()
    {
        // 크기 10의 정수 배열을 만들고, 원하는 수를 넣어 초기화한다. 
        // 그 배열에 저장된 수의 순서를 뒤집는다. 

        int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        for (int i = 0; i < array.Length / 2; i++)
        {
            int opposite = array.Length - 1 - i;

            int save = array[i];
            array[i] = array[opposite];
            array[opposite] = save;

        }

        Console.WriteLine(string.Join(", ", array));
    }
}