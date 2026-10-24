{
  // 01
  // data가 string 타입이고 반환값이 존재하지 않는 함수가 사용된다는 의미.
  function fetchData(callback: (data: string) => void) {
    callback("some data");
  }

  fetchData((data: string): void => {
    console.log(data);
  });

  // 02
  // 매개변수 두개 전달 받을 때
  function processData(data: string, callback: (result: string) => void) {
    const result = data.toUpperCase();
    callback(result);
  }

  processData("hello", (result: string): void => {
    console.log(result); // "HELLO"
  });

  // 03
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
  fetchsData((error: Error | null, data: string | null): void => {
    if (error) {
      console.error(error);
    } else {
      console.log(data);
    }
  });
}
