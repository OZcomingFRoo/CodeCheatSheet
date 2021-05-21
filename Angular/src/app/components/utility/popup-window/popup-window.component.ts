import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';


/** Notes
 *  - Utility Component used to create a simple popup element
 *  - Has it's own css Classes give user an option to quick used the component in various senario
 *  - For 
 */
@Component({
  selector: 'app-popup-window',
  templateUrl: './popup-window.component.html',
  styleUrls: ['./popup-window.component.css']
})
export class PopupWindowComponent implements OnInit {

  @Input() show: boolean = false;
  // notice that the name starts as the "show" prop with the suffix "Change"
  // With this, we can do a "2-way-binding" to the "show" property
  // Look at angular source: https://angular.io/guide/two-way-binding#how-two-way-binding-works
  @Output() showChange = new EventEmitter<boolean>(); 
  /** Set to size content space via "em". If false, then will do by percent as default */
  @Input() widthViaEm: boolean = false;
  /** Set to size content space via "em". If false, then will do by percent as default */
  @Input() heightViaEm: boolean = false;
  /** Width in percent (Relative to screen) */
  @Input() width: number = 60;
  /** Width in percent (Relative to screen) */
  @Input() height: number = 50;
  /** Optional parameter to add a title to the window ruler */
  @Input() title: string = "";

  

  constructor() { }

  ngOnInit(): void {
  }

  public get contentStyle(): any {
    let styleObject: any = {};

    if (this.widthViaEm) {
      styleObject["width.em"] = this.width;
    } else {
      styleObject["width.%"] = this.width;
    }

    if (this.heightViaEm) {
      styleObject["height.em"] = this.height;
    } else {
      styleObject["height.%"] = this.height;
    }
    return styleObject;
  }

  closeWindow() {
    this.show = false;
    this.showChange.emit(this.show);
  }
}
