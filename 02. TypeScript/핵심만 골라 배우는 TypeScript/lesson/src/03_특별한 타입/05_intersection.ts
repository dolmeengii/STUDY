// intersection type - 앰퍼센드 기호(&) 사용하며, 정의한 모든 타입을 만족해야함.

{
  let a: { name: string };
  //   a = {
  //     name: 10,
  //   }; - 에러

  // 만약 둘 중 하나만 만족하면 에러 발생
  let b: { name: string } & { age: number };
  b = {
    name: "B",
    age: 10,
  };
}
