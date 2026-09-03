/* 
1. 오버로드 Overload
- 같은 함수 이름이지만 다른 기능을 선언하여 사용할 수 있는 기능. 
- 단, 파라미터가 달라야 한다. 

2. 오버라이드 Override
- 상속 받은 자식 클래스의 메소드가 부모 클래스의 메소드를 덮어써서 대체하는 것

*/

public class Box
{
    // 부모클래스에서는, override 될 가능성이 있는 경우 virtual 선언
    public virtual void Introduce()
    {
        Console.WriteLine("안녕하세요 박스입니다");
    }

    public void Dump(string thing)
    {
        Dump("아무나", thing);
    }

    public void Dump(string who, string thing)
    {
        Console.WriteLine(who + "가 " + thing + "버림");
    }

    public void Dump(int number)
    {
        Console.WriteLine(number + "개 버림");
    }
}

public class Trashbin : Box
{
    // 자식클래스에서 덮어쓸 경우 override 선언
    public override void Introduce()
    {
        // 부모의 함수를 부를 때에는 base 를 사용하여 호출할 수 있다.
        base.Introduce();

        Console.WriteLine("쓰레기통입니다.");
    }
}

public class Program
{
    static void Main()
    {
        Box boxA = new Box();

        boxA.Dump("휴지");
        boxA.Dump("길동", "휴지");
        boxA.Dump(3);

        Trashbin bin = new Trashbin();
        bin.Introduce();
    }
}