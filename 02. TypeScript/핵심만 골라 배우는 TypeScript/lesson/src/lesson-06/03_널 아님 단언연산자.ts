{
  function numberFixed(num: number | null) {
    // Truthy
    if (num) {
      console.log(num.toFixed(1));
    }
    // 불일치
    if (num !== null) {
      console.log(num.toFixed(1));
    }

    // 옵셔널 체이닝
    console.log(num?.toFixed(1));

    // 널 아님 단언 연산자(Non-null asserstion operator) !
    // 해당 연산자 또한 단언이기 때문에 타입스크립트가 코드를 믿게 된다. (주의)
    console.log(num!.toFixed(1));
  }

  numberFixed(10.12);
}
