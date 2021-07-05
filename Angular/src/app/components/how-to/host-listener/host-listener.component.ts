import { Component, HostListener, OnInit } from '@angular/core';

@Component({
  selector: 'app-host-listener',
  templateUrl: './host-listener.component.html',
  styleUrls: ['./host-listener.component.css']
})
export class HostListenerComponent implements OnInit {

  title = "How to use HostListener Decorator";
  keyPressCounter: number = 0;
  scrollCounter: number = 0;
  constructor() { }

  ngOnInit(): void {
  }

  @HostListener('window:keydown', ['$event'])
  handleKeyDown(event: KeyboardEvent) {
    this.keyPressCounter++;
  }
  @HostListener('window:wheel', ['$event'])
  handleMouseWheel(event: WheelEvent) {
    console.log(event);
    this.scrollCounter++;
  }

}
