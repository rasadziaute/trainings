import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EmployeeComponent } from './employee.component';
import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { AngularMaterialModule } from '../angular-material/angular-material.module';
import { AppRoutingModule } from '../app-routing.module';
import { EmployeeChartDataComponent } from '../employee-chart-data/employee-chart-data.component';
import { EmployeeDetailsComponent } from '../employee-details/employee-details.component';
import { AddEmployeeComponent } from '../add-employee/add-employee.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ChartsModule } from 'ng2-charts';
import { EmployeeService } from '../employee.service';
import { HttpClientModule } from '@angular/common/http';

fdescribe('EmployeeComponent', () => {
  let component: EmployeeComponent;
  let fixture: ComponentFixture<EmployeeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      imports: [AngularMaterialModule, AppRoutingModule, FormsModule, ReactiveFormsModule, ChartsModule,HttpClientModule],
      declarations: [EmployeeComponent, EmployeeDetailsComponent, AddEmployeeComponent, EmployeeChartDataComponent],
      providers:[EmployeeService],
      schemas: [
        CUSTOM_ELEMENTS_SCHEMA
      ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EmployeeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
