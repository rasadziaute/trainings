import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EmployeeComponent } from './employee/employee.component';
import { CustomPipesComponent } from './custom-pipes/custom-pipes.component';
import { GetNumberOfLettersPipe } from './custom-pipes/pipes/get-number-of-letters.pipe';
import { GetExponentialValuePipe } from './custom-pipes/pipes/get-exponential-value.pipe';

@NgModule({
  declarations: [
    AppComponent,
    EmployeeComponent,
    CustomPipesComponent,
    GetNumberOfLettersPipe,
    GetExponentialValuePipe
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
