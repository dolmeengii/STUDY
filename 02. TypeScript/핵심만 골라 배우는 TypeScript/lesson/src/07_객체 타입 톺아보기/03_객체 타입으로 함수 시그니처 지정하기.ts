{
  // 예제 1
  const add: { (n1: number, n2: number): number } = function add(n1, n2) {
    return n1 + n2;
  };

  console.log(add(10, 20));
}
{
  // 예제 2
  const greet: { (name: string): string } = (name) => `Hello, ${name}`;
  console.log(greet("철수"));
}
