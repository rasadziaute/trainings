import { Component, OnInit } from '@angular/core';
import { Employee } from './employee';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.scss']
})
export class EmployeeComponent implements OnInit {

  emp: Employee[];
  showActive = true;
  inactiveEmp: Employee[];

  constructor() {
    this.emp = [{
      id: 1,
      name: 'Peter',
      location: 'Pune',
      salary: 123.44568,
      isActive: true,
    },
    {
      id: 2,
      name: 'Sam',
      location: 'Pune',
      salary: 333.9874,
      isActive: false
    },
    {
      id: 3,
      name: 'Jason',
      location: 'USA',
      salary: 456.8873,
      isActive: true
    },
    {
      id: 4,
      name: 'Todd',
      location: 'Canada',
      salary: 46.887344,
      isActive: false
    },
    {
      id: 5,
      name: 'Harry',
      location: 'UK',
      salary: 5546.887344,
      isActive: true
    }
    ];

    this.inactiveEmp = this.emp;
   }

  filterInactive(): void {
    this.showActive = !this.showActive;
    if (this.showActive) {
      this.inactiveEmp = this.emp;
    }
    else {
      this.inactiveEmp = this.emp.filter((emp: Employee) => emp.isActive === false);
    }
  }

  ngOnInit(): void {
  }

}
