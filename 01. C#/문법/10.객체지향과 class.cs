/* 객체지향 프로그래밍
객체
클래스 - 멤버변수, 메소드
인스턴스 - 클래스를 만들어내는 것
*/

public class Character
{
    string name;
    int hp;

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

public class Food
{
    public string name;
    public int hp;


    public Food(string _name, int _hp)
    {
        name = _name;
        hp = _hp;
    }
}

public class Program
{
    static void Main()
    {
        Character Charles = new Character("Charles", 10);
        Food protein = new Food("protein", 5);

        Charles.Hit(5);
        Charles.Heal(3);

        Console.WriteLine("Is Alive? " + Charles.isAlive());

        Charles.Eat(protein);

        Charles.Hit(10);

        Console.WriteLine("Is Alive? " + Charles.isAlive());
    }
}