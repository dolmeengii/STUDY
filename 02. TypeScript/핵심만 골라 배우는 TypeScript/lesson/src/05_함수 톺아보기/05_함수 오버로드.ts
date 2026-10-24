{
  // 함수 오버로드의 개념
  function greet(name: string): string; // 오버로드 시그니처
  function greet(name: string, age: number): string;

  function greet(name: string, age?: number): string {
    if (age !== undefined) {
      return `Hello, ${name}. You are ${age} years old.`;
    } else {
      return `Hello, ${name}.`;
    }
  }

  console.log(greet("Alice"));
  console.log(greet("Bob", 30));
}

{
  // 함수 오버로드 예제 01
  function add(n1: string, n2: string): string;
  function add(n1: number, n2: number): number;

  function add(n1: number | string, n2: number | string): number | string {
    if (typeof n1 === "number" && typeof n2 === "number") return n1 + n2;
    else if (typeof n1 === "string" && typeof n2 === "string") return n1 + n2;
    throw new Error("Invalid arguments");
  }

  const res1 = add("A", "B"); // 문자열 연결 연산
  const res2 = add(10, 20); // 덧셈 연산

  console.log(res1);
  console.log(res2);
}

{
  // 함수 오버로드 예제 02
  function formatValue(value: string): string;
  function formatValue(value: number): number;

  function formatValue(value: string | number): string | number {
    if (typeof value === "string") {
      return value.trim().toUpperCase();
    } else {
      return value;
    }
  }
  const result1 = formatValue("hello");
  const result2 = formatValue(10);

  console.log(result1);
  console.log(result2);
}

{
  // 함수 오버로드 예제 03
  function processData(value: string): string;
  function processData(value: number): number;
  function processData(value: boolean): string;

  function processData(value: string | number | boolean): string | number {
    if (typeof value === "string") {
      return `String ${value}`;
    } else if (typeof value === "number") {
      return value * 2;
    } else {
      return value ? "True" : "False";
    }
  }

  const r1 = processData("A");
  const r2 = processData(10);
  const r3 = processData(true);

  console.log(r1);
  console.log(r2);
  console.log(r3);
}
