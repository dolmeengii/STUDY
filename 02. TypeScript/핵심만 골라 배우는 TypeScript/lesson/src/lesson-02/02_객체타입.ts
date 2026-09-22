{
  // 2. 참조 자료형
  // 2-1. 객체 타입
  // 2-1-1. 다양한 타입 할당
  let obj1: {} = {};

  let obj2: { name: string } = { name: "Jack" };

  let obj3: { name: string; age: number } = { name: "Jack", age: 32 };

  let obj4: { name: string; age: number; adult: boolean } = {
    name: "Jack",
    age: 32,
    adult: false,
  };

  let obj5: { name: string; age: number; adult: boolean; job: undefined } = {
    name: "Jack",
    age: 32,
    adult: false,
    job: undefined,
  };

  let obj6: { name: string; age: number; adult: boolean; job: null } = {
    name: "Jack",
    age: 32,
    adult: false,
    job: null,
  };

  let obj7: {
    name: string;
    age: number;
    adult: boolean;
    job: { title: string; view: number };
  } = {
    name: "Jack",
    age: 32,
    adult: false,
    job: { title: "programmer", view: 1000 },
  };

  let obj8: {
    name: string;
    age: number;
    adult: boolean;
    job: { title: string; view: number };
    today: Date;
  } = {
    name: "Jack",
    age: 32,
    adult: false,
    job: { title: "programmer", view: 1000 },
    today: new Date(),
  };

  // 2-1-2. 빈객체 할당
  /* 주의 
 타입 위치의 {}는 "프로퍼티가 없는 객체"가 아니라 "필수 프로퍼티 조건이 없는 타입"을 의미하며,
 null 과 undefined를 제외한 모든 타입을 허용한다는 의미이다.
 
 TS는 값이 필요한 프로퍼티를 갖추었는지로 호환성을 판단하는 구조적 타이핑을 사용한다.
 {}는 요구하는 프로퍼티가 없으므로 숫자, 문자열, 불리언 같은 원시값도 할당할 수 있다.
 
 JS에서 원시값도 "hello".length, (123).toString()처럼 프로퍼티/메서드에 접근할 수 있는데,
 이때에 원시값을 임시 래퍼 객체로 다루는 오토박싱을 수행하며 원시값 자체가 객체인 것은 아니다.
 null과 undefined는 이런 프로퍼티 접근이 불가능하며, strictNullChecks가 켜져 있으면 {}에도 할당할 수 없다.
 
 예시) 아래 모두 허용되지만, "빈 객체"를 의미하는 것은 아니다.
 obj1 = 123; 
 obj1 = "hello"; 
 obj1 = false; 
 obj1 = []; 
 obj1 = () => {}; 

 원시값을 제외하고 객체(배열, 함수 포함)만 허용하려면 {} 대신 object 타입을 사용한다. */

  //  let obj1: {} = {}; (x)

  // 실제로 빈 객체를 지정하고 싶다면 아래와 같이 지정할 수 있음.
  let obj9: Record<string, never> = {};

  // 2-1-3. 심화 - 함수타입과 배열타입을 매개변수로 가지는 객체타입 정의하기
  let obj10: {
    job: string;
    getJob: () => string;
  } = {
    job: "developer",
    getJob: function () {
      return this.job;
    },
  };

  let obj11: {
    skills: string[];
    job: string;
    getJob: () => string;
  } = {
    skills: ["javascript", "typescript"],
    job: "developer",
    getJob: function () {
      return this.job;
    },
  };

  // 2-1-4. 옵셔널 속성(기초)
  const printUserName = (lastName: string, firstName: string): string =>
    `${lastName}${firstName || ""}`;
  // const result = printUserName("Andrew"); 매개변수의 개수가 다르므로 에러 발생
  const result = printUserName("Andrew", "Smith");
  console.log(result);

  // 옵셔널 속성을 파라미터에 붙여 파라미터가 없는 상태를 충족시킨다.
  // 파라미터명? -> 파라미터가 있을 수도 있고 없을 수도 있다.
  const printUserNameOpt = (lastName: string, firstName?: string): string =>
    `${lastName}${firstName || ""}`;
  const resultOpt1 = printUserNameOpt("Andrew");
  console.log(result);

  // 동적으로 속성 추가하는 것은 불가능하기 때문에 명확하지 않은 속성에 옵셔널을 붙여 처리해둘 수 있다.
  const user: {
    name: string;
    age: number;
    gender?: string;
  } = {
    name: "John Doe",
    age: 30,
  };

  user.gender = "female";
}
