import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-employee-parent',
  templateUrl: './employee-parent.component.html',
  styleUrls: ['./employee-parent.component.scss']
})
export class EmployeeParentComponent implements OnInit {
  angularProficiency: number;

  constructor() { }

  GetAngularProficiency(event) {
    this.angularProficiency = event;
  }


  ngOnInit(): void {
  }

}
