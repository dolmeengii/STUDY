// unknown 타입 - JS 로 다룰 수 있는 모든 타입을 허용
// unknown 타입으로 지정된 변수를 사용하려면 타입을 좁혀서 사용해야함.

{
  let str: unknown = "Hello";
  let num: unknown = 10;
  let bool: unknown = true;
  let und: unknown = undefined;
  let nul: unknown = null;
  let sym: unknown = Symbol();
  let arr: unknown = [1, 3, 4];
  let obj: unknown = { name: "John", age: 30 };
  let fucn: unknown = () => console.log("Hello, world!");

  // unknown 타입 예시
  let a: unknown = "Hello, ";
  let b: unknown = "World!";

  // let c = a + b; -> 에러 발생
  let c =
    typeof a === "string" && typeof b === "string" ? a + b : "문자열이 아니다.";
  console.log(c);
}
