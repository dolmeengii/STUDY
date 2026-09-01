using System.Diagnostics;

public class 제어문
{
    static void Main()
    {
        int age = 18;
        
        // if 조건문
        if(age < 20)
        {
            Debug.Log("미성년자입니다.");
        }
        else if(age < 30)
        {
            Debug.Log("청년입니다.");
        }
        else 
        {
            Debug.Log("성인입니다.");
        }


        // switch 조건문
        // C#만 switch 문에서 문자열을 사용할 수 있음
        string fruit = "사과";

        // case 사이의 break 는 필수!
        // break 가 없으면 다음 case 문으로 넘어가서 실행됨
        // default 는 case 에 해당하지 않는 경우 실행됨
        switch(fruit)
        {
            case "사과":
                Debug.Log("사과를 선택했습니다.");
                break;
            case "바나나":
                Debug.Log("바나나를 선택했습니다.");
                break;
            case "오렌지":
                Debug.Log("오렌지를 선택했습니다.");
                break;
            default:
                Debug.Log("선택한 과일이 없습니다.");
                break;
        }


        
    }
}
