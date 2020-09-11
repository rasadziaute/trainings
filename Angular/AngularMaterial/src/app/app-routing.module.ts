import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './Features/home/home.component';
import { RegisterComponent } from './Features/register/register.component';
import { UrlDetailsComponent } from './Features/url-details/url-details.component';
import { AboutUsComponent } from './Features/about-us/about-us.component';


const routes: Routes = [
  {
    path:'',component:HomeComponent
  },
  { path: 'register', component: RegisterComponent },
  { path: 'url', component: UrlDetailsComponent },
  {path:'about',component:AboutUsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
