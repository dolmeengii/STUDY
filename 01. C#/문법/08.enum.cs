
using System.Diagnostics;

class Program
{
    // enum: 내부적으로는 정수형과 같다. 
    // 내부적으로는 숫자로 저장하되, 사용할 때에는 value 를 설정하여 사용한다.
    enum ProjectileKind
    {
        Arrow, Bullet, Missile
    }

    enum ProjectileKindTest
    {
        Arrow = 1, Bullet, Missile
    } // 해당 경우에는 Bullet = 2, Missile = 3 으로 할당됨. 


    static void Main()
    {
        ProjectileKind kind;

        kind = ProjectileKind.Arrow;

        switch (kind)
        {
            case ProjectileKind.Arrow:
                Console.WriteLine("화살입니다.");
                break;
            case ProjectileKind.Bullet:
                Console.WriteLine("총알입니다.");
                break;
            case ProjectileKind.Missile:
                Console.WriteLine("미사일입니다.");
                break;
        }

        Console.WriteLine(kind); // Arrow 로 출력됨.
        Console.WriteLine((int)kind); // 0으로 출력됨.

        // 만약, 
        kind = (ProjectileKind)1;
        // 를 할당한다면, ProjectileKind.Bullet 이 저장된다. 
    }
}