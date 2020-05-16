import { CustomerService } from "./CustomerService";

let customer = new CustomerService(1, 'Customer Name', 500);


console.log(customer.displayElectricityBill());