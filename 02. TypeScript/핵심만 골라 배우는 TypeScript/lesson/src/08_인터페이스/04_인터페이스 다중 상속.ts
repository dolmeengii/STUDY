{
  // 인터페이스 다중 상속이란?
  // 인터페이스를 조합해 새로운 인터페이스를 정의할 때 사용
  // interface Indetifier extends Other1, Other2, ... OtherN{}

  interface User {
    name: string;
    age: number;
  }

  interface Log {
    log(message: string): void;
  }

  // 부모의 속성 모두 사용해야 하고, 단순 조합용이면 {} 안을 비워둬도 괜찮음.
  interface UserWithLogging extends User, Log {}
  const user: UserWithLogging = {
    name: "alex",
    age: 10,
    log(message) {
      console.log(message);
    },
  };
}
