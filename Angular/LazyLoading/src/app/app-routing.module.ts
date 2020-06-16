import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './features/home/home.component';


const routes: Routes = [
  {
    path: 'technology',
    loadChildren: () => import('./features/technology/technology.module').then(m => m.TechnologyModule)
  },
  {
    path: 'sales-marketing',
    loadChildren: () => import('./features/sales-marketing/sales-marketing.module').then(m => m.SalesMarketingModule)
  },
  {
    path: 'hr',
    loadChildren: () => import('./features/human-resources/human-resource.module').then(m => m.HumanResourcesModule)
  },
  {path: 'home', component: HomeComponent},
  {path: '', redirectTo: 'home', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
