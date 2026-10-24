// union type - 하나의 변수가 여러 개의 타입을 가질 수 있음 (파이프 기호 | 사용)

{
  let a: number = 10;
  //   a = "A";  에러

  // 유니온 타입 설정
  let b: number | string = 10;
  b = "B";
}
