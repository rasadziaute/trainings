import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { EmployeeComponent } from './employee/employee.component';
import { CustomPipesComponent } from './custom-pipes/custom-pipes.component';


const routes: Routes = [
  {path: 'employees', component: EmployeeComponent},
  {path: 'pipes', component: CustomPipesComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
