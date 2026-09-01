
using System;

class Program
{
    static void Main()
    {
        // 컬렉션 (Dictionary, List)
        // 배열은 크기가 정해져있지만, 컬렉션은 크기가 정해져있지 않다.

        // List
        List<string> list = new List<string>();

        list.Add("hello");
        list.Add("world");

        Console.WriteLine(list[0]);
        Console.WriteLine(list[1]);

        // 직접 위치를 지정하여 value 삽입
        list.Insert(0, "hi");

        // 위치 지정하여 삭제
        list.RemoveAt(1);

        // value로 삭제
        list.Remove("hi");

        // list.count 활용방법
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }

        Console.WriteLine(list.Contains("hello"));
        Console.WriteLine(list.IndexOf("hello"));

        // list를 비우는 명령어
        list.Clear();


        // Dictionary
        // key-value
        Dictionary<string, string> cities = new Dictionary<string, string>();
        cities.Add("Tokyo", "Japan");
        cities.Add("Seoul", "Korea");
        cities.Add("Beijing", "China");

        // key 값으로 value 를 조회
        Console.WriteLine(cities["Seoul"]);

        // value 변경
        cities["Seoul"] = "Busan";

        // boolean 값을 반환하는 명령어
        cities.ContainsKey("Tokyo");
        cities.ContainsValue("Japan");

        // 삭제는 기본적으로 key 값을 기준으로 한다. 
        cities.Remove("Tokyo");
        
        cities.Clear();
    }
}