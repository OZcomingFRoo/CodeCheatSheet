// - Each Spec file will have one decsribe function
// - Consider this as the container that contains all the tests for a tool (e.g. class like a component)
// Complete later with this: https://stackoverflow.com/questions/22413009/jasmine-javascript-testing-tobe-vs-toequal
describe('toBe VS toEqual', () => {
  it('Should be used like "==" ', () => {
    let obj = {
      p1: 1,
      p2: "1",
    };
    let oneN: any = obj.p1;
    let oneS: any = obj.p2;
    expect(oneN).toEqual(oneS);
  });

});

