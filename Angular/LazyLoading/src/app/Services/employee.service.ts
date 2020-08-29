import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Employee } from '../shared/models/employee.model';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  employees: Employee[];

  constructor() {
    this.employees = [{
      id: 1,
      name: 'Tom',
      location: 'Vilnius',
      salary: 123.30,
      department: 'Sales',
      position: 'Junior Sales Person'
    },
    {
      id: 2,
      name: 'Sandra',
      location: 'Vilnius',
      salary: 180.30,
      department: 'HR',
      position: 'HR Junior Person'
    },
    {
      id: 3,
      name: 'Harry',
      location: 'Cape Town',
      salary: 309,
      department: 'Technology',
      position: 'Software Engineer'
    },
    {
      id: 4,
      name: 'Brian',
      location: 'London',
      salary: 800,
      department: 'Technology',
      position: 'Architect'
    },
    {
      id: 5,
      name: 'Catherine',
      location: 'Cape Town',
      salary: 1000,
      department: 'HR',
      position: 'HR Head'
    },
    {
      id: 6,
      name: 'Ashesh',
      location: 'Bangalore',
      salary: 400,
      department: 'Technology',
      position: 'UI Specialist'
    },
    {
      id: 7,
      name: 'Tom',
      location: 'London',
      salary: 900,
      department: 'Technology',
      position: 'Senior SE'
    },
    ];
  }

  public getEmployees(): Observable<Employee[]> {
    return of(this.employees);
  }
}
