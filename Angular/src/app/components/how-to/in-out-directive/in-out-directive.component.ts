import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';


@Component({
  selector: 'app-in-out-directive',
  templateUrl: './in-out-directive.component.html',
  styleUrls: ['./in-out-directive.component.css']
})
export class InOutDirectiveComponent implements OnInit {

  title = "How to use Input/Output directives";
  // -------- One-way Binding -------- //
  @Input() myInput: string = "";
  @Output() myOutput = new EventEmitter<string>();
  myOutputVal: string = "";

  // -------- Two-way Binding -------- //
  @Input() IOput = ""
  // NOTICE! The naming starts the same with a suffix "Change" in the end of it.
  // This is a must for the Two-way binding to work!!!
  @Output() IOputChange = new EventEmitter<string>();

  constructor() { }

  ngOnInit(): void { }

}
