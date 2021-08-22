import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-simple-page1',
  templateUrl: './simple-page1.component.html',
  styleUrls: ['./simple-page1.component.css']
})
export class SimplePage1Component implements OnInit {

  constructor(private _router: Router) { }

  ngOnInit(): void {
  }

  goToPage2(): void {
    this._router.navigate(['/Page2'])
  }

}
