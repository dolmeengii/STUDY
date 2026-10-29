{
  // 옵션 속성 또는 옵셔널 속성
  // 할당하려는 속성 데이터가 꼭 포함되지 않아도 될 때 사용
  // 기호 ?
  let user: { name: string; age: number; getName?: () => string } = {
    name: "철수",
    age: 17,
  };
}
{
  // 옵셔널 속성 사용 시 주의 점 !!
  // 남용하면 타입 안정성이 떨어지게 되므로 신중히 사용해야 함.
  // ㄴㅡㅡㅡ 타입 안정성: 타입의 일관성과 올바름을 유지하며 타입 관련 오류를 최소화하는 것

  // 예시
  function greet(user: {
    name: string;
    age?: number; // 옵셔널 속성
  }) {
    console.log(`Hello, ${user.name}`);
    console.log(`You are ${user.age} years old`);
  }

  greet({
    name: "철수",
  }); // ${user.age} 부분은 undefined 출력됨
}
