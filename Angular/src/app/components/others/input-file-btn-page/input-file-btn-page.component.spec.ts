import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InputFileBtnPageComponent } from './input-file-btn-page.component';

describe('InputFileBtnPageComponent', () => {
  let component: InputFileBtnPageComponent;
  let fixture: ComponentFixture<InputFileBtnPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InputFileBtnPageComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(InputFileBtnPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
