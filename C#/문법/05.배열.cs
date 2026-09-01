
using System;

class Program
{
    static void Main()
    {
        // 배열의 선언과 초기화
        // int[] a;
        // int[] a = new int[5]; 
        int[] a = new int[5] { 2, 4, 5, 6, 7 };
        string[] str = new string[5];

        // 배열 기본값
        // 숫자형 배열: 0, 불린형 배열: false, 그외 배열: null 을 기본값으로 가진다.

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(a[i]);
        }


        // 다차원 배열
        int[,] arr = new int[2, 2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                arr[i, j] = i + j;
            }
        }

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine("i" + i + ", j" + j + "=" + arr[i, j]);
            }
        }


        // 가변 배열
        // 배열의 원소로 배열을 사용하고 있는 배열.
        // 각각의 크기가 다를 수 있음.
        int[][] array = new int[3][];

        array[0] = new int[3] {0,1,2};
        array[1] = new int[5] { 1, 2, 3, 4, 5 };
        array[2] = new int[2];
        
    }
}