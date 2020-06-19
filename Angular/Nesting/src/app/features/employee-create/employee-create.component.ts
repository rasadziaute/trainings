import { Component, OnInit, Output, OnChanges, createPlatformFactory } from '@angular/core';
import { Employee } from 'src/app/core/models/employee.model';
import { EventEmitter } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-employee-create',
  templateUrl: './employee-create.component.html',
  styleUrls: ['./employee-create.component.scss']
})
export class EmployeeCreateComponent implements OnInit {
  employee: Employee;
  @Output() newEmployeeRecord: EventEmitter<Employee> = new EventEmitter<Employee>();

  constructor() {
    this.employee = new Employee();
  }

  AddEmployeeDetails() {
    const data = {
      id: this.employee.id,
      name: this.employee.name,
      projectId: this.employee.projectId,
      angularProficiency: this.employee.angularProficiency
    };
    this.newEmployeeRecord.emit(data);
  }

  Reset(createForm: NgForm) {

    createForm.resetForm();

  }

  ngOnInit(): void {
  }

}
