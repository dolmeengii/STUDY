{
  // 2-3. 배열타입

  // 빈 배열
  let list1: [] = [];

  // 숫자형 배열
  let list2: number[] = [1, 2, 3];
  let list3: Array<number> = [1, 2, 3];

  // 문자열 배열
  let list4: string[] = ["a", "b", "c"];
  let list5: Array<string> = ["a", "b", "c"];

  // 논리형 배열
  let list6: boolean[] = [true, false, false];
  let list7: Array<boolean> = [true, false, true];

  // Null 배열
  let list8: null[] = [null, null];
  let list9: Array<null> = [null, null];

  // 객체 배열
  let list10: { name: string }[] = [{ name: "Jack" }, { name: "Jane" }];
  let list11: Array<{ name: string }> = [{ name: "Jack" }, { name: "Jane" }];

  // 함수 배열
  let list12: (() => void)[] = [function () {}, function () {}];
  let list13: Array<() => void> = [function () {}, function () {}];

  // 다르게 타입이 섞인 배열 (튜플) - 제네릭 방식으로 선언 불가능
  let list14: [number, string, boolean] = [1, "a", true];
}
