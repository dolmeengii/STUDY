class Program
{
    // struct 는 다른 자료형을 모아놓은 것.
    struct HumanData
    {
        public string name;
        public float weight;
        public float height;
        public float feetSize;
    }

    static void Main()
    {
        HumanData Charles = new HumanData();
        Charles.name = "철수";
        Charles.weight = 70;
        Charles.height = 172;
        Charles.feetSize = 260;

        Console.WriteLine(Charles); // 데이터 타입이 출력된다. 


        HumanData[] players = new HumanData[5];
        players[0] = new HumanData();

    }
}