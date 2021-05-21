import { formatDate } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, ValidatorFn, Validators, AbstractControl, ValidationErrors } from '@angular/forms';

@Component({
  selector: 'app-form-model-driven',
  templateUrl: './form-model-driven.component.html',
  styleUrls: ['./form-model-driven.component.css']
})
export class FormModelDrivenComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
    this.firstName.valueChanges.subscribe(this.printValueInConsole,); // Getting value via Observable
    this.lastName.valueChanges.subscribe(this.printValueInConsole); // Getting value via Observable

    // Add control to FormGroup
    let carDate = new Date(2016, 1, 5);
    // Adding values 
    this.myFormGroup.addControl("manufactureDate", new FormControl(formatDate(carDate, 'yyyy-MM-dd', 'en')));
    this.myFormGroup.addControl("is2ndHanded", new FormControl(false));
  }

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
  private printValueInConsole = (val: any) => {
    console.log("Getting value from Observable method..");
    console.log("Value changed to ==> ", val);
  }
  /** An Example for a custom Validator */
  private NoBobValidator(): ValidatorFn {
    return (control: AbstractControl): ValidationErrors | null => {
      let valString: string = control.value;
      if (!valString) return null;
      return valString.trim().toLowerCase() === 'bob' ? { NoBob: { value: control.value } } : null;
    }
  };

  public myFormGroup: FormGroup = new FormGroup({
    // Adding formControls directly
    carName: new FormControl("Subaru", Validators.required),
    color: new FormControl(3)
  });
  public submitGroup(): void {
    console.info("Looks like you submitted the groups form");
    console.info("Is it valid ? ", this.myFormGroup.valid);
    console.info("Value ", this.myFormGroup.value);
  }
}
