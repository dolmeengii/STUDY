{
  // 두가지 타입은 any 타입으로 타입추론이 됨.
  // undefined, null 은 명시적으로 타입을 지정해주기.(유니온 타입 활용)
  let und = undefined;
  let nul = null;

  und = 10;
  nul = "A";

  let und2: undefined = undefined;
  let nul2: null = null;

  //  und2 = 10; 에러
  // nul2 = "A";
}
