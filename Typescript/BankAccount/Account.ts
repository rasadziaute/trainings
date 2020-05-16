import {TransactionHistory } from "./TransactionHistory";

export class Account extends TransactionHistory
{
   public custname:string;
    accno:number;
    acctype:string;
 
    public getAccount(name,accno,type)
    {
        this.custname=name;
        this.accno=accno;
        this.acctype=type;
    }
 
    public DisplayDetails()
    {
        console.log(`Customer Name is ${this.custname}`);
        console.log(`Customer Account ${this.accno}`);
        console.log(`Account Type ${this.acctype}`);
    }
}
 
