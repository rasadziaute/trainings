import { Component, OnInit } from '@angular/core';
import { EmployeeService } from 'src/app/core/services/employee.service';
import { Observable } from 'rxjs';
import { Employee } from 'src/app/core/models/employee.model';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.scss']
})
export class EmployeeListComponent implements OnInit {

  constructor(private employeeService: EmployeeService,
              private route: ActivatedRoute) { }

  employees: Employee[];

  ngOnInit(): void {
    this.route.queryParamMap.subscribe(
      params => {
        const name = params.get('name');
        const location = params.get('location');
        this.getEmployees(name, location);
      }
    );
  }

  getEmployees(name: string, location: string): void {
    this.employeeService.getFilterEmployees(name, location).subscribe(employee =>
      {this.employees = employee;
      });
  }


}
