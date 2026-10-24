{
  // 함수의 매개변수에 타입을 지정해놓으면, 함수를 호출하는 쪽에 있는 함수는 자동적으로 타입추론을 한다.

  // 01
  function fetchData(callback: (data: string) => void) {
    callback("some data");
  }

  fetchData((data) => {
    console.log(data);
  });

  // 02
  function processData(data: string, callback: (result: string) => void) {
    const result = data.toUpperCase();
    callback(result);
  }

  processData("hello", (result) => {
    console.log(result); // "HELLO"
  });

  // 03
  // 외부에 작성된 함수를 참조값으로 넘길 때에는 함수 시그니처 작성 필수
  function doubleNum(item: number): void {
    console.log(item * 2);
  }

  function powNum(item: number): void {
    console.log(item * item);
  }

  function processItems(items: number[], callback: (item: number) => void) {
    items.forEach((item) => {
      callback(item);
    });
  }

  // 콜백 함수 정의 및 호출
  processItems([1, 2, 3], doubleNum);
  processItems([1, 2, 3], powNum);

  // 04
  function fetchsData(
    callback: (error: Error | null, data: string | null) => void,
  ) {
    setTimeout(() => {
      // 에러가 없는 경우
      // callback(null, "Data fetched successfully");

      // 에러가 있는 경우
      callback(new Error("Data Fetched Failed"), null);
    }, 1000);
  }

  // 콜백 함수 정의 및 호출
  fetchsData((error, data) => {
    if (error) {
      console.error(error);
    } else {
      console.log(data);
    }
  });
}
