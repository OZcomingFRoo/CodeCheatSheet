import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {

  @Input() title = "Navigation Title";
  GuardsDropdown: boolean = false;
  UtilityCompsDropdown: boolean = false;
  showNativePopup = false;
  AngularFormsDropdown: boolean = false;
  OthersDropdown: boolean = false;
  constructor() { }

  ngOnInit(): void {
  }

  clickShowNativePopup() {
    this.UtilityCompsDropdown = false;
    this.showNativePopup = true;
  }

}
