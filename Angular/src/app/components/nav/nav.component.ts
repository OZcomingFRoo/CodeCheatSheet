import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {

  @Input() title = "Navigation Title";
  toggleHowToDropdown: boolean = false;
  GuardsDropdown: boolean = false;
  UtilityCompsDropdown: boolean = false;
  showNativePopup = false;
  AngularFormsDropdown: boolean = false;
  constructor() { }

  ngOnInit(): void {
  }

  clickShowNativePopup() {
    this.UtilityCompsDropdown = false;
    this.showNativePopup = true;
  }

}
