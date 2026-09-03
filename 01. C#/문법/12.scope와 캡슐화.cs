/* 
유효범위:scope

캡슐화
- public : 모든 곳에서 가능
- protected : 외부에서 불가능하지만, 상속클래스에게는 가능
- private : 외부에서 불가능
- 위 세가지 중 아무것도 명시하지 않으면 기본적으로 private으로 지정됨. 

*/

public class Program
{

    int x; // 멤버변수와 같은 이름의 변수를 만들었을 때, 스코프 내의 변수를 우선으로 적용한다. 

    static void Main()
    {
        int x = 4;

        for (int i = 0; i < 10; i++)
        {
            int x = 2; // 바깥 스코프에서 x를 선언했기 때문에 여기서 재정의할 수 없음. 

            Console.WriteLine(i);
        }

        Console.WriteLine(x); // 오류 - 스코프 밖 변수


    }

    static void Hamsu()
    {
        // 다른 스코프이기 떄문에 변수 선언 및 할당 가능. 
        inx x = 2;

        this.x; // 멤버변수 x를 사용하는 방법. 
    }
}

