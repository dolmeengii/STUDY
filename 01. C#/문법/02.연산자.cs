using System.Diagnostics;

public class calculator 
{
     static void Main()
    {
        int a = 5;
        int b = 3;

        // 기본 사칙연산
        Debug.Log("Addition: " + (a + b));
        Debug.Log("Subtraction: " + (a - b));
        Debug.Log("Multiplication: " + (a * b));
        Debug.Log("Division: " + (a / b));
        Debug.Log("Modulus: " + (a % b));

        Debug.Log(5f / 3);

        // double 형과 float 형의 나눗셈 결과를 확인
        Debug.Log(5.0 / 3);
        Debug.Log(5.0f / 3);


        // 비교연산자
        Debug.Log(a < b);
        Debug.Log(a > b);
        Debug.Log(a <= b);
        Debug.Log(a >= b); 
        Debug.Log(a == b);
        Debug.Log(a != b);


        // 논리연산자

        int x = 4;
        int y = 5;
        int z = 6;
        int w = 7;

        // and, or, not 연산자
        Debug.Log(x < y && z > w);
        Debug.Log(x > y || z < w);
        Debug.Log(!(x == y));


        // 대입/할당연산자
        x = y + z;
        x = y + 2;
        x += 2;
        x -= 2;
        x *= 2;
        x /= 2;
        x %= 2;
        x++;
        x--;
        ++x;
        --x;


        // 조건연산자 (삼항연산자)
        // 변수 = (조건식) ? 참일 때 값 : 거짓일 때 값
        // 논리식의 값이 true이면 : 앞의 값, false이면 : 뒤의 값을 반환
        x = y > z ? 1 : 2;

        // ?? null 병합 연산자
        // 변수 = (변수 ?? 값)
        // 변수의 값이 null이면 ?? 뒤의 값을 반환하고, null이 아니면 변수의 값을 반환
        string str = null;
        string result = str ?? "default value";


        // 연산자 우선순위
        // 연산자 우선순위에 따라 괄호를 사용하여 명시적으로 연산 순서를 지정하는 것이 좋다.
        // 예를 들어, 아래의 연산식에서 곱셈과 나눗셈이 덧셈과 뺄셈보다 우선순위가 높기 때문에, 괄호를 사용하여 명시적으로 연산 순서를 지정하는 것이 좋다.
        int result2 = (a + b) * (x - y) / z;
        // 위의 연산식은 아래와 같이 괄호를 사용하여 명시적으로 연산 순서를 지정하는 것이 좋다.
        int result3 = ((a + b) * (x - y)) / z;
        // 우선순위 표
        // https://docs.microsoft.com/ko-kr/dotnet/csharp/language-reference/operators/
    }
}
