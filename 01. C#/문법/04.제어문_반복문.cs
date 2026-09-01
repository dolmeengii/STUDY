using System.Diagnostics;

class Program
{
    static void main()
    {
        // 01. while (조건문)
        int i = 0;

        while (i < 10)
        {
            Debug.Log(i);
            i += 2;
        }

        // 예시 코드
        float thickness = 0.0001f;
        int count = 0;

        while(thickness <= 1)
        {
            count++;
            thickness *= 2;
        }
        Debug.Log(count + "번 접었습니다.");


        // 02. do~while
        // 일단 한번은 실행 후 조건문을 확인한다.
        int j = 100;
        do
        {
            Debug.Log(j);
        } while (j < 10);
        
        // 03. break, continue
        // break 는 제어문을 빠져나가게 하는 장치
        // continue 는 다음 문장들을 무시하고 제어문의 다음 회차로 넘어감.
        float thickness01 = 0.0001f;
        int count = 0;

        while(thickness01 <= 1)
        {
            count++;
            thickness01 *= 2;

            if (thickness01 > 0.5f)
                break;
        }
        Debug.Log(count + "번 접었습니다.");



        // 04. for 반복문
        // for(초기화; 반복조건; 반복 명령어 ){ 실행문 }
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i);
        }

        for (int i = 0; i < 10; i++)
        {
            string str = "";

            for (int j = 0; j < i; j++)
            {
                str += "*";
            }
            Debug.Log(str);
        }

        // 05. foreach
        // foreach(데이터타입 변수명 in 배열명){}
        // foreach(데이터타입 변수명 in 컬렉션명){}
        int[] a = { 2, 4, 5, 7, 9 };

        foreach (int i in a)
        {
            Console.WriteLine(i);
        }

        int[,] b = { { 2, 4, 5, 7, 9 }, { 1, 2, 3, 5 } };

        foreach (int i in b)
        {
            Console.WriteLine(i);
        }

        // 가변배열
        int[][] array = new int[3][];

        array[0] = new int[3] {0,1,2};
        array[1] = new int[5] { 1, 2, 3, 4, 5 };
        array[2] = new int[2] { 1, 2 };

        foreach (int[] i in array)
        {
            foreach (int j in array)
            {
                Console.WriteLine(j);
            }
        }

        List<string> names = new List<string>();

        names.Add("젤다");
        names.Add("데이브");
        names.Add("커비");

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }


        // dictionary 에서 foreach
        Dictionary<string, int> scores = new Dictionary<string, int>();
        scores.Add("젤다", 20);
        scores.Add("데이브", 10);
        scores.Add("커비", 30);

        foreach (KeyValuePair<string, int> score in scores)
        {
            Console.WriteLine(score);
            Console.WriteLine(score.Key);
            Console.WriteLine(score.Value);
        }

        foreach (string key in scores.keys)
        {
            Console.WriteLine(key);
            Console.WriteLine(scores[key]);
        }
    }
}