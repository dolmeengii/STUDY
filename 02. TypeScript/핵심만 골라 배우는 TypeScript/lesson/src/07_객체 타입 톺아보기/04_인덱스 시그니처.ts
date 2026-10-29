{
  // 인덱스 시그니처(Index singature)란?
  // 객체의 속성 타입을 동적으로 정할 때 사용
  // [key: keyType]: valueType 으로 선언

  let user: { [key: string]: string | number | (() => string) } = {
    name: "철수",
    gender: "male",
    address: "seoul",
    age: 20,
    printHello() {
      return "Hello";
    },
  };
}
{
  // 인덱스 시그니처 사용 시 주의점
  interface Person {
    name: string; // this. name 사용하는 부분은 해결되지만, 다른 속성 호출 시 error 발생함. 결국 모든 속성에 대해 정의해줘야 하는 문제 발생.
    [key: string]: string | (() => string);
  }

  const person: Person = {
    name: "John",
    printName() {
      return "John";
      //   return this.name; // type error 발생
    },
  };
}
