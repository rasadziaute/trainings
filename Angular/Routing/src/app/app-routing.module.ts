import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { EmployeeListComponent } from './features/employee-list/employee-list.component';
import { WelcomeComponent } from './features/welcome/welcome.component';
import { EmployeeDetailsComponent } from './features/employee-details/employee-details.component';
import { ObservableComponent } from './features/observable/observable.component';
import { SearchComponent } from './features/search/search.component';


const routes: Routes = [];

@NgModule({
  imports: [RouterModule.forRoot([
    {path: 'welcome', component: WelcomeComponent},
    {path: 'employees', component: EmployeeListComponent},
    {path: 'employees/:id', component: EmployeeDetailsComponent},
    {path: 'observables', component: ObservableComponent},
    {path: 'search', component: SearchComponent},
    {path: '', redirectTo: 'welcome', pathMatch: 'full'}
  ])],
  exports: [RouterModule]
})
export class AppRoutingModule { }
