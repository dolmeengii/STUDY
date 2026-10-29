{
  // 구조적 타이핑(Structural Typing)
  // 객체의 형태에 기반하여 타입을 검사하는 시스템
  // readonly 를 사용하더라도 구조적 타이핑 허용 가능

  interface User {
    name: string;
    age: number;
  }

  interface Person {
    name: string;
    age: number;
  }

  let user: User = {
    name: "철수",
    age: 20,
  };

  let person: Person = {
    name: "영희",
    age: 25,
  };

  user = person;
  person = user;

  //   let num: number = 10;
  //   let str: string = "A";
  //   num = str; // 타입 불일치, 에러
  //   str = num; // 타입 불일치, 에러
}
{
  // 구조적 타이핑 추가 예시

  interface User {
    name: string;
    age: number;
  }

  function greet(person: User) {
    console.log(`Hello, ${person.name}`);
  }

  const user1 = { name: "Alice", age: 25 };
  greet(user1);
}
