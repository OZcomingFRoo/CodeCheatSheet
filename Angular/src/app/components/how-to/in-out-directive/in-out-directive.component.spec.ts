import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InOutDirectiveComponent } from './in-out-directive.component';

describe('InOutDirectiveComponent', () => {
  let component: InOutDirectiveComponent;
  let fixture: ComponentFixture<InOutDirectiveComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InOutDirectiveComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(InOutDirectiveComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
