import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './features/home/home.component';
import { LoginComponent } from './features/login/login.component';
import { AdminGuard } from './RouteGuards/admin.guard';
import { EmployeeResolver } from './shared/resolver/employee.resolver';


const routes: Routes = [
  {
    path: 'technology',
    loadChildren: () => import('./features/technology/technology.module').then(m => m.TechnologyModule),
    canLoad: [AdminGuard],
  },
  {
    path: 'sales-marketing',
    loadChildren: () => import('./features/sales-marketing/sales-marketing.module').then(m => m.SalesMarketingModule)
  },
  {
    path: 'hr',
    loadChildren: () => import('./features/human-resources/human-resource.module').then(m => m.HumanResourcesModule),
    resolve: {
      employee: EmployeeResolver,
    },
  },
  {path: 'login', component: LoginComponent},
  {path: 'home', component: HomeComponent},
  {path: '', redirectTo: 'home', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  providers: [EmployeeResolver],
  exports: [RouterModule]
})
export class AppRoutingModule { }
