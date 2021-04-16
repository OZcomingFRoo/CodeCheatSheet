// - Each Spec file will have one decsribe function
// - Consider this as the container that contains all the tests for a tool (e.g. class like a component)
describe('Shallow Testing', () => {
  // - The "it" Sections Can be created multiple time inside a "describe" fucntion
  // - Cosider this as the a unit test to test one "test case"
  it("Should successed because it's not a real testing case", () => {
    // - The expect it the main assertion function
    // - The "expect" can be used multiple times inside the "it"
    expect(true).toBeTruthy();
  });

  it('Should Expect multiple "expect" functions', () => {
    let num = 1337;
    let title = "Kantan Desu ne";
    let bool = false;
    expect(num).toEqual(1337);
    expect(title).not.toBeNull(); // The "not" inverts the matcher statement
    expect(bool).toBeDefined();
  });

  it("Should contain Falsy values", () => {
    let notSetVar;
    expect(undefined).toBeFalsy();
    expect(null).toBeFalsy();
    expect(0).toBeFalsy();
    expect('').toBeFalsy();
    expect("").toBeFalsy();
    expect(notSetVar).toBeFalsy();
    expect(false).toBeFalsy();
    notSetVar = "";
    expect(notSetVar).toBeFalsy();

    notSetVar += "Now I'm set";
    expect(-1).not.toBeFalsy();
    expect(notSetVar).not.toBeFalsy();
  });

  it("Should contain Truthy values", () => {
    let func = (asd: number, qwe: number, zxc: number) => { return asd + qwe + zxc; };
    let action = () => { };
    expect(1).toBeTruthy();
    expect(" ").toBeTruthy();
    expect(true).toBeTruthy();
    expect(action).toBeTruthy();
    expect(func).toBeTruthy();
    expect(func(1, -100, 21)).toBeTruthy();

    expect(action()).not.toBeTruthy();
    expect(func(NaN, NaN, NaN)).not.toBeTruthy();
  });
});

