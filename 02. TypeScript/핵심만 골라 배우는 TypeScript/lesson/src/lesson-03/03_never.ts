// never - 절대로 발생하지 않는 값, 불가능한 값

{
  let a: never;

  // 에러 발생
  // a = 10;
  // a = 'A';
  // a = true;
  // a = [];
  // a = {};

  let nv: never;
  let an: any = 10;
  let un: unknown = 20;

  //   an = nv; - 에러
  //   un = nv; - 에러

  // Never 타입의 사용처
  // 예외처리, 무한루프
  function throwError(err: string): never {
    throw new Error(err);
  }

  function infiniteLoop(): never {
    while (true) {}
  }
}
