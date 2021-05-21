import { Component, OnInit } from '@angular/core';
import { FormControl, ValidatorFn, Validators, AbstractControl, ValidationErrors } from '@angular/forms';

@Component({
  selector: 'app-form-model-driven',
  templateUrl: './form-model-driven.component.html',
  styleUrls: ['./form-model-driven.component.css']
})
export class FormModelDrivenComponent implements OnInit {

  constructor() { }

  public firstName: FormControl = new FormControl('Inochi',
    [
      // Built In Validators
      Validators.required,
      Validators.minLength(2),
      // Custom Validator (See how it is set as a function/method)
      this.NoBobValidator()
    ]);
  public lastName: FormControl = new FormControl('Ookami',
    [
      // Built In Validators
      Validators.required,
      Validators.minLength(2),
      // Inline Custom Validator
      (control: AbstractControl): ValidationErrors | null => control.value && control.value.trim().toLowerCase() === 'bob' ? { NoBob: { value: control.value } } : null
    ]);

  public get FullName(): string {
    // Getting value via property value of FormControl object
    return this.firstName.value + ' ' + this.lastName.value;
  }

  ngOnInit(): void {
    this.firstName.valueChanges.subscribe(this.printValueInConsole,); // Getting value via Observable
    this.lastName.valueChanges.subscribe(this.printValueInConsole); // Getting value via Observable
  }

  private printValueInConsole = (val: any) => {
    console.log("Getting value from Observable method..");
    console.log("Value changed to ==> ", val);
  }

  // An Example for a custom Validator
  private NoBobValidator(): ValidatorFn {
    return (control: AbstractControl): ValidationErrors | null => {
      let valString: string = control.value;
      if (!valString) return null;
      return valString.trim().toLowerCase() === 'bob' ? { NoBob: { value: control.value } } : null;
    }
  };
}
