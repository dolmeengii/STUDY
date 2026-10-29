{
  // 인터페이스의 선택적 상속은 옵셔널 속성으로 구현할 수 있다.

  interface Vehicle {
    brand: string;
    year?: number;
  }

  interface Car extends Vehicle {
    wheels: number;
  }

  const car: Car = {
    brand: "kia",
    wheels: 4,
  };
}
