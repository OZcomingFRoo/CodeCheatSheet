import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-input-file-btn-page',
  templateUrl: './input-file-btn-page.component.html',
  styleUrls: ['./input-file-btn-page.component.css']
})
export class InputFileBtnPageComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  multiFile($event: any) {
    console.log("Multi File");
    console.log($event);
  }
  singleFile($event: any) {
    console.log("Single File");
    console.log($event);
  }
}
