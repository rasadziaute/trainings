import { Component, OnInit } from "@angular/core";
import { Employee } from "src/app/employee";
import { FormGroup, FormBuilder, NgForm, Validators } from "@angular/forms";
import { EmployeeService } from "src/app/employee.service";
import { ActivatedRoute, Router } from "@angular/router";

@Component({
  selector: "app-employee-edit",
  templateUrl: "./employee-edit.component.html",
  styleUrls: ["./employee-edit.component.css"],
})
export class EmployeeEditComponent implements OnInit {
  employee: Employee;
  employeeForm: FormGroup;

  constructor(
    private employeeService: EmployeeService,
    private route: ActivatedRoute,
    public router: Router,
    private formBuilder: FormBuilder
  ) {}

  ngOnInit() {
    this.employeeService
      .getEmployeeById(this.route.snapshot.params.id)
      .subscribe((data) => {
        this.employee = data;
        this.employeeForm.get("id").setValue(data.id);
        this.employeeForm.get("name").setValue(data.name);
        this.employeeForm.get("department").setValue(data.department);
        this.employeeForm.get("Gender").setValue(data.Gender);
        this.employeeForm.get("designation").setValue(data.designation);
        this.employeeForm.get("sales").setValue(data.sales);
      });

    this.employeeForm = this.formBuilder.group({
      id: [""],
      name: ["", Validators.required],
      department: ["", Validators.required],
      Gender: [""],
      designation: [""],
      sales: [""],
    });
  }

  onSave(form: any) {
    this.employeeService.editEmployee(form).subscribe(
      (res) => {
        const id = res.id;
        this.router.navigate(["details", id]);
      },
      (err) => {
        console.log(err);
      }
    );
  }
}
