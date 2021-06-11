import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InputFileButtonComponent } from './input-file-button.component';

describe('InputFileButtonComponent', () => {
  let component: InputFileButtonComponent;
  let fixture: ComponentFixture<InputFileButtonComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InputFileButtonComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(InputFileButtonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
