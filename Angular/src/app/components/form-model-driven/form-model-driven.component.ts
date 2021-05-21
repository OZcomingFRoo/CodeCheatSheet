import { formatDate } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import {
  FormGroup, FormControl, ValidatorFn, Validators,
  AbstractControl, ValidationErrors, FormBuilder, FormArray
} from '@angular/forms';

@Component({
  selector: 'app-form-model-driven',
  templateUrl: './form-model-driven.component.html',
  styleUrls: ['./form-model-driven.component.css']
})
export class FormModelDrivenComponent implements OnInit {

  constructor(private _formBuilder: FormBuilder) { }

  ngOnInit(): void {

    this.firstName.valueChanges.subscribe(this.printValueInConsole,); // Getting value via Observable
    this.lastName.valueChanges.subscribe(this.printValueInConsole); // Getting value via Observable

    // Adding values to FormGroup in runtime
    let carDate = new Date(2016, 1, 5);
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


  // Comparison on how to init a FormGroup object:
  // https://angular.io/guide/reactive-forms#using-the-formbuilder-service-to-generate-controls
  // ======== Setting FormGroup via builder (Much short) ======== //
  myFormGroup: FormGroup = this._formBuilder.group({
    carName: ["Subaru", Validators.required],
    color: [3]
  });
  // ======== Setting FormGroup via Setting FormGroup via C-TOR ======== //
  // myFormGroup = new FormGroup({
  //  carName: new FormControl("Subaru", Validators.required),
  //  color: new FormControl(3)
  //});
  public submitGroup(): void {
    console.info("Looks like you submitted the groups form");
    console.info("Is it valid ? ", this.myFormGroup.valid);
    console.info("Value ", this.myFormGroup.value);
  }

  // Represents the Languages I learned so far
  myFormArrGroup: FormGroup = this._formBuilder.group({ arr: this._formBuilder.array([]) });
  public get myFormArray(): FormArray { return this.myFormArrGroup.get("arr") as FormArray; }
  public addControlToArr() {
    this.myFormArray.push(new FormControl('None', Validators.required));
  }
  public removeControlFromArr(controlIndex: number) {
    this.myFormArray.removeAt(controlIndex);
  }
  public updateYourAss(index: number, value: string) {

  }
  public submitArr() {
    for (let i = 0; i < this.myFormArray.length; i++) {
      console.log(this.myFormArray.at(i).value);
    }
  }
}
