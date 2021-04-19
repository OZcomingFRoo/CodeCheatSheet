import { TestBed } from '@angular/core/testing';

import { QueryAuthEqualTrueExampleGuard } from './query-auth-equal-true-example.guard';

describe('QueryAuthEqualTrueExampleGuard', () => {
  let guard: QueryAuthEqualTrueExampleGuard;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    guard = TestBed.inject(QueryAuthEqualTrueExampleGuard);
  });

  it('should be created', () => {
    expect(guard).toBeTruthy();
  });
});
