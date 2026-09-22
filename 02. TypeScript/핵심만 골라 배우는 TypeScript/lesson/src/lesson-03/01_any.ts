// any - 기본 자료형 및 참조 자료형의 모든 타입을 허용
// any는 값에 대한 타입이 포괄적이고 불명확하므로 사용을 지양한다.

{
  // 기본 자료형
  let uname: any = "Alice";
  let age: any = 30;
  let isDone: any = true;

  // 배열
  let numbers: any[] = [1, 2, 3, 4, 5];
  let names: any[] = ["Alice", "Bob", "Charlie"];

  // 튜플
  let person: [any, any] = ["Alice", 30];

  // 객체
  let user1: {
    name: any;
    age: any;
    isAdmin: any;
  } = {
    name: "Alice",
    age: 30,
    isAdmin: false,
  };

  // 함수
  function greet(person: any): any {
    return `Hello, ${person}`;
  }
}
