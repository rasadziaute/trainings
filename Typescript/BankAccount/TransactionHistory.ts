import { ITransaction } from "./ITransaction";

export class TransactionHistory
{
    transactions:ITransaction[];
    constructor (){
        this.transactions =[];
    };

    public displayTransactionHistory():void
    {
        console.log(this.transactions);
    }

    public recordTransaction(custname:string, accno:number, acctype:string, opertion:string, amount:number, balance:number):void
    {
        let newTransaction = {} as ITransaction;
        newTransaction.custname = custname;
        newTransaction.accno = accno;
        newTransaction.acctype = acctype;
        newTransaction.operation = opertion;
        newTransaction.amount = amount;
        newTransaction.balance = balance;

        this.transactions.push(newTransaction);

    }

}