import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TechnologyComponent } from './technology.component';
import { ProductsComponent } from './products/products.component';


const routes: Routes = [
  {
    path: '',
    component: TechnologyComponent, children: [
      // {
      //   path: 'products',
      //   loadChildren: () => import('./products/products.module').then(m => m.ProductsModule)
      // },
      {
        path: 'products', component: ProductsComponent
      },
      {
        path: 'levels',
        loadChildren: () => import('./levels/levels.module').then(m => m.LevelsModule)
      },
    ]
  },
  {
    path: 'products', component: ProductsComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)] ,
  exports: [RouterModule]
})
export class TechnologyRoutingModule { }

