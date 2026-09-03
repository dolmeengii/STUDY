/* 추상 클래스
- 추상 메소드: 이름만 있고 구현이 되어있지 않은 메소드
- 추상 메소드를 하나라도 가지고 있는 클래스로, 혼자서 실행이 어렵고 구현할 자식 클래스가 필요하다. 
*/

public abstract class Animal
{
    public abstract void Fly();

    public void Introduce()
    {

        Console.WriteLine("안녕하세요 파리입니다");
    }
}

public class Bird : Animal
{
    // 추상메소드를 구현해주는 것 또한 override
    public override void Fly()
    {
        Console.WriteLine("파닥파닥");
    }
}

public class Bug : Animal
{
    public override void Fly()
    {
        Console.WriteLine("위잉위잉");
    }
}


public class Program
{
    static void Main()
    {
        // Animal animal = new Animal(); // 에러

        Bug dragonFly = new Bug();
        dragonFly.Fly();

        Bird sparrow = new Bird();
        sparrow.Fly();

        Animal someAnimal = new Bug();
        someAnimal.Fly();

    }
}