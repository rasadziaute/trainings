import {Account } from "./Account";

export class SavingAccount extends Account
{
    public savingbalance:number=5000;
    public displayBalance():void
    {
        console.log(`Balance is ${this.savingbalance}`);
    }
 
    public DepositSaving(deposit):void
    {
        let interest:number;
            this.savingbalance=this.savingbalance+deposit;
            interest=(this.savingbalance *2 )/100;
            this.savingbalance=this.savingbalance+interest;
            this.recordTransaction(this.custname, this.accno, this.acctype, 'deposit', deposit, this.savingbalance);
            console.log(`Updated Balance${this.savingbalance}`);
 
    }
 
    public withdrawSaving(withdrawamount)
    {
        let penatly:number;
        let hasWithdraw:boolean = true;
        console.log(`Balance ${this.savingbalance}`);
        this.savingbalance=this.savingbalance-withdrawamount;
        if(this.savingbalance<800)
        {
            penatly=(500-this.savingbalance)/10;
            this.savingbalance=this.savingbalance-penatly;
            console.log(`Balance after deducting penalty amount is ${this.savingbalance}`);
 
        }
 
        else if( this.savingbalance < withdrawamount)
        {
            hasWithdraw = false;
            console.log("You cannot withdraw amount,Please make use of overdraft facility");
        }
 
        else
        {
            console.log(`Amount Balance after withdraw ${this.savingbalance}`);
        }

        if (hasWithdraw) {
            this.recordTransaction(this.custname, this.accno, this.acctype, 'withdrawamount', withdrawamount, this.savingbalance);
        }
    }
    
}