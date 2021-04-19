import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, Router } from '@angular/router';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class QueryAuthEqualTrueExampleGuard implements CanActivate {

  constructor(private router: Router) { }

  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
    let authQueryValue = route.queryParamMap.get("auth");
    if (authQueryValue === "true") {
      return true;
    } else {
      this.router.navigate(['NotAuth']);
      return false;
    }
  }
  
}
