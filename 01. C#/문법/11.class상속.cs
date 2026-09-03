/* 상속
- 확장과 같은 개념. 
- 특징을 이어 받음. 

코드의 재사용성이 높아짐.
*/

public class Character
{
    string name;
    int hp;

    public Character()
    {
        // 기본 생성자 - 자식 클래스에서 어떠한 생성자를 정의하지 않아도 오류가 나지 않음. 
        // 아래와 같은 생성자를 하나라도 정의하면 이 기본 생성자는 생성되지 않는데, 만약 아무런 생성자도 정의하지 않으면 해당 기본 생성자가 정의됨. 
    }

    // 클래스와 이름이 같은 함수는 처음 클래스의 인스턴스가 생성될 떄 실행됨. - 생성자.
    public Character(string characterName, int initialHP)
    {
        name = characterName;
        hp = initialHP;
    }

    public void Hit(int damage)
    {
        hp -= damage;
    }

    public void Heal(int heal)
    {
        hp += heal;
    }

    public bool isAlive()
    {
        return hp > 0;
    }

    public void Eat(Food food)
    {
        if (isAlive())
            hp += food.hp;
    }
}

// wizard 는 character의 자식 클래스
public class Wizard : Character
{

    /* Character 클래스 (부모 클래스) 에 기본 생성자가 없다면 정의해줘야 함. 
    public Wizard(string characterName, int initialHP) : base(characterName, initialHP)
    {
        // :base 이후도 모두 상속 받는다는 의미. 
    }
    */

    int mp;

    public void AddMP(int mp)
    {
        this.mp = mp; // 상위에 선언된 mp 를 사용하게 됨. 
    }

    public void UseMagic()
    {
        if (mp > 5)
        {
            mp -= 5;
            Console.WriteLine("마법");
        }
    }


}

public class Program
{
    static void Main()
    {
        Wizard kiss = new Wizard();
        kiss.AddMP(10);

        kiss.UseMagic();
        kiss.Hit(10);

        Character someone = kiss; // wizard 객체를 character 객체에 할당할 수 있다.

        Console.WriteLine(someone is Wizard); // True/False 로 반환되는 Is 문법.  - True 반환
        Console.WriteLine(someone is Character); // True 반환

        Wizard someWizard = someone; // 오류 발생 - 타입을 확실히 정의할 수 없다. 

        // 위와 같은 오류를 해결하기 위한 방법 2가지
        Wizard someWizard = (Wizard)someone; // 타입캐스팅
        someWizard = someone as Wizard; // as 문법

        //----------------  타입캐스팅과 as 문법의 차이  ---------------
        Character someCharacter = new Character();

        Wizard someWizard = (Wizard)someCharacter;
        Console.WriteLine(someWizard); // 오류 반환

        Wizard someWizard = someCharacter as Wizard;
        Console.WriteLine(someWizard); // Null 반환
    }
}