import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EmployeeListComponent } from './features/employee-list/employee-list.component';
import { HttpClientModule } from '@angular/common/http';
import { RatingComponent } from './shared/rating/rating.component';
import { EmployeeCreateComponent } from './features/employee-create/employee-create.component';
import { FormsModule } from '@angular/forms';
import { StoredRecordsComponent } from './features/stored-records/stored-records.component';
import { EmployeeParentComponent } from './features/employee-parent/employee-parent.component';


@NgModule({
  declarations: [
    AppComponent,
    EmployeeListComponent,
    RatingComponent,
    EmployeeCreateComponent,
    StoredRecordsComponent,
    EmployeeParentComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
