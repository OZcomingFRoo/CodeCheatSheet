import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-simple-page2',
  templateUrl: './simple-page2.component.html',
  styleUrls: ['./simple-page2.component.css']
})
export class SimplePage2Component implements OnInit {

  routedFrom: string = "";

  constructor(private _router: Router, private _activcatedRoute: ActivatedRoute) { }

  ngOnInit(): void {
    debugger;
    const params = this._activcatedRoute.snapshot.queryParamMap;
    this.routedFrom = params.get("routedFrom") ?? "N/A";
  }

  goToPage1(): void {
    this._router.navigate(['/Page1'], { queryParams: { routedFrom: "Page 2 XD" } })
  }

}
