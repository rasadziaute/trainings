import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { EmployeeDetailsComponent } from './employee-details/employee-details.component';
import { EmployeeComponent } from './employee/employee.component';
import { AddEmployeeComponent } from './add-employee/add-employee.component';
import { EmployeeChartDataComponent } from './employee-chart-data/employee-chart-data.component';


const routes: Routes = [
  {
    path:'employees',component:EmployeeComponent
  },
  { path: 'details/:id', component: EmployeeDetailsComponent },
  { path: 'add', component: AddEmployeeComponent },
  {path:'stat',component:EmployeeChartDataComponent},
  { path: '', redirectTo: '/employees', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
