/*Task 02. A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts.
Customers could be individuals or companies. All accounts have customer, balance and interest rate (monthly based). 
Deposit accounts are allowed to deposit and with draw money. Loan and mortgage accounts can only deposit money.
All accounts can calculate their interest amount for a given period (in months). 
In the common case its is calculated as follows: number_of_months * interest_rate.
Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
Deposit accounts have no interest if their balance is positive and less than 1000.
Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
Your task is to write a program to model the bank system by classes and interfaces. 
You should identify the classes, interfaces, base classes and abstract actions and implement 
the calculation of the interest functionality through overridden methods.
*/

using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main()
    {
        Customer customerOne = new Individual("Radka Piratka");
        Customer customerTwo = new Company("Miumiunali Brothers");

        Account[] accounts =
        {
            new Deposit(customerOne, 7000, 5.5m, 18),
            new Deposit(customerOne, 980, 5.9m, 12), 
            new Loan(customerOne, 20000, 7.2m, 2),
            new Loan(customerOne, 2000, 8.5m, 9), 
            new Mortgage(customerOne, 14000, 5.4m, 5), 
            new Mortgage(customerOne, 5000, 4.8m, 10), 
            new Deposit(customerTwo, 10000, 6.0m, 12),
            new Mortgage(customerTwo, 14000, 6.6m, 18),
            new Loan(customerTwo, 15000, 8.9m, 2), 
            new Loan(customerTwo, 7000, 7.5m, 12), 
        };

        foreach (Account account in accounts)
        {
            Console.WriteLine(account);
        }

        Deposit radkaDeposit = new Deposit(customerOne, 980, 5.9m, 12);
        Deposit miumiuDeposit = new Deposit(customerTwo, 10000, 6.0m, 12);

        Console.WriteLine();
        Console.WriteLine("Current balance: {0}", radkaDeposit.WithdrawMoney(150));
        Console.WriteLine("Current balance: {0}", radkaDeposit.DepositMoney(1500));
        Console.WriteLine("Current balance: {0}", miumiuDeposit.WithdrawMoney(5642));
        Console.WriteLine("Current balance: {0}", miumiuDeposit.DepositMoney(1247));
    }
}
 