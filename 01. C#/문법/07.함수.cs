
public class Program
{
    // 결과값을 반환하지 않는 함수는 void 형으로 선언한다. 
    // void 의 경우 return 을 사용하여 함수를 바로 종료시킬 수 있다. 
    static void Main()
    {
        Console.WriteLine(Square(4));
    }

    // C# 에서는 함수 이름은 대문자로 시작하는 관습
    static int Square(int x)
    {
        return x * x;
    }

    void Like(int n)
    {
        int y = 5;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("좋아요");
        }

        n = 5;
    }

    void Subscription(ref int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("구독");
        }

        n = 5;
    }

    void Test(out int n)
    {
        n = 5;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("구독");
        }

    }

    void Test2(string message, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(message);
        }
    }

    void Test3(string message, int n = 3)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(message);
        }
    }

    void Test4(params string[] message)
    {
        foreach (string s in message)
        {
            Console.WriteLine(message);
        }
    }


    void Start()
    {
        int x = 3;
        Console.WriteLine(x);
        Like(x);
        Console.WriteLine(x);
        Console.WriteLine(y); // 함수 스코프 내 변수 처리 확인
        Subscription(ref x); // ref 를 참조해주면 주소와 값을 모두 넘겨받아, 스코프가 다르더라도 변수를 변경할 수 있음. (지양)
        Test(out x); // out으로 파라미터를 보낼 떄에는 주소만 넘겨받아서 해당 주소에 변수의 값을 저장한다. 

        Test2("좋아요", 5);
        Test3("좋아요"); // 두번쨰 인수를 지정하지 않으면 default parameter 인 n = 3 이 대입되어 실행된다. 

        Test4("hi", "hello", "안녕하세요"); // params 로 지정하여 파라미터를 선언하게 되면, 개수가 지정되지 않은 자료형을 인수로 받을 수 있다. 
    }
}
