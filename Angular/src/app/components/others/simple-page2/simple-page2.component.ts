import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-simple-page2',
  templateUrl: './simple-page2.component.html',
  styleUrls: ['./simple-page2.component.css']
})
export class SimplePage2Component implements OnInit {

  constructor(private _router: Router) { }

  ngOnInit(): void {
  }

  goToPage1(): void {
    this._router.navigate(['/Page1'])
  }

}
