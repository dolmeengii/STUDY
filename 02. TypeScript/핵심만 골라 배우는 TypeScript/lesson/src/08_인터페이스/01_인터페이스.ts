{
  // 인터페이스(interface)란?
  // 객체의 타입을 정의할 떄 사용하는 문법

  /** 인터페이스 사용법
   * interface 식별자 {
   *  속성명 1: 타입 1,
   *  속성명 2: 타입 2,
   *  ...
   *  속성명 N: 타입 N
   * }
   */

  // 옵셔널 속성, Readonly 속성도 사용 가능

  interface User {
    name: string;
    age?: number;
    readonly gender: "male" | "female";
  }

  const user1: User = {
    name: "철수",
    age: 20,
    gender: "male",
  };

  const user2: User = {
    name: "영희",
    age: 30,
    gender: "female",
  };
}
{
  // 인터페이스와 함수 시그니처
  // 함수 표현식 형태에서만 인터페이스를 사용할 수 있다.

  interface Add {
    (n1: number, n2: number): number;
  }

  const add: Add = function add(n1, n2) {
    return n1 + n2;
  };

  interface Greet {
    (name: string): string;
  }

  const greet: Greet = (name) => `Hello, ${name}`;
}
{
  // 인터페이스와 인덱스 시그니처

  interface User {
    [key: string]: string;
  }

  const user1: User = {
    name: "철수",
    gender: "male",
    address: "seoul",
  };
}
