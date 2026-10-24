{
  // 타입가드란?
  // 타입스크립트는 같은 자료형의 덧셈만 허용하기 때문에 유니온 타입으로 매개변수 타입의 경우의 수를 늘리면 에러가 발생한다.
  // 이런 경우에 조건문을 타입가드로 사용하여 해결할 수 있다.
  function sum(a: number | string, b: number | string): number | string {
    if (typeof a === "number" && typeof b === "number") return a + b;
    else if (typeof a === "string" && typeof b === "string") return `${a}${b}`;
    return String(a) + String(b);
  }

  console.log(sum(10, 20));
  console.log(sum("A", "B"));
}
{
  // 타입가드 주의할 점
  //   function sum(a: number | string, b: number | string): number | string {
  //     if (typeof a === "number" && typeof b === "number") return a + b;
  //     if (typeof a === "string" && typeof b === "string") return `${a}${b}`;
  //     if (typeof a === "number" && typeof b === "string") return String(a) + b;
  //     if (typeof a === "string" && typeof b === "number") return a + String(b);
  //   }
  // 반환값에 타입이 지정되어 있을 경우, 매개변수의 타입에 상관없이 코드 우선 판단을 하게된다.
  // 따라서 위 4가지 경우에 해당하지 않는 경우(예외상황)에 대한 처리를 해주어야 한다.

  // 첫번째 해결 방법_undefined 반환값 지정
  function sum1(
    a: number | string,
    b: number | string,
  ): number | string | undefined {
    if (typeof a === "number" && typeof b === "number") return a + b;
    if (typeof a === "string" && typeof b === "string") return `${a}${b}`;
    if (typeof a === "number" && typeof b === "string") return String(a) + b;
    if (typeof a === "string" && typeof b === "number") return a + String(b);
  }

  // 두번째 해결 방법_반환타입 미지정
  function sum2(a: number | string, b: number | string) {
    if (typeof a === "number" && typeof b === "number") return a + b;
    if (typeof a === "string" && typeof b === "string") return `${a}${b}`;
    if (typeof a === "number" && typeof b === "string") return String(a) + b;
    if (typeof a === "string" && typeof b === "number") return a + String(b);
  }

  // 세번째 해결 방법_코드 내에서 예외처리(반환값 지정)
  function sum3(a: number | string, b: number | string): number | string {
    if (typeof a === "number" && typeof b === "number") return a + b;
    if (typeof a === "string" && typeof b === "string") return `${a}${b}`;
    if (typeof a === "number" && typeof b === "string") return String(a) + b;
    if (typeof a === "string" && typeof b === "number") return a + String(b);
    return String(a) + String(b);
  }

  // 네번째 해결 방법_코드 내에서 예외처리(에러처리)
  function sum4(a: number | string, b: number | string): number | string {
    if (typeof a === "number" && typeof b === "number") return a + b;
    if (typeof a === "string" && typeof b === "string") return `${a}${b}`;
    if (typeof a === "number" && typeof b === "string") return String(a) + b;
    if (typeof a === "string" && typeof b === "number") return a + String(b);
    throw new Error("Invalid Parameter Type");
  }

  console.log(sum1(10, 20));
  console.log(sum1("A", "B"));
}
{
  // 타입가드 확장

  // 01. null 타입 불확실성 해결
  //   function example(a: string | null) {
  //     return a.toUpperCase();
  //   }

  function example_1(a: string | null) {
    if (typeof a === "string") return a.toUpperCase();
  }

  function exampl_2(a: string | null) {
    if (a) return a.toUpperCase();
  }

  function exampl_3(a: string | null) {
    if (a !== null) return a.toUpperCase();
  }

  function exampl_4(a: string | null) {
    return a?.toUpperCase();
  }

  // 02. 객체의 불확실성 해결
  //   function returnName(obj: {}) {
  //     return obj.name;
  //   }

  function returnName1(obj: {}) {
    if ("name" in obj) return obj.name;
  }
}
