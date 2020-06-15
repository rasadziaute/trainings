import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EmployeeListComponent } from './features/employee-list/employee-list.component';
import { EmployeeDetailsComponent } from './features/employee-details/employee-details.component';
import { WelcomeComponent } from './features/welcome/welcome.component';
import { ObservableComponent } from './features/observable/observable.component';
import { SearchComponent } from './features/search/search.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    EmployeeListComponent,
    EmployeeDetailsComponent,
    WelcomeComponent,
    ObservableComponent,
    SearchComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
