{
  // readonly -  속성의 값을 변경하지 못하게 하고 싶을때 사용
  let user: { name: string; readonly age: number } = {
    name: "철수",
    age: 17,
  };

  user.name = "영희";
  //   user.age = 30;

  console.log(user);
}
