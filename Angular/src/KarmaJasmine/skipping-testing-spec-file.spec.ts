xdescribe('Skipping a whole spec file (test case collection container)', () => {

  it("This is some obscure test case 1", () => {
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

  it('This is some obscure test case 2', () => {
    let num = 1337;
    do {
      num--;
    } while (num >= 0);
    expect(num).toBeGreaterThan(0);
  });

});

