import { ICustomer } from "./ICustomer";

export class CustomerService {
    private customer:ICustomer;
    private bill:number;
    private surchargePercent:number = 0.15;
    private payLater:boolean = false;

    constructor(id:number, name:string, units:number)
    {

        this.customer = {id: id, name: name, units: units};
    }

    private calculateElectricityBill():void
    {
        if (this.customer.units < 200) {
            this.bill = this.customer.units * 1.2
        }
        else if (this.customer.units < 400 ) {
            this.bill = this.customer.units * 1.5
        }
        else if (this.customer.units < 600) {
            this.bill = this.customer.units * 1.8
        }
        else {
            this.bill = this.customer.units * 2
        }
    }

    private validateBill():void
    {
        if(this.bill < 100)
        {
            this.payLater = true;
        }
        else if (this.bill > 400) {
            this.bill = this.bill + (this.bill * this.surchargePercent)
        }
    }

    public displayElectricityBill():string
    {
        this.calculateElectricityBill();
        this.validateBill();

        if (this.payLater) {
            return `Dear ${this.customer.name} for ${this.customer.units} units your bill of ${this.bill} Rs is too small, pay later`;
        }
        else {
            return `Dear ${this.customer.name} for ${this.customer.units} units your bill is ${this.bill}`;
        }

    }

}