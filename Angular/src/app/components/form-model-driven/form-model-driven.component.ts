import { Component, OnInit } from '@angular/core';
import { FormControl , Validators } from '@angular/forms';

@Component({
  selector: 'app-form-model-driven',
  templateUrl: './form-model-driven.component.html',
  styleUrls: ['./form-model-driven.component.css']
})
export class FormModelDrivenComponent implements OnInit {

  constructor() { }

  public firstName: FormControl = new FormControl('Inochi', [Validators.required, Validators.minLength(2)]);
  public lastName: FormControl = new FormControl('Ookami', [Validators.required, Validators.minLength(2)]);

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


}
