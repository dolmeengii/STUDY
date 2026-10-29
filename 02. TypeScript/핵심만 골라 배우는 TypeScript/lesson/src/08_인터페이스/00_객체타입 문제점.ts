{
  // 공통된 타입이 계속 정의될 때 가독성 및 유지보수성 저하되는 문제 발생 .
  const user1: { name: string; age: number; gender: "male" | "female" } = {
    name: "철수",
    age: 20,
    gender: "male",
  };

  const user2: { name: string; age: number; gender: "male" | "female" } = {
    name: "영희",
    age: 30,
    gender: "female",
  };

  const user3: { name: string; age: number; gender: "male" | "female" } = {
    name: "가희",
    age: 25,
    gender: "female",
  };
}
