
class Program
{
    static void Main()
    {
        // 2*2 크기의 2차원 배열 2개를 만들어 정수를 저장한다.
        // 각 배열을 행렬이라 생각하고 행렬의 합과 행렬의 곱을 계산한다.

        int[,] A = new int[2, 2];
        int[,] B = new int[2, 2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                A[i, j] = (i + 1) * (j + 2);
                B[i, j] = i + j;
            }
        }

        int[,] sum = new int[2, 2];
        int[,] mul = new int[2, 2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                sum[i, j] = A[i, j] + B[i, j];
                mul[i, j] = A[i, 0] * B[0, j] + A[i, 1] * B[1, j];
            }
        }
    }
}