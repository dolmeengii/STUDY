{
  // 2-2. 함수 타입
  // 2-2-1. 함수 선언문
  // function 함수명(매개변수: 매개변수 타입): 반환타입 {}
  function add_fun(n1: number, n2: number): number {
    return n1 + n2;
  }

  add_fun(10, 20);

  // 2-2-2. 함수 표현식
  // const 함수명 = function (매개변수: 매개변수 타입): 반환타입 {}
  const add = function (n1: number, n2: number): void {
    console.log(n1 + n2);
  };

  // 함수 선언문은 변수에 타입을 지정할 수 없지만, 함수 표현식은 변수에도 타입을 지정할 수 있다.
  // 변수에 타입을 지정하면 실제 함수의 매개변수 부분의 타입 정의는 생략 가능하다.
  const add_arr: (n1: number, n2: number) => void = function (n1, n2): void {
    console.log(n1 + n2);
  };

  const printHello: () => void = () => {
    console.log("Hello");
  };
}
