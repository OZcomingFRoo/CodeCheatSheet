import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-routing',
  templateUrl: './routing.component.html',
  styleUrls: ['./routing.component.css']
})
export class RoutingComponent implements OnInit {

  constructor(private _router: Router) { }

  ngOnInit(): void {
  }
  goToPage2(): void {
    this._router.navigate(['/Page2'])
  }
}
