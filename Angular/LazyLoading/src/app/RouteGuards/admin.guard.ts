import { Injectable } from '@angular/core';
import { CanLoad, Route, UrlSegment, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { AuthenticationService } from '../Services/authentication.service';

@Injectable({
  providedIn: 'root'
})
export class AdminGuard implements CanLoad {
  constructor(private service: AuthenticationService, private router: Router) {}

  canLoad(): boolean {
    if (localStorage.getItem('adminUser') !== null)
    {
      return true;
    }
    else {
      alert('Not Allowed to access this page!!');
    }
  }
}
