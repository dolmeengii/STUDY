class Program
{
    static void Main()
    {
        // [몬스터 이름: 경험치 숫자]로 이루어진 dictionary 를 만들어 원하는 수의 데이터를 넣는다. 
        // 모든 몬스터들의 경험치의 평균을 출력한다. 

        Dictionary<string, int> monsters = new Dictionary<string, int>();

        monsters.Add("Slime", 4);
        monsters.Add("Zombie", 7);
        monsters.Add("Bat", 5);
        monsters.Add("Skeleton", 11);
        monsters.Add("Ghost", 15);

        int sum = 0;

        foreach (string monster in monsters.Keys)
        {
            sum += monsters[monster];
        }

        double average = (double)sum / monsters.Count;

        Console.WriteLine(average);
    }
}