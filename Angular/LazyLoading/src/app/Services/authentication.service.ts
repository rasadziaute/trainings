import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  constructor() { }
  public authenticateUser(username, password): boolean {
    if (username === 'admin' && password === 'admin123') {
      localStorage.setItem('adminUser', 'LoggedIn');
      return true;
    } else {
      localStorage.clear();
      return false;
    }
  }
}
