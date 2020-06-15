import { Component, OnInit } from '@angular/core';
import { EmployeeService } from 'src/app/core/services/employee.service';
import { Employee } from 'src/app/core/models/employee.model';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.scss']
})
export class SearchComponent implements OnInit {

  constructor(private employeeService: EmployeeService) { }

  employees: Employee[];
  name: string;
  location: string;

  ngOnInit(): void {

  }
}
