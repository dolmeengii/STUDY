/* 인터페이스
- 추상 메소드와 비슷함. 
- 구현해줄 클래스가 필요함. 
*/

// 인터페이스 선언시 관습적으로 '대문자 I' 를 붙여준다. 클래스와 구분하기 위함. 
public interface ITurnOnable
{
    public void TurnOn();
    public void TurnOff();
}

// 만약, 상속과 인터페이스 모두 구현해야한다면 : 이후에 열거하여 사용하면 된다. 
// ex) public class Car : Machine, ITurnOnable
// 부모는 하나, 인터페이스는 여러개 가능. 
public class Car : ITurnOnable
{
    public void TurnOn()
    {
        Console.WriteLine("시동 걸어");
    }
    public void TurnOff()
    {
        Console.WriteLine("시동 꺼");
    }
}

public class TV : ITurnOnable
{
    public void TurnOn()
    {
        Console.WriteLine("TV 켜");
    }
    public void TurnOff()
    {
        Console.WriteLine("TV 꺼");
    }
}


public class Program
{
    static void Main()
    {
        Car jeep = new Car();
        jeep.TurnOn();

        ITurnOnable someCar = new Car();
        someCar.TurnOn();
    }
}