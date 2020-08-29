import { Resolve } from '@angular/router';
import { Injectable } from '@angular/core';
import { Employee } from '../models/employee.model';
import { EmployeeService } from 'src/app/Services/employee.service';

@Injectable()
export class EmployeeResolver implements Resolve<Employee> {
  constructor(private service: EmployeeService) {}
  resolve(): any {
    return this.service.getEmployees();
  }
}
