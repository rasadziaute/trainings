import {CurrentAccount } from "./CurrentAccount";
import {SavingAccount } from "./SavingAccount";

let current=new CurrentAccount();
let saveaccount=new SavingAccount();
current.getAccount('Mayura',5436456,'Current');
current.DepositCurrent(200);
current.withdraw(500)
current.displayTransactionHistory();
// current.DisplayDetails();
// current.displayBalance();
// current.withdraw(200);
// saveaccount.DepositSaving(10000);