
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // 서로 다른 뜻을 가진 [한국어 단어: 영단어]의 dictionary 를 만들어 5개의 데이터를 넣는다.
        // 그 dictionary를 [영단어: 한국어단어]의 dictionary 로 바꾼다.

        Dictionary<string, string> words = new Dictionary<string, string>();

        words.Add("사과", "pear");
        words.Add("배", "apple");
        words.Add("감", "orange");
        words.Add("딸기", "watermelon");
        words.Add("수박", "strawberry");

        int length = words.Count;

        for (int i = 0; i < length; i++)
        {
            string key = words.Keys.ElementAt(i);
            string value = words[key];

            words.Remove(key);
            words.Add(value, key);
        }

        foreach (KeyValuePair<string, string> pair in words)
        {
            Console.WriteLine(pair);
        }
    }
}