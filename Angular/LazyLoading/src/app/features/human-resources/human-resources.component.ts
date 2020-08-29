import { Component, OnInit } from '@angular/core';
import { EmployeeService } from 'src/app/Services/employee.service';
import { Employee } from 'src/app/shared/models/employee.model';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-human-resources',
  templateUrl: './human-resources.component.html',
  styleUrls: ['./human-resources.component.scss']
})
export class HumanResourcesComponent implements OnInit {

  constructor(private employeeService: EmployeeService) { }
  employees: Observable<Employee[]>;

  ngOnInit(): void {
    this.employees = this.employeeService.getEmployees();
  }

}
