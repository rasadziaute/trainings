import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TechnologyComponent } from './technology.component';

const routes: Routes = [
  {
    path: '',
    component: TechnologyComponent,
    children: [
      {
      path: 'products',
      loadChildren: () => import('./products/products.module').then(m => m.ProductsModule)
    },
    {
      path: 'levels',
      loadChildren: () => import('./levels/levels.module').then(m => m.LevelsModule)
    },
  ] },
];
@NgModule({
  imports: [RouterModule.forChild(routes)] ,
  exports: [RouterModule]
})
export class TechnologyRoutingModule { }
