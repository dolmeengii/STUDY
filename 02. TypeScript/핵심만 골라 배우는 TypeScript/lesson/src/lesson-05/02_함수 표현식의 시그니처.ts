{
  // 첫번째 예제 (두가지 방식)
  const printHello = function printHello(): void {
    console.log("Hello");
  };

  const printHi: () => void = function printHi() {
    console.log("Hi");
  };

  // 두번째 예제
  const add = function add(n1: number, n2: number): number {
    return n1 + n2;
  };

  const addCopy: (n1: number, n2: number) => number = function addCopy(n1, n2) {
    return n1 + n2;
  };

  // 세번째 예제
  const greet = (name: string): string => `Hello, ${name}`;

  const greetCopy: (name: string) => string = (name) => `Hello, ${name}`;

  // 네번째 예제
  const findLongestString = (strings: string[]): string => {
    if (strings.length === 0) return ""; // 빈 배열이면 빈 문자열 반환

    return strings.reduce((longest, current) => {
      return current.length > longest.length ? current : longest;
    }, strings[0]); // 배열의 첫 번쨰 항목을 초기값으로 설정
  };

  //    const findLongestString : (strings: string[]) => string = (strings) => {
  //     if (strings.length === 0) return ""; // 빈 배열이면 빈 문자열 반환

  //     return strings.reduce((longest, current) => {
  //       return current.length > longest.length ? current : longest;
  //     }, strings[0]); // 배열의 첫 번쨰 항목을 초기값으로 설정
  //   };

  const words = ["apple", "banana", "cherry", "watermelon"];
  const longestWord = findLongestString(words);
  console.log(longestWord); // "watermelon"
}
