import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../employee.service';
import { Employee } from '../employee';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {
  displayedColumns: string[] = ['name', 'designation', 'department', 'Gender'];
  data: Employee[] = [];
  isDataLoading = true;
  constructor(private empService: EmployeeService) { }

  ngOnInit() {
    this.empService.getEmployees().subscribe(res => {
      this.data = res;
      console.log(this.data);
      this.isDataLoading = false;
    }, err => {
      console.log(err);
      this.isDataLoading = false;
    });


  }

}
