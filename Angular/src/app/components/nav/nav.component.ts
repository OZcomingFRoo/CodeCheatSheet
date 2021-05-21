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
  PopupModelsDropdown: boolean = false;
  showNativePopup = false;
  constructor() { }

  ngOnInit(): void {
  }

  clickShowNativePopup() {
    this.PopupModelsDropdown = false;
    this.showNativePopup = true;
  }

}
