{
  // *함수 시그니처란 함수의 매개변수와 반환값에 타입을 지정하는 것이다.

  // 1. 함수 선언문에서의 함수 시그니처
  // function func(params: paramsType): returnType {
  // .. code...
  // }

  // 첫번째 예제
  function printHello(): void {
    console.log("Hello");
  }

  // 두번째 예제
  function add(n1: number, n2: number): number {
    return n1 + n2;
  }

  // 세번째 예제
  function greet(name: string): string {
    return `Hello, ${name}`;
  }

  // 네번째 예제
  function findLongestString(strings: string[]): string {
    if (strings.length === 0) return ""; // 빈 배열이면 빈 문자열 반환

    return strings.reduce((longest, current) => {
      return current.length > longest.length ? current : longest;
    }, strings[0]); // 배열의 첫 번쨰 항목을 초기값으로 설정
  }

  const words = ["apple", "banana", "cherry", "watermelon"];
  const longestWord = findLongestString(words);
  console.log(longestWord); // "watermelon"
}
