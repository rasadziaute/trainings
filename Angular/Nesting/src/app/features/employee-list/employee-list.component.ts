import { Component, OnInit, Input, Output } from '@angular/core';
import { Employee } from 'src/app/core/models/employee.model';
import { EmployeeService } from 'src/app/core/services/employee.service';
import { EventEmitter } from '@angular/core';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.scss']
})
export class EmployeeListComponent implements OnInit {
  employees: Employee[];
  newEmployees: Employee[];
  @Output() angularProficiency: EventEmitter<any> = new EventEmitter<any>();

  constructor(private employeeService: EmployeeService) { }

  CreateEmployee(event) {
    this.employees.push(event);
    this.newEmployees.push(event);
  }

  GetAngularProficiency(angularProficiency: number) {
    this.angularProficiency.emit(angularProficiency);
  }

  ngOnInit(): void {
    this.employeeService.getEmployees().subscribe(employees => this.employees = employees);
    this.newEmployees = [];
  }

}
