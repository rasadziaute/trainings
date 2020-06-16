import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SalesMarketingComponent } from './sales-marketing.component';


const routes: Routes = [
  {
    path: '',
    component: SalesMarketingComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SalesMarketingRoutingModule { }
