{
  let user: { name: string; age: number; getName: () => string } = {
    name: "철수",
    age: 17,
    getName() {
      return this.name;
    },
  };
}
