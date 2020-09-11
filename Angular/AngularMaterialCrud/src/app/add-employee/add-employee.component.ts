import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators, NgForm } from '@angular/forms';
import { EmployeeService } from '../employee.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['./add-employee.component.css']
})
export class AddEmployeeComponent implements OnInit {
  empForm: FormGroup;
  isDataLoading = false;
  constructor(private empService: EmployeeService, private router: Router, private fb: FormBuilder) { }

  ngOnInit() {

    this.empForm = this.fb.group({
      name: ['', Validators.required],
      designation: ['', Validators.required],
      department: ['', Validators.required],
      Gender: ['', Validators.required]
    });
  }

    onFormSubmit(form: NgForm) {
      this.isDataLoading = true;
      this.empService.addEmployee(form).subscribe(res => {
        const id = res['id'];
        this.router.navigate(['details', id]);
      }, (err) => {
          console.log(err);
      });
    }
  }


