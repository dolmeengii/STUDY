/* 함수에서의 타입추론
1. 함수의 매개변수의 타입을 명시적으로 지정하지 않았을 경우 any 타입으로 타입추론 됨.
    - 함수의 매개변수로 전달될 수 있는 굉장히 다양하기 때문

2. 함수의 반환값은 상황에 따라 타입추론이 될 수도 있고, 안 될 수도 있음. 
    - 반환되는 값이 특정 자료형을 명확하게 반환한다면 타입 추론이 가능
    - api 응답을 반환하는 경우에는 타입추론을 정확히 할 수 없어 any 타입으로 추론a
*/

{
  //   function add(n1, n2) {
  //     return n1 + n2;
  //   }

  function add2(n1: number, n2: number) {
    return n1 + n2;
  }

  function add3(n1: number, n2: number) {
    return "A";
  }
}
