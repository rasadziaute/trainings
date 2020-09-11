import { Component, OnInit } from "@angular/core";
import { Employee } from "../employee";
import { EmployeeService } from "../employee.service";
import { ActivatedRoute, Router } from "@angular/router";

@Component({
  selector: "app-employee-details",
  templateUrl: "./employee-details.component.html",
  styleUrls: ["./employee-details.component.css"],
})
export class EmployeeDetailsComponent implements OnInit {
  emp: Employee = {
    id: 0,
    name: "",
    department: "",
    Gender: "",
    designation: "",
    sales: "",
  };
  isDataLoading = true;
  constructor(
    private empService: EmployeeService,
    private route: ActivatedRoute,
    private router: Router
  ) {}

  ngOnInit() {
    this.getEmployeeID(this.route.snapshot.params.id);
  }

  getEmployeeID(id) {
    this.empService.getEmployeeById(id).subscribe((data) => {
      this.isDataLoading = false;
      this.emp = data;
      console.log(this.emp);
    });
  }

  deleteEmployee(id) {
    this.isDataLoading = true;
    this.empService.deleteEmployee(id).subscribe(
      (res) => {
        this.isDataLoading = false;
        this.router.navigate(["/employees"]);
      },
      (err) => {
        console.log(err);
        this.isDataLoading = false;
      }
    );
  }

  editEmployee(id) {
    this.isDataLoading = true;
  }
}
