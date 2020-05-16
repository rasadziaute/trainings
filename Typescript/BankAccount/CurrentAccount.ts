import {Account } from "./Account";
import { TransactionHistory } from "./TransactionHistory";
export class CurrentAccount extends Account
{
    public balance:number=2000;
    public displayBalance():void
    {
        console.log(`Balance is ${this.balance}`);
    }
 
    public DepositCurrent(deposit):void
    {
            this.balance=this.balance+deposit;
            this.recordTransaction(this.custname, this.accno, this.acctype, 'deposit', deposit, this.balance);
            console.log(`Updated Balance${this.balance}`);
    }
 
    public withdraw(withdrawamount)
    {
        let penatly:number;
        let hasWithdraw:boolean = true;
        console.log(`Balance ${this.balance}`);
        this.balance=this.balance-withdrawamount;
        if(this.balance<500)
        {
            penatly=(500-this.balance)/10;
            this.balance=this.balance-penatly;
            console.log(`Balance after deducting penalty amount is ${this.balance}`);
 
        }
 
        else if( this.balance < withdrawamount)
        {
            hasWithdraw = false;
            console.log("You cannot withdraw amount,Please make use of overdraft facility");
        }
 
        else
        {
            console.log(`Amount Balance after withdraw ${this.balance}`);
        }

        if (hasWithdraw) {
            this.recordTransaction(this.custname, this.accno, this.acctype, 'withdrawamount', withdrawamount, this.balance);
        }
    }
    
}