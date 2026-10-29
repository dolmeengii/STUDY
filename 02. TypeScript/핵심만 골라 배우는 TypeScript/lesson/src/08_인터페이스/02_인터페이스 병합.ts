{
  // 인터페이스 병합
  // 인터페이스 선언 위치와 상관 없이 같은 이름의 인터페이스는 자동으로 합쳐지게 된다.

  interface User {
    name: string;
  }
  interface User {
    age: number;
  }

  let user: User = {
    name: "철수",
    age: 20,
  }; // 두 속성 중 하나의 속성만 정의하면 type error 발생
}
