import { EmployeeService } from "./EmployeeService";

let e=new EmployeeService();

console.log(e.getEmployees());

e.updateEmployeeById(4,'random name', undefined ,'new department');

e.deleteEmployeeById(1);

e.insertEmployee(6, 'new name', 'new designation', 'new department', 'new gender');

console.log(e.getEmployees());

