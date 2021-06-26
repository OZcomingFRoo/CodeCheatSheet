import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-host-listener',
  templateUrl: './host-listener.component.html',
  styleUrls: ['./host-listener.component.css']
})
export class HostListenerComponent implements OnInit {

  title = "How to use HostListener Decorator";
  constructor() { }

  ngOnInit(): void {
  }

}
