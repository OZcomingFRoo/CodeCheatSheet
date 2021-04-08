import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-in-out-directive',
  templateUrl: './in-out-directive.component.html',
  styleUrls: ['./in-out-directive.component.css']
})
export class InOutDirectiveComponent implements OnInit {

  title = "How to use Input/Output directives";
  constructor() { }

  ngOnInit(): void {
  }

}
