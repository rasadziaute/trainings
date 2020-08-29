import { Component, OnInit } from '@angular/core';
import { AuthenticationService } from 'src/app/Services/authentication.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
userName: string;
password: string;

  constructor(private service: AuthenticationService, private router: Router) { }

  ngOnInit(): void {
  }

  UserLogin() {
    const result = this.service.authenticateUser(this.userName, this.password);
    this.router.navigate(['home']);
  }

}
