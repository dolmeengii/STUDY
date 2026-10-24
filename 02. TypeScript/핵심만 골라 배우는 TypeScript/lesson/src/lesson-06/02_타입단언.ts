{
  // 타입단언이란?
  // 특정 데이터가 어떠한 타입을 가진다고 확신할 때 사용하는 개념

  //   const num: unknown = 10.12;
  //   const fixedNum = num.toFixed(1);

  const num: unknown = 10.12;
  const fixedNum1 = typeof num === "number" && num.toFixed(1);
  const fixedNum2 = (<number>num).toFixed(1);
  const fixedNum3 = (num as number).toFixed(1);
}

{
  // 타입단언 주의할 점
  // 변수의 타입이 선언한 것과 일치하지 않아도 타입스크립트에서는 as 로 단언한 타입을 믿게된다.
  // 이 때에 코드 상에서 에러가 발생하지는 않지만 런타임 시 오류가 발생할 수 있다.

  const num: unknown = "10.12";
  const fixedNum = (num as number).toFixed(1);
  console.log(fixedNum);
}
