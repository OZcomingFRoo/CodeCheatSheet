import { Component, ElementRef, OnInit, ViewChild, AfterViewInit } from '@angular/core';

@Component({
  selector: 'app-use-element-ref',
  templateUrl: './use-element-ref.component.html',
  styleUrls: ['./use-element-ref.component.css']
})
export class UseElementRefComponent implements OnInit, AfterViewInit {

  @ViewChild('divRef') divRef!: ElementRef<Element>;
  title = "How to use ElementRef";
  constructor() { }

  ngOnInit(): void {
    // This won't work ! but at least no error will be thrown
    this.divRef.nativeElement.textContent = "Div was set in NgOnInit";
  }
  ngAfterViewInit() {
    // Only from this life-cycle you'll be able to access it
    this.divRef.nativeElement.textContent = "Div was set in ngAfterViewInit";
  }
}
