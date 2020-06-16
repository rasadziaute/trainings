import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TechnologyRoutingModule } from './technology-routing.module';
import { ProductsComponent } from './products/products.component';



@NgModule({
  declarations: [ProductsComponent],
  imports: [
    CommonModule,
    TechnologyRoutingModule
  ]
})
export class TechnologyModule { }
