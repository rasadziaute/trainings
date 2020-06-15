import { Component, OnInit } from '@angular/core';
import { EmployeeService } from 'src/app/core/services/employee.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Employee } from 'src/app/core/models/employee.model';
import { of } from 'rxjs';

@Component({
  selector: 'app-employee-details',
  templateUrl: './employee-details.component.html',
  styleUrls: ['./employee-details.component.scss']
})
export class EmployeeDetailsComponent implements OnInit {
  pageTitle = 'Employee Details';

  constructor(private employeeService: EmployeeService,
              private route: ActivatedRoute) { }

  employee: Employee;

  ngOnInit(): void {
    this.route.paramMap.subscribe(
      params => {
        const id = +params.get('id');
        this.getEmployee(id);
      }
    );
  }

  getEmployee(id: number): void {
    this.employeeService.getEmployeeById(id).subscribe(employee =>
      {this.employee = employee;
    });
  }

}
