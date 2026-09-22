// 타입추론 - 타입이 지정되지 않은 값의 타입을 자동으로 추측하여 적용해주는 기능
// type annotation

{
  // 기본 자료형
  let num: number = 10;
  let str: string = "A";
  let bol = true;
  let und = undefined;
  let nul = null;
  let sym = Symbol();

  // 참조 자료형
  let arr = [10, 20];
  let obj = { name: "Kim" };
  let fun = function () {};
}

{
  // 선언을 먼저 하고 값을 나중에 할당하게 된다면 any 타입으로 타입추론이 된다.
  let a;
  a = 10;
}
