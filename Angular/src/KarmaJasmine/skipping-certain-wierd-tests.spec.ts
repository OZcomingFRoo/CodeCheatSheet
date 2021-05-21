describe('Skipping certain test cases', () => {

  xit("Should obviously return true!! XD", () => {
    let a: any;
    a = "asd";
    a += "qwe";
    a = 12;
    a += -999999;
    a -= 100000000;
    a = false;
    // This test case seems... "complex", right?
    // Sadly, for the time being it's not passing and the OG-coder behind cannot explain why he created such test-case
    // However, you must deliver you work in the next hour or ELSE!!
    // What do you do? Consult you superior and most likely he'll say:
    // "just skip it for the time being and try to understand it later, kay ?"
    expect(a).toBeTrue();
  });

  it('Should Return a simple number greater than 0', () => {
    let num = 1337;
    expect(num).toBeGreaterThan(0);
  });

});

