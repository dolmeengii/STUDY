// 리터럴 타입 (Literal Type) - 특정 값 자체를 타입으로 사용
// Symbol() 을 제외한 모든 타입은 리터럴 타입으로 지정 가능하다.

{
  let gender = "male";
  gender = "A";

  // male or female 만 할당하려고 한다면,
  let gender2: "male" | "female" = "male";
  // gender2 = "A"; 에러 발생
  gender2 = "female";

  let user: { name: "철수" };
  user = {
    // name: "영희", 에러 발생
    name: "철수",
  };

  // const 를 사용하면 값을 변경할 수 없으므로, 타입을 지정하지 않고 값을 할당하게 되면 리터럴 타입으로 추론된다.
  let num = 10;
  const num2 = 10;

  // 다만, 참조 자료형은 const 로 선언하더라도 리터럴 타입이 아닌 타입으로 타입추론이 이루어진다.
  const nums = [10, 20];
  const user2 = {
    name: "철수",
  };
}
