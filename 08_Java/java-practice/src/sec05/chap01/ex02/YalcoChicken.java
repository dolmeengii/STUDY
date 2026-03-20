package sec05.chap01.ex02;

public class YalcoChicken {
    // 필드
    int no;
    String name;

    // 메서드
    String intro () {
        return "안녕하세요, %d호 %s점입니다.".formatted(no, name);
    }
}
