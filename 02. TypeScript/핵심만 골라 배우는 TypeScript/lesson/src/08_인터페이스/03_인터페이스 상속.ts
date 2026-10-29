{
  /*
  interface Person {
    name: string;
    age: number;
  }

  interface Developer {
    name: string;
    age: number;
    skill: string;
  }
*/

  interface Person {
    name: string;
    age: number;
  }

  interface Developer extends Person {
    // 상속(Extends)_ Person 이 부모, Developer 가 자식 인터페이스 관계
    // 부모의 속성이 변경되면 자식의 속성도 변경됨.
    skill: string;
  }

  const person: Person = {
    name: "John",
    age: 20,
  };

  const developer: Developer = {
    name: "dolmeengii",
    age: 28,
    skill: "Front Developer",
  };
}
{
  interface Car {
    name: string;
    color: string;
  }

  interface Bmw extends Car {
    speed: number;
  }

  const car: Car = {
    name: "car",
    color: "red",
  };

  const bmw: Bmw = {
    name: "bmw",
    color: "blue",
    speed: 100,
  };
}
{
  // 다음의 두 인터페이스는 공통 속성이 있지만, 연관관계가 명확하지 않기 때문에 상속하지 않는 것이 좋다.
  interface Phone {
    name: string;
    color: string;
  }

  interface Tv {
    name: string;
    color: string;
    channel: string;
  }

  const galaxy: Phone = {
    name: "galaxy ultra 24",
    color: "white",
  };

  const lg: Tv = {
    name: "LG OLED TV",
    color: "black",
    channel: "24 channel",
  };
}
