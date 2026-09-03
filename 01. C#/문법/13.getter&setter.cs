public class Character
{
    string name;
    int hp;

    public void SetHP(int hp)
    {
        this.hp = hp;
    }

    public int GetHP()
    {
        return hp;
    }

    /* 아래와 같은 방식으로 선언할 수도 있다. 
    // 방법 1 
    public int hp
    {
        get; set;
    }

    // 방법 2
    public int hp
    {
        get{
            return hp;
        } 
        
        // setter 에서 값을 받았을 때 value로 지정된다. 
        set{
            hp = value;
        }
    }

    // 방법 3
    // 외부에서는 HP로만 접근 가능함. 
    private int hp;

    public int HP
    {
         get{
            return hp;
        } 
        
        set{
            hp = value;
        }
    }
    */

    public Character(string characterName, int initialHP)
    {
        name = characterName;
        hp = initialHP;
    }
}

public class Program
{
    static void Main()
    {

        Character Charles = new Character();

        Charles.SetHP(10);
        // Charles.hp;
    }
}