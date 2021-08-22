import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-simple-page1',
  templateUrl: './simple-page1.component.html',
  styleUrls: ['./simple-page1.component.css']
})
export class SimplePage1Component implements OnInit {

  routedFrom: string = "";

  constructor(private _router: Router, private _activcatedRoute: ActivatedRoute) { }

  ngOnInit(): void {
    debugger;
    const params = this._activcatedRoute.snapshot.queryParamMap;
    this.routedFrom = params.get("routedFrom") ?? "N/A";
  }

  goToPage2(): void {
    this._router.navigate(['/Page2'], { queryParams: { routedFrom : "Page 1 XD" } })
  }

}
