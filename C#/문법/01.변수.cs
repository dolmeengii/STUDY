using System;

public class HelloWorld ()
{
    static void Main()
    {
        Debug.Log("Hello World");

        int x = 0;
        int y = 1;

        Debug.Log("x + y = " + (x + y));

        long a = 12344578990912;
        long b = 12345667;

        Debug.Log("a + b = " + (a + b));
        // 아래와 같이 범위를 넘어선 계산의 경우 잘못된 값이 로그에 출력된다.
        // Debug.Log("a * b = " + (a * b));

        float f = 1.23456789f;
        float g = 12.3456789f;

        Debug.Log("f + g = " + (f + g));
        // 만약 자리수를 더 늘려 계산하게 된다면 출력 결과는 +16과 같이 출력된다. 
        // +16은 10의 16승을 의미하며, 이는 float 자료형이 표현할 수 있는 범위를 넘어선다는 것을 의미한다.
        // 정확한 계산 결과는 아니기 때문에, 정밀도가 높은 계산이 필요하다면 double 자료형을 사용하는 것이 좋다.

        bool e = true;
        bool d = false;

        Debug.Log("e && d = " + (e && d));
        Debug.Log((a == b).ToString());
        
        bool isEqual = (a == b);
        Debug.Log(isEqual);


        string s = "abcdefg";
        string t = "hijklmn";

        Debug.Log("s + t = " + (s + t));
        

        // null과 빈 문자열의 차이
        // null은 값이 없음을 의미하며, 빈 문자열은 길이가 0인 문자열을 의미한다.
        string str = null;
        string ing = "";

    }
}
